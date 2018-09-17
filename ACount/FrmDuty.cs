using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AreaCount
{
    public partial class FrmDuty : Form
    {
        public FrmDuty()
        {
            InitializeComponent();
        }

        static string sExcelConn = "";

        private void GetDutyInfo()
        {
            string sDTime = DateTime.Now.ToString("yyyy-MM");
            string sSQL = string.Format("select M_DutyID,M_Date,M_Name,M_Deputy,M_TelNo,M_Phone,M_InerPhone,M_Month from IO_LeaderDuty where M_Month>='{0}'  order by M_Month,convert(int,M_Date)"
               , sDTime);
            DataSet dsDuty = new DataSet();
            dsDuty = SqlHelper.ExecuteDataSet(sSQL);
            DbGridDuty.DataSource = dsDuty.Tables[0];
        }

        private bool DelDutyInfo(string sID)
        {
            string sSQL = string.Format("delete from IO_LeaderDuty where M_DutyID={0} "
               , sID);
            int iResult = SqlHelper.ExecuteNonQuery(sSQL);
            return (iResult > 0);
        }

        private void ImportDutyInfo(string sFile, string sMonth)
        {
            if (File.Exists(sFile))
            {
                //获取文件后缀名 
                if (System.IO.Path.GetExtension(sFile).ToLower() == ".xls")
                {
                    //如果是07以下（.xls）的版本的Excel文件就使用这条连接字符串
                    sExcelConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sFile + ";Extended Properties=Excel 8.0;";
                }
                else
                {
                    //如果是07以上(.xlsx)的版本的Excel文件就使用这条连接字符串
                    sExcelConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + sFile + ";Extended Properties='Excel 12.0; HDR=NO; IMEX=1'"; //此連接可以操作.xls與.xlsx文件
                }
                if (System.IO.Path.GetExtension(sFile).ToLower().Contains(".xls"))
                {
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    //打开Excel的连接，设置连接对象
                    OleDbConnection conn = new OleDbConnection(sExcelConn);
                    conn.Open();
                    DataTable sheetNames = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    string sTableName = sheetNames.Rows[0][2].ToString().Trim();
                    OleDbDataAdapter oada = new OleDbDataAdapter("select * from [" + sTableName + "]", sExcelConn);
                    DataTable ds = new DataTable();
                    oada.Fill(ds);
                    string sDate, sName, sDeputy, sTelNo, sPhone, sInerPhone, sMsg = "";
                    int iError = 0;
                    bool bInsert;
                    for (int j = 1; j < ds.Rows.Count; j++)
                    {
                        sDate = sName = sDeputy = sTelNo = sPhone = sInerPhone = sMsg = "";
                        bInsert = true;
                        for (int i = 0; i < ds.Columns.Count; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    sDate = ds.Rows[j][i].ToString();
                                    break;
                                case 1:
                                    sName = ds.Rows[j][i].ToString();
                                    break;
                                case 2:
                                    sDeputy = ds.Rows[j][i].ToString();
                                    break;
                                case 3:
                                    sTelNo = ds.Rows[j][i].ToString();
                                    break;
                                case 4:
                                    sPhone = ds.Rows[j][i].ToString();
                                    break;
                                case 5:
                                    sInerPhone = ds.Rows[j][i].ToString();
                                    break;
                                case 6:
                                    //sMonth = ds.Rows[j][i].ToString();
                                    break;
                            }
                        }
                        if (sDate.Length == 0)
                        {
                            sMsg = String.Format("第{0}行：日期不能为空.", j);
                            bInsert = false;
                        }
                        if (sName.Length == 0)
                        {
                            sMsg += String.Format("第{0}行：姓名不能为空.", j);
                            bInsert = false;
                        }
                        if (bInsert)
                        {
                            string sSQL = string.Format("insert into IO_LeaderDuty(M_Date,M_Name,M_Deputy,M_TelNo,M_Phone,M_InerPhone,M_Month) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                                        sDate, sName, sDeputy, sTelNo, sPhone, sInerPhone, sMonth);
                            SqlHelper.ExecuteNonQuery(sSQL);
                        }
                        else
                        {
                            iError = iError + 1;
                        }
                    }

                    if (iError > 0)
                    {
                        MessageBox.Show(sMsg);
                    }
                    conn.Close();
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                    GetDutyInfo();
                }
                else
                {
                    MessageBox.Show("excel 格式不正确！");
                }

            }

        }

        private void tlBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDuty_Shown(object sender, EventArgs e)
        {
            GetDutyInfo();
            cmBoxMonth.SelectedIndex = 0;
        }

        private void DbGridDuty_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DbGridDuty_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DbGridDuty.CurrentRow != null)
            {
                int index = DbGridDuty.CurrentRow.Index;
                tBoxName.Text = DbGridDuty.Rows[index].Cells[2].Value.ToString();
                tBoxDeputy.Text = DbGridDuty.Rows[index].Cells[3].Value.ToString();
                tBoxTel.Text = DbGridDuty.Rows[index].Cells[4].Value.ToString();
                tBoxPhone.Text = DbGridDuty.Rows[index].Cells[5].Value.ToString();
                tBoxInerPhone.Text = DbGridDuty.Rows[index].Cells[6].Value.ToString();
                tBoxDate.Text = DbGridDuty.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void tlBtnModify_Click(object sender, EventArgs e)
        {
            if (tBoxName.Text.Length == 0)
            {
                MessageBox.Show("姓名不能为空，请输入姓名", "温馨提示");
                tBoxName.Focus();
                return;
            }
            if (tBoxDate.Text.Length == 0)
            {
                MessageBox.Show("日期不能为空，请输入日期", "温馨提示");
                tBoxDate.Focus();
                return;
            }
            if (this.DbGridDuty.CurrentRow != null)
            {
                int index = DbGridDuty.CurrentRow.Index;
                string sID = DbGridDuty.Rows[index].Cells[ColID.Index].Value.ToString();
                string sSQL = string.Format("update IO_LeaderDuty set M_Date='{0}',M_Name='{1}',M_Deputy='{2}',M_TelNo='{3}',M_Phone='{4}',M_InerPhone='{5}' where M_DutyID={6}",
                                           tBoxDate.Text, tBoxName.Text, tBoxDeputy.Text, tBoxTel.Text, tBoxPhone.Text, tBoxInerPhone.Text, sID);
                int iResult = SqlHelper.ExecuteNonQuery(sSQL);
                if (iResult > 0)
                {
                    MessageBox.Show("修改完成", "温馨提示");
                    GetDutyInfo();
                }
                else { }
            }
            else
            {
                MessageBox.Show("值班信息修改失败，请检查网路或数据库设置是否正确", "温馨提示");
            }


        }

        private void tBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只允许输入数字，粘贴数字
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == (char)3 || e.KeyChar == (char)22))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == (char)22)
                {
                    try
                    {
                        Clipboard.SetText(Clipboard.GetText().Trim()); //去空格
                        int date = Convert.ToInt32(Clipboard.GetText());  //检查是否数字
                        if (date < 1 || date > 31)
                        {
                            e.Handled = true;
                        }
                    }
                    catch (Exception)
                    {
                        e.Handled = true;
                        //throw;
                    }
                }
                else if (Char.IsNumber(e.KeyChar))
                {
                    int date = Convert.ToInt32((sender as TextBox).Text + e.KeyChar);

                    if (date < 1 || date > 31)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void tlBtnDel_Click(object sender, EventArgs e)
        {
            if (DbGridDuty.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择需要删除的值班信息。", "温馨提示");
                return;
            }
            else
            {
                if (MessageBox.Show("是否要删除选定的值班信息？", "温馨提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DbGridDuty.SelectedRows)
                    {
                        string sID = DbGridDuty.Rows[row.Index].Cells[ColID.Index].Value.ToString();
                        DelDutyInfo(sID);
                    }
                    GetDutyInfo();
                    MessageBox.Show("删除完成。", "温馨提示");
                }
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (ofDlgExcel.ShowDialog() == DialogResult.OK)
            {
                tBoxExcel.Text = ofDlgExcel.FileName;
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (tBoxExcel.Text.Length == 0)
            {
                MessageBox.Show("请先选择值班人员信息excel文档", "温馨提示");
                tBoxExcel.Focus();
                return;
            }
            if (File.Exists(tBoxExcel.Text))
            {
                string sMonth = "";
                switch (cmBoxMonth.SelectedIndex)
                {
                    case 0:
                        sMonth = DateTime.Now.ToString("yyyy-MM");
                        break;
                    case 1:
                        sMonth = DateTime.Now.AddMonths(1).ToString("yyyy-MM");
                        break;
                    default:
                        sMonth = "";
                        break;
                }
                ImportDutyInfo(tBoxExcel.Text, sMonth);
            }
        }
    }
}
