using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AreaCount
{
    public partial class FrmPerSelect : Form
    {
        private string mGroupsId = "";
        List<RoleInfo> items;
        List<PersonReportInfo> reportInfoList;
        string m_DevIds = "";
        string m_PersonCondition = "";
        string m_RolesCondition = "";
        bool m_NormalChecked = true;
        bool m_GroupChecked = true;
        string m_PersonId = "";

        public FrmPerSelect()
        {
            InitializeComponent();
            LoadGroupData();
            LoadCardType();
            LoadScreenType();
            reportInfoList = new List<PersonReportInfo>();
        }

        private void LoadGroupData()
        {
            string sql = "SELECT Base_GroupID,Base_GroupName,Base_AuthID,Base_IsDel,Base_Level,Base_Tel,Base_Addr,Base_Memo" +
                " FROM General_Group  WHERE Base_GroupID <> '-1'  AND Base_IsDel <> '1'" +
                " AND Base_GroupID IN (select Base_GroupID from General_Group_Oper where Base_OperCode = '" + SqlHelper.UserId + "')" +
                " ORDER BY Base_AuthID";

            int iLastLevel = -1;

            SqlParameter[] param = null;
            DataTable dataTable = null;
            TreeNode treeNode = null;
            TreeNode tempNode = null;

            dataTable = SqlHelper.ExecuteDataTable(sql, param);
            this.treeViewGroup.Nodes.Clear();
            foreach (DataRow dt in dataTable.Rows)
            {
                GroupInfo groupInfo = new GroupInfo();
                groupInfo.GroupId = dt["Base_GroupID"].ToString();
                groupInfo.GroupName = dt["Base_GroupName"].ToString();
                if (dt["Base_IsDel"].ToString().Equals("1"))
                {
                    groupInfo.GroupName = groupInfo.GroupName + "(删除)";
                }
                groupInfo.AuthId = dt["Base_AuthID"].ToString();
                groupInfo.ILevel = Convert.ToInt32(dt["Base_Level"].ToString());
                if (iLastLevel != groupInfo.ILevel)
                {
                    treeNode = null;
                    if (this.treeViewGroup.Nodes.Count > 0)
                    {
                        foreach (TreeNode newNode in this.treeViewGroup.Nodes)
                        {
                            treeNode = CheckTreeViewList(newNode, groupInfo);
                            if (treeNode != null)
                            {
                                break;
                            }
                        }
                    }
                }
                if (treeNode == null)
                {
                    tempNode = this.treeViewGroup.Nodes.Add(groupInfo.GroupName);
                }
                else
                {
                    tempNode = treeNode.Nodes.Add(groupInfo.GroupName);
                }
                tempNode.Tag = groupInfo;
                iLastLevel = groupInfo.ILevel;
            }

            for (int i = 0; i < this.treeViewGroup.Nodes.Count; i++)
            {
                if ((this.treeViewGroup.Nodes[i].Tag as GroupInfo).ILevel == 0)
                {
                    this.treeViewGroup.Nodes[i].Expand();
                }
            }
        }

        private TreeNode CheckTreeViewList(TreeNode nodes, GroupInfo groupInfo)
        {
            TreeNode targetNode = null;
            if (nodes.Tag != null)
            {
                if ((nodes.Tag as GroupInfo).AuthId + groupInfo.GroupId + "." == groupInfo.AuthId)
                {
                    targetNode = nodes;
                    return targetNode;
                }
            }

            //有子节点
            foreach (TreeNode newNode in nodes.Nodes)
            {
                targetNode = CheckTreeViewList(newNode, groupInfo);
                if (targetNode != null)
                {
                    return targetNode;
                }
            }

            return targetNode;
        }

        private void LoadCardType()
        {
            string sql = "SELECT * FROM General_Role" +
                " WHERE Base_IsDel <> '1'" +
                " ORDER BY Base_RoleID";

            SqlParameter[] param = null;
            DataTable dataTable = null;
            dataTable = SqlHelper.ExecuteDataTable(sql, param);
            items = new List<RoleInfo>();
            items.Add(new RoleInfo("全部", "0"));
            foreach (DataRow dt in dataTable.Rows)
            {
                RoleInfo item = new RoleInfo(dt["Base_RoleName"].ToString(), dt["Base_RoleID"].ToString());
                items.Add(item);
            }
            this.comboBoxCardType.DisplayMember = "Text";
            this.comboBoxCardType.ValueMember = "Value";
            this.comboBoxCardType.DataSource = items;
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
        }

        private void ShowPerData()
        {
            mGroupsId = "";
            foreach (TreeNode newNode in this.treeViewGroup.Nodes)
            {
                WalkCheckNode(newNode);
            }

            if (mGroupsId.Length > 0)
            {
                string sql = string.Format("SELECT A.Base_PerID,A.Base_PerNo,A.Base_PerName,A.Base_CardNo,A.Base_GroupID FROM General_Personnel A WHERE A.Base_GroupID IN({0}) AND A.Base_IsDel <> '1' ORDER BY A.Base_PerNo"
               , mGroupsId);

                SqlParameter[] param = null;
                DataTable dataTable = null;
                dataTable = SqlHelper.ExecuteDataTable(sql, param);

                this.listViewPerson.Items.Clear();
                foreach (DataRow dt in dataTable.Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = dt["Base_PerID"].ToString();
                    lvi.Text = dt["Base_PerNo"].ToString();
                    lvi.SubItems.Add(dt["Base_PerName"].ToString());
                    lvi.SubItems.Add(dt["Base_CardNo"].ToString());
                    this.listViewPerson.Items.Add(lvi);
                }
            }
            else
            {
                this.listViewPerson.Items.Clear();
            }
            if (this.listViewPerson.Items.Count > 0)
            {
                this.listViewPerson.Items[0].Selected = true;
            }
        }

        private void WalkCheckNode(TreeNode node)
        {
            if (node.ImageIndex == 1)
            {
                if (mGroupsId.Length == 0)
                {
                    mGroupsId = "'" + (node.Tag as GroupInfo).GroupId + "'";
                }
                else
                {
                    mGroupsId += ",'" + (node.Tag as GroupInfo).GroupId + "'";
                }
            }
            if (node.ImageIndex != 0)
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (TreeNode child in node.Nodes)
                    {
                        WalkCheckNode(child);
                    }
                }
            }
        }

        private void treeViewGroup_MouseUp(object sender, MouseEventArgs e)
        {
            ShowPerData();
            ShowCondition(radioButtonPerson.Checked);
        }

        private void treeViewGroup_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // 0:没有选中  1:选中  2：部分选中
            var bound = Rectangle.Union(e.Node.Bounds, new Rectangle(e.Node.Bounds.Location - new Size(19, 0), new Size(19, 15)));// 去掉+/-区域
            if (bound.Contains(new Point(e.X, e.Y)))
            {
                if (e.Node.ImageIndex == 1)
                {
                    e.Node.SelectedImageIndex = 0;
                    e.Node.ImageIndex = 0;

                    SetNodeImg11(e.Node);
                    SetNodeImg12(e.Node);
                }
                else
                {
                    e.Node.SelectedImageIndex = 1;
                    e.Node.ImageIndex = 1;

                    SetNodeImg21(e.Node);
                    SetNodeImg22(e.Node);
                }
            }
        }

        //设置节点选定状态：规则.1：检查是否有子节点，需清除所有子节点的选定状态；
        private void SetNodeImg11(TreeNode tn)
        {
            foreach (TreeNode t in tn.Nodes)
            {
                t.SelectedImageIndex = 0;
                t.ImageIndex = 0;
                if (t.Nodes.Count != 0)
                {
                    SetNodeImg11(t);
                }
            }
        }


        //设置节点选定状态：规则.2：检查是否有父节点，如有，则根据兄弟节点的选定状态修改父节点的选定状态
        private void SetNodeImg12(TreeNode tn)
        {
            if (tn.Parent == null)
                return;
            int Img0Num = 0;
            int Img1Num = 0;
            int Img2Num = 0;
            //统计兄弟节点中选中情况
            foreach (TreeNode t in tn.Parent.Nodes)
            {
                if (t.ImageIndex == -1 || t.ImageIndex == 0)
                    Img0Num++;
                if (t.ImageIndex == 1)
                    Img1Num++;
                if (t.ImageIndex == 2)
                    Img2Num++;
            }
            //如果兄弟节点中选中和未选中都有
            if ((Img2Num != 0) || ((Img0Num != 0) && (Img1Num != 0)))
            {
                tn.Parent.SelectedImageIndex = 2;
                tn.Parent.ImageIndex = 2;
            }
            else
            {
                tn.Parent.StateImageIndex = 0;
                tn.Parent.ImageIndex = 0;
            }
            //递归
            SetNodeImg12(tn.Parent);
        }


        //设置节点选定状态：规则.1：检查是否有子节点，设置所有子节点为选定状态
        private void SetNodeImg21(TreeNode tn)
        {
            foreach (TreeNode t in tn.Nodes)
            {
                t.SelectedImageIndex = 1;
                t.ImageIndex = 1;
                if (t.Nodes.Count != 0)
                {
                    SetNodeImg21(t);
                }
            }
        }


        //设置节点选定状态：规则.2：检查是否有父节点，如有，则根据兄弟节点的选定状态修改父节点的选定状态
        private void SetNodeImg22(TreeNode tn)
        {
            if (tn.Parent == null)
                return;
            int Img0Num = 0;
            int Img1Num = 0;
            int Img2Num = 0;
            //统计兄弟节点中选中情况
            foreach (TreeNode t in tn.Parent.Nodes)
            {
                if (t.ImageIndex == -1 || t.ImageIndex == 0)
                    Img0Num++;
                if (t.ImageIndex == 1)
                    Img1Num++;
                if (t.ImageIndex == 2)
                    Img2Num++;
            }
            //如果兄弟节点中选中和未选中都有
            if ((Img2Num != 0) || ((Img0Num != 0) && (Img1Num != 0)))
            {
                tn.Parent.SelectedImageIndex = 2;
                tn.Parent.ImageIndex = 2;
            }
            else if ((Img1Num == 0) && (Img2Num == 0))
            {
                tn.Parent.SelectedImageIndex = 0;
                tn.Parent.ImageIndex = 0;
            }
            else
            {
                tn.Parent.StateImageIndex = 1;
                tn.Parent.ImageIndex = 1;
            }
            //递归
            SetNodeImg22(tn.Parent);
        }

        private void ShowCondition(bool show)
        {
            if (show)
            {
                if (this.listViewPerson.SelectedItems.Count > 0)
                {
                    textBoxPerNo.Text = this.listViewPerson.SelectedItems[0].SubItems[0].Text;
                    textBoxPerNo.Tag = this.listViewPerson.SelectedItems[0].Tag;
                    textBoxPerName.Text = this.listViewPerson.SelectedItems[0].SubItems[1].Text;
                    textBoxCardNo.Text = this.listViewPerson.SelectedItems[0].SubItems[2].Text;
                }
                else
                {
                    textBoxPerNo.Text = "全部";
                    textBoxPerNo.Tag = "";
                    textBoxPerName.Text = "";
                    textBoxCardNo.Text = "";
                }
                textBoxPerNo.Enabled = true;
                textBoxPerName.Enabled = true;
                textBoxCardNo.Enabled = true;
            }
            else
            {
                textBoxPerNo.Text = "全部";
                textBoxPerName.Text = "";
                textBoxCardNo.Text = "";
                textBoxPerNo.Enabled = false;
                textBoxPerName.Enabled = false;
                textBoxCardNo.Enabled = false;
            }
        }

        private void radioButtonPerson_CheckedChanged(object sender, EventArgs e)
        {
            ShowCondition(radioButtonPerson.Checked);
        }

        private void radioButtonGroup_CheckedChanged(object sender, EventArgs e)
        {
            ShowCondition(radioButtonPerson.Checked);
        }

        private void listViewPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCondition(radioButtonPerson.Checked);
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

        private void queryPersonAndPerview()
        {
            string sql = "";
            int timeout = 30;
            if (m_NormalChecked)
            {
                sql = "select  F.Base_RoleID,G.Base_RoleName,E.Base_PerID,F.Base_PerNo,F.Base_PerName,F.Base_CardNo,F.Base_Tel,F.Base_Memo," +
                    " CONVERT(VARCHAR(19),Access_DateTime,121) as Access_DateTime,H.Base_GroupName,'' as Access_OutTime from" +
                    " (select top 500000  a.* from AcvB_AccessLog a where ISNULL(Base_PerID,'')<>'' and a.Device_ID in(" +
                    m_DevIds + ") and a.Access_DateTime=(select MAX(Access_DateTime) from AcvB_AccessLog" +
                    " where Base_PerID=a.Base_PerID and isnull(Reserved,'')<>'1' ) order by Base_PerID) E,General_Personnel F,General_Role G,General_Group H" +
                    " where E.Base_PerID=F.Base_PerID and F.Base_RoleID=G.Base_RoleID and" +
                    " F.Base_GroupID=H.Base_GroupID and E.InOutFlag='0' and E.Card_Status='1'" + m_PersonCondition + m_RolesCondition +
                    " order by F.Base_RoleID,F.Base_GroupID";
            }
            else
            {
                timeout = 200;
                if (m_GroupChecked)
                {
                    sql = "select G.Base_PerID,H.Base_PerNo,H.Base_PerName,H.Base_CardNo,I.Base_GroupName,J.Base_RoleName," +
                        " CONVERT(VARCHAR(19),max(G.Access_DateTime),121) AS Access_DateTime,H.Base_Tel" +
                        " from AcvB_AccessLog G,General_Personnel H,General_Group I,General_Role J" +
                        " where G.Base_PerID=H.Base_PerID and H.Base_GroupID=I.Base_GroupID and" +
                        " H.Base_RoleID=J.Base_RoleID and G.Base_PerID in (select F.Base_PerID" +
                        " from General_Personnel F where F.Base_IsDel='0'" + m_PersonCondition +
                        " and F.Base_PerID in (select B.Base_PerID from (select top 2 * from AcvB_AccessLog A" +
                        " where isnull(A.Reserved,'')='' and A.Base_PerID=F.Base_PerID) B" +
                        " where B.InOutFlag='0' group by B.Base_PerID having count(*)>1 union" +
                        " select B.Base_PerID from (select top 2 * from AcvB_AccessLog A" +
                        " where isnull(A.Reserved,'')='' and A.Base_PerID=F.Base_PerID) B" +
                        " where B.InOutFlag='1' group by B.Base_PerID having count(*)>1))" +
                        " group by G.Base_PerID,H.Base_PerNo,H.Base_PerName,H.Base_CardNo,I.Base_GroupName,J.Base_RoleName,H.Base_Tel";
                }
                else
                {
                    sql = "select G.Base_PerID,H.Base_PerNo,H.Base_PerName,H.Base_CardNo,I.Base_GroupName,J.Base_RoleName," +
                        " CONVERT(VARCHAR(19),max(G.Access_DateTime),121) AS Access_DateTime,H.Base_Tel" +
                        " from AcvB_AccessLog G,General_Personnel H,General_Group I,General_Role J" +
                        " where G.Base_PerID=H.Base_PerID and H.Base_GroupID=I.Base_GroupID and" +
                        " H.Base_RoleID=J.Base_RoleID and G.Base_PerID in (select F.Base_PerID" +
                        " from General_Personnel F where F.Base_IsDel='0' and F.Base_PerID in" +
                        " (select B.Base_PerID from (select top 2 * from AcvB_AccessLog A where isnull(A.Reserved,'')=''" +
                        " and A.Base_PerID='" + m_PersonId + "') B where B.InOutFlag='0' group by B.Base_PerID having count(*)>1" +
                        " union select B.Base_PerID from (select top 2 * from AcvB_AccessLog A where isnull(A.Reserved,'')=''" +
                        " and A.Base_PerID='" + m_PersonId + "') B where B.InOutFlag='1' group by B.Base_PerID having count(*)>1))" +
                        " group by G.Base_PerID,H.Base_PerNo,H.Base_PerName,H.Base_CardNo,I.Base_GroupName,J.Base_RoleName,H.Base_Tel";
                } 
            }

            SqlParameter[] param = null;
            DataTable dataTable = null;
            dataTable = SqlHelper.ExecuteDataTable(sql, param, timeout);
            reportInfoList.Clear();
            foreach (DataRow dt in dataTable.Rows)
            {
                PersonReportInfo reportInfo = new PersonReportInfo();
                reportInfo.PersonNo = dt["Base_PerNo"].ToString();
                reportInfo.CarNo = dt["Base_CardNo"].ToString();
                reportInfo.PersonName = dt["Base_PerName"].ToString();
                reportInfo.GroupName = dt["Base_GroupName"].ToString();
                reportInfo.CardType = dt["Base_RoleName"].ToString();
                reportInfo.InTime = dt["Access_DateTime"].ToString();
                //reportInfo.OutTime = dt["Access_OutTime"].ToString();
                reportInfo.PhoneNo1 = dt["Base_Tel"].ToString();
                //reportInfo.PhoneNo2 = dt["Base_Memo"].ToString();
                reportInfoList.Add(reportInfo);
            }
        }

        private void updateQueryParam()
        {
            m_DevIds = convertToSqlStr((comboBoxScreenId.SelectedItem as RoleInfo).Value);
            if (radioButtonGroup.Checked)
            {
                m_PersonCondition = " and F.Base_GroupID IN(" + mGroupsId + ")";
            }
            else
            {
                m_PersonCondition = " and E.Base_PerID=('" + textBoxPerNo.Tag + "')";
            }

            if (0 != comboBoxCardType.SelectedIndex)
            {
                m_RolesCondition = String.Format(" and F.Base_RoleID={0}", (comboBoxCardType.SelectedItem as RoleInfo).Value);
            }
            m_NormalChecked = radioButtonNormal.Checked;
            m_GroupChecked = radioButtonGroup.Checked;
            m_PersonId = textBoxPerNo.Tag as string;
        }

        private void FrmPerSelect_Load(object sender, EventArgs e)
        {
            
        }

        //CheckLoading，注意参数一致
        public void CheckLoading(object sender, DoWorkEventArgs e)
        {
            queryPersonAndPerview();
        }

        private void toolStripButtonQuery_Click(object sender, EventArgs e)
        {
            if (mGroupsId.Length > 0)
            {
                updateQueryParam();

                BackgroundWorker worker = new BackgroundWorker();
                worker.WorkerSupportsCancellation = true;
                //CheckLoading为窗体显示过程中需要处理算法的方法
                worker.DoWork += new DoWorkEventHandler(CheckLoading);
                worker.RunWorkerAsync();

                //显示进度窗体
                FrmLoading f = new FrmLoading(worker);
                f.ShowDialog(this);
                //queryPersonAndPerview();

                XtraReportPerson reportPerson = new XtraReportPerson();
                reportPerson.DataSource = reportInfoList;
                ReportPrintTool printTool = new ReportPrintTool(reportPerson);
                //printTool.ShowRibbonPreview();
                //printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
                //printTool.ShowPreview();
                printTool.ShowPreviewDialog(UserLookAndFeel.Default);
            }
            else
            {
                MessageBox.Show("未选择群，请重新选择!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
