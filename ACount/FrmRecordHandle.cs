using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCount
{
    public partial class FrmRecordHandle : Form
    {
        private string mGroupsId = "";
        private string m_PersonNo = "";
        private string m_CardNo = "";
        DataSet m_Records;

        public FrmRecordHandle(string perNo, string cardNo)
        {
            m_PersonNo = perNo;
            m_CardNo = cardNo;
            InitializeComponent();
            LoadPersonRecord();
        }

        private void LoadPersonRecord()
        {
            string sql = String.Format("select A.Log_ID,B.Base_PerNo,B.Base_PerName,C.Base_GroupName,E.Base_RoleName,D.Device_Name,A.Access_DateTime,B.Base_Tel from (select * from AcvB_AccessLog where Card_No='{0}' and isnull(Reserved,'')='' and Log_ID > (select top 1 Log_ID from AcvB_AccessLog where Card_No='{0}' and InOutFlag='1' order by Log_ID desc)) A left join General_Personnel B on A.Base_PerID=B.Base_PerID left join General_Group C on B.Base_GroupID=C.Base_GroupID left join AcvB_Device D on A.Device_ID=D.Device_ID left join General_Role E on B.Base_RoleID=E.Base_RoleID", m_CardNo);
            m_Records = new DataSet();
            m_Records = SqlHelper.ExecuteDataSet(sql, 300);
            dataGridViewPerson.DataSource = m_Records.Tables[0];
        }

        //CheckLoading，注意参数一致
        public void CheckLoading(object sender, DoWorkEventArgs e)
        {
            QueryPerData();
        }

        private void QueryPerData()
        {
            mGroupsId = "";

            if (mGroupsId.Length > 0)
            {
                string sSQL = string.Format("select G.Base_PerID,H.Base_PerNo,H.Base_PerName,H.Base_CardNo,I.Base_GroupName,J.Base_RoleName,CONVERT(VARCHAR(19),max(G.Access_DateTime),121) AS Access_DateTime,H.Base_Tel from AcvB_AccessLog G,General_Personnel H,General_Group I,General_Role J where G.Base_PerID=H.Base_PerID and H.Base_GroupID=I.Base_GroupID and H.Base_RoleID=J.Base_RoleID and G.Base_PerID in (select F.Base_PerID from General_Personnel F where F.Base_IsDel='0' and F.Base_GroupID in({0}) and F.Base_PerID in (select B.Base_PerID from (select top 2 * from AcvB_AccessLog A where isnull(A.Reserved,'')='' and A.Base_PerID=F.Base_PerID) B where B.InOutFlag='0' group by B.Base_PerID having count(*)>1 union select B.Base_PerID from (select top 2 * from AcvB_AccessLog A where isnull(A.Reserved,'')='' and A.Base_PerID=F.Base_PerID) B where B.InOutFlag='1' group by B.Base_PerID having count(*)>1)) group by G.Base_PerID,H.Base_PerNo,H.Base_PerName,H.Base_CardNo,I.Base_GroupName,J.Base_RoleName,H.Base_Tel"
                   , mGroupsId);
                m_Records = new DataSet();
                m_Records = SqlHelper.ExecuteDataSet(sSQL, 300);
            }
        }

        private void dataGridViewPerson_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewPerson.CurrentRow != null)
            {
                toolStripButtonFix.Enabled = true;
            }
            else
            {
                toolStripButtonFix.Enabled = false;
            }
        }

        private void toolStripButtonFix_Click(object sender, EventArgs e)
        {
            if (dataGridViewPerson.CurrentRow != null)
            {
                if(DialogResult.Yes == MessageBox.Show("请确认是否修复此条刷卡记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    int index = dataGridViewPerson.CurrentRow.Index;
                    string logId = dataGridViewPerson.Rows[index].Cells[2].Value.ToString();
                    string sql = String.Format("update AcvB_AccessLog set Reserved='1' where Log_ID='{0}'", logId);

                    SqlParameter[] param = null;
                    SqlHelper.ExecuteSql(sql, param);

                    LoadPersonRecord();
                }
                
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRecordHandle_Shown(object sender, EventArgs e)
        {
            if (null == dataGridViewPerson.CurrentRow)
            {
                toolStripButtonFix.Enabled = false;
            }
        }
    }
}
