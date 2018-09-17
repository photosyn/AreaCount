using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AreaCount
{
    public partial class FrmLogIn : Form
    {
        List<RoleInfo> items;

        public FrmLogIn()
        {
            SqlHelper.Init();
            InitializeComponent();
            ShowOperCode();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void ShowOperCode()
        {
            if (SqlHelper.Connected)
            {
                string sql = "SELECT Base_OperCode FROM General_Oper_User ORDER BY Base_OperCode";
                SqlParameter[] paras = null;
                DataTable dataTable = null;
                dataTable = SqlHelper.ExecuteDataTable(sql, paras);
                items = new List<RoleInfo>();
                foreach (DataRow dt in dataTable.Rows)
                {
                    RoleInfo item = new RoleInfo(dt["Base_OperCode"].ToString(), dt["Base_OperCode"].ToString());
                    items.Add(item);
                }
                this.comboBoxUser.DisplayMember = "Text";
                this.comboBoxUser.ValueMember = "Value";
                this.comboBoxUser.DataSource = items;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDBSet frmDbSet = new FrmDBSet();
            frmDbSet.ShowDialog();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (this.comboBoxUser.Text.Length == 0)
            {
                MessageBox.Show("请输入用户名", "温馨提示");
                comboBoxUser.Focus();
                return;
            }
            if (tBoxPsw.Text.Length == 0)
            {
                MessageBox.Show("请输入密码", "温馨提示");
                tBoxPsw.Focus();
                return;
            }
            if (SqlHelper.Connected)
            {
                if (PubDbOperate.CheckUser(comboBoxUser.Text, tBoxPsw.Text))
                {
                    SqlHelper.UserId = comboBoxUser.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请检查是否输入正确。", "温馨提示");
                }
            }
            else
            {
                MessageBox.Show("数据库连接失败，请先设置数据库连接", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tBoxPsw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//判断回车键
            {
                BtnOK.Focus();
            }
        }

        private void BtnOK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//判断回车键
            {
                BtnOK_Click(sender, e);
            }
        }
    }
}
