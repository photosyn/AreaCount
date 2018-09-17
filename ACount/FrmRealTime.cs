using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AreaCount
{
    public partial class FrmRealTime : Form
    {
        List<RoleInfo> items;
        bool m_Stop = true;
        SynchronizationContext m_SyncContext = null;
        string m_DevIds = "";
        string m_DevNames = "";

        public FrmRealTime(bool dealRecord = false)
        {
            InitializeComponent();
            m_SyncContext = SynchronizationContext.Current;
            LoadScreenType();
            InitializeListView();

            if(!dealRecord)
            {
                toolStripButtonRecord.Visible = false;
                toolStripButtonQuery.Visible = false;
                toolStripSeparator4.Visible = false;
                toolStripSeparator5.Visible = false;
                groupBox2.Visible = false;
                groupBox4.Visible = false;
                Thread thread = new Thread(ThreadMethod);
                thread.IsBackground = true;
                thread.Name = "AreaCount";
                thread.Start();
            }
            else
            {
                listViewRealTime.ContextMenuStrip = contextMenuStrip1;
                toolStripButtonRealTime.Visible = false;
                toolStripButtonCancel.Visible = false;
                toolStripButtonRefresh.Visible = false;
                toolStripSeparator1.Visible = false;
                toolStripSeparator2.Visible = false;
                toolStripSeparator3.Visible = false;
                if (this.listViewRealTime.FocusedItem != null)
                {
                    toolStripButtonRecord.Enabled = true;
                }
                else
                {
                    toolStripButtonRecord.Enabled = false;
                }
            }
        }

        private void LoadScreenType()
        {
            string sql = "SELECT * FROM AcvB_AsyMonitorInfo" +
                " ORDER BY Screen_ID";

            SqlParameter[] param = null;
            DataTable dataTable = null;
            dataTable = SqlHelper.ExecuteDataTable(sql, param);
            items = new List<RoleInfo>();
            foreach (DataRow dt in dataTable.Rows)
            {
                RoleInfo item = new RoleInfo("屏幕" + dt["Screen_ID"].ToString(), dt["Monitor_Devs"].ToString());
                items.Add(item);
            }
            this.comboBoxScreenId.DisplayMember = "Text";
            this.comboBoxScreenId.ValueMember = "Value";
            this.comboBoxScreenId.DataSource = items;

            m_DevIds = convertToSqlStr((comboBoxScreenId.SelectedItem as RoleInfo).Value);

            sql = "SELECT * FROM AcvB_Device where Device_ID in("+ (comboBoxScreenId.SelectedItem as RoleInfo).Value  + ") ORDER BY Device_ID";
            dataTable = SqlHelper.ExecuteDataTable(sql, param);
            m_DevNames = "";
            foreach (DataRow dt in dataTable.Rows)
            {
                if(m_DevNames.Length > 0)
                {
                    m_DevNames += "， " + dt["Device_Name"].ToString();
                }
                else
                {
                    m_DevNames = dt["Device_Name"].ToString();
                }
            }
            labelZone.Text = m_DevNames;
        }

        private void InitializeListView()
        {
            QueryRealTimeData();
        }

        private void RefreshListView(object list)
        {
            this.listViewRealTime.Items.Clear();
            if (list != null)
            {
                this.listViewRealTime.Items.AddRange(list as ListViewItem[]);
            }
            labelTotal.Text = String.Format("在厂总人数：{0}", this.listViewRealTime.Items.Count);
        }

        private string convertToSqlStr(string devList)
        {
            string word = "";
            string[] split = devList.Split(new Char[] { ',' });
            foreach (string dev in split)
            {
                if (word.Length > 0)
                {
                    word += ",'" + dev + "'";
                }
                else
                {
                    word = "'" + dev + "'";
                }
            }
            return word;
        }

        private void QueryRealTimeData()
        {


            SqlParameter[] paras = null;
            string sql = "select F.Base_PerNo,F.Base_PerName,F.Base_CardNo,G.Base_RoleName,H.Base_GroupName,E.Access_DateTime,F.Base_Tel from" +
                " (select top 500000  a.* from AcvB_AccessLog a where ISNULL(Base_PerID,'')<>'' and InOutFlag='0' and Card_Status='1' and Device_ID in(" + m_DevIds +
                ") and a.Access_DateTime=(select MAX(Access_DateTime) from AcvB_AccessLog where Base_PerID=a.Base_PerID and isnull(Reserved,'')='' ) order by Base_PerID) E," +
                " General_Personnel F,General_Role G,General_Group H where E.Base_PerID=F.Base_PerID and F.Base_RoleID=G.Base_RoleID and F.Base_GroupID=H.Base_GroupID order by F.Base_PerID";
            DataTable dataTable = SqlHelper.ExecuteDataTable(sql, paras);

            ListViewItem[] listItems = null;
            if (dataTable.Rows.Count > 0)
            {
                listItems = new ListViewItem[dataTable.Rows.Count];
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = dataTable.Rows[i]["Base_CardNo"].ToString();
                    lvi.Text = dataTable.Rows[i]["Base_PerNo"].ToString();
                    lvi.SubItems.Add(dataTable.Rows[i]["Base_PerName"].ToString());
                    lvi.SubItems.Add(dataTable.Rows[i]["Base_GroupName"].ToString());
                    lvi.SubItems.Add(dataTable.Rows[i]["Base_RoleName"].ToString());
                    lvi.SubItems.Add(dataTable.Rows[i]["Access_DateTime"].ToString());
                    lvi.SubItems.Add(dataTable.Rows[i]["Base_Tel"].ToString());
                    listItems[i] = lvi;
                }
            }

            m_SyncContext.Post(RefreshListView, listItems);
        }

        public void ThreadMethod(object sender)
        {
            while (true)
            {
                if (!m_Stop)
                {
                    QueryRealTimeData();
                }
                Thread.Sleep(1000);
            }
        }

        private void comboBoxScreenId_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_DevIds = convertToSqlStr((comboBoxScreenId.SelectedItem as RoleInfo).Value);

            SqlParameter[] param = null;
            DataTable dataTable = null;
            string sql = "SELECT * FROM AcvB_Device where Device_ID in(" + (comboBoxScreenId.SelectedItem as RoleInfo).Value + ") ORDER BY Device_ID";
            dataTable = SqlHelper.ExecuteDataTable(sql, param);
            m_DevNames = "";
            foreach (DataRow dt in dataTable.Rows)
            {
                if (m_DevNames.Length > 0)
                {
                    m_DevNames += "， " + dt["Device_Name"].ToString();
                }
                else
                {
                    m_DevNames = dt["Device_Name"].ToString();
                }
            }
            labelZone.Text = m_DevNames;

            QueryRealTimeData();
        }

        private void FrmRealTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_Stop = true;
            comboBoxScreenId.Enabled = true;
            toolStripButtonRefresh.Enabled = true;
            toolStripButtonRealTime.Enabled = true;
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            QueryRealTimeData();
        }

        private void toolStripButtonRealTime_Click(object sender, EventArgs e)
        {
            m_Stop = false;
            comboBoxScreenId.Enabled = false;
            toolStripButtonRefresh.Enabled = false;
            toolStripButtonRealTime.Enabled = false;
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            m_Stop = true;
            comboBoxScreenId.Enabled = true;
            toolStripButtonRefresh.Enabled = true;
            toolStripButtonRealTime.Enabled = true;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonRecord_Click(object sender, EventArgs e)
        {
            if (this.listViewRealTime.FocusedItem != null)
            {
                ListViewItem viewItem = this.listViewRealTime.FocusedItem;
                FrmRecordHandle frmRecord = new FrmRecordHandle(viewItem.Text, viewItem.Tag as string);
                frmRecord.ShowDialog();
            }
            
        }

        private void listViewRealTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewRealTime.FocusedItem != null)
            {
                toolStripButtonRecord.Enabled = true;
            }
            else
            {
                toolStripButtonRecord.Enabled = false;
            }
        }

        private void ToolStripMenuItemCheck_Click(object sender, EventArgs e)
        {
            if (this.listViewRealTime.FocusedItem != null)
            {
                ListViewItem viewItem = this.listViewRealTime.FocusedItem;
                FrmRecordHandle frmRecord = new FrmRecordHandle(viewItem.Text, viewItem.Tag as string);
                frmRecord.ShowDialog();
            }
        }

        private void toolStripButtonQuery_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.Length > 0)
            {
                listViewRealTime.Select();
                ListViewItem foundItem = listViewRealTime.FindItemWithText(textBoxName.Text, true, 1, true);
                if (foundItem != null)
                {
                    foundItem.Selected = true;
                    foundItem.Focused = true;
                }
            }
            else
            {
                MessageBox.Show("请输入查询条件", "提示");
            }
        }

        private void ToolStripMenuItemQuery_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0)
            {
                listViewRealTime.Select();
                ListViewItem foundItem = listViewRealTime.FindItemWithText(textBoxName.Text, true, 1, true);
                if (foundItem != null)
                {
                    foundItem.Selected = true;
                    foundItem.Focused = true;
                }
            }
            else
            {
                MessageBox.Show("请输入查询条件", "提示");
            }
        }
    }
}
