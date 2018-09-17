using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;
using System.Drawing;

namespace AreaCount
{
    public partial class FrmInAreaInfo : Form
    {
        private string mGroupsId = "";
        List<RoleInfo> items;
        List<PerInAreaInfo> perAreaList;

        public FrmInAreaInfo()
        {
            InitializeComponent();
            LoadGroupData();
            LoadCardType();
            LoadAreaDevInfo();
            perAreaList = new List<PerInAreaInfo>();
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

        private void LoadAreaDevInfo()
        {
            string sql = "select * from IO_AreaName2";

            SqlParameter[] param = null;
            DataTable dataTable = null;
            dataTable = SqlHelper.ExecuteDataTable(sql, param);

            if (dataTable.Rows.Count > 0)
            {
                AreaInfo areaInfo = new AreaInfo();
                areaInfo.AreaId = dataTable.Rows[0]["M_AreaId"].ToString();
                areaInfo.AreaName = this.buttonEditArea1.Text = dataTable.Rows[0]["M_Name"].ToString();
                areaInfo.Title = this.textBoxArea1.Text = dataTable.Rows[0]["M_Title"].ToString();
                areaInfo.AreaDevs = dataTable.Rows[0]["M_Devs"].ToString();
                areaInfo.Used = Convert.ToInt32(dataTable.Rows[0]["M_Used"].ToString());
                this.checkBox1.Checked = (areaInfo.Used > 0);
                this.buttonEditArea1.Tag = areaInfo;
            }
            if (dataTable.Rows.Count > 1)
            {
                AreaInfo areaInfo = new AreaInfo();
                areaInfo.AreaId = dataTable.Rows[1]["M_AreaId"].ToString();
                areaInfo.AreaDevs = dataTable.Rows[1]["M_Devs"].ToString();
                areaInfo.AreaName = this.buttonEditArea2.Text = dataTable.Rows[1]["M_Name"].ToString();
                areaInfo.Title = this.textBoxArea2.Text = dataTable.Rows[1]["M_Title"].ToString();
                areaInfo.Used = Convert.ToInt32(dataTable.Rows[1]["M_Used"].ToString());
                this.checkBox2.Checked = (areaInfo.Used > 0);
                this.buttonEditArea2.Tag = areaInfo;
            }
            if (dataTable.Rows.Count > 2)
            {
                AreaInfo areaInfo = new AreaInfo();
                areaInfo.AreaId = dataTable.Rows[2]["M_AreaId"].ToString();
                areaInfo.AreaDevs = dataTable.Rows[2]["M_Devs"].ToString();
                areaInfo.AreaName = this.buttonEditArea3.Text = dataTable.Rows[2]["M_Name"].ToString();
                areaInfo.Title = this.textBoxArea3.Text = dataTable.Rows[2]["M_Title"].ToString();
                areaInfo.Used = Convert.ToInt32(dataTable.Rows[2]["M_Used"].ToString());
                this.checkBox3.Checked = (areaInfo.Used > 0);
                this.buttonEditArea3.Tag = areaInfo;
            }
            if (dataTable.Rows.Count > 3)
            {
                AreaInfo areaInfo = new AreaInfo();
                areaInfo.AreaId = dataTable.Rows[3]["M_AreaId"].ToString();
                areaInfo.AreaDevs = dataTable.Rows[3]["M_Devs"].ToString();
                areaInfo.AreaName = this.buttonEditArea4.Text = dataTable.Rows[3]["M_Name"].ToString();
                areaInfo.Title = this.textBoxArea4.Text = dataTable.Rows[3]["M_Title"].ToString();
                areaInfo.Used = Convert.ToInt32(dataTable.Rows[3]["M_Used"].ToString());
                this.checkBox4.Checked = (areaInfo.Used > 0);
                this.buttonEditArea4.Tag = areaInfo;
            }
            if (dataTable.Rows.Count > 4)
            {
                AreaInfo areaInfo = new AreaInfo();
                areaInfo.AreaId = dataTable.Rows[4]["M_AreaId"].ToString();
                areaInfo.AreaDevs = dataTable.Rows[4]["M_Devs"].ToString();
                areaInfo.AreaName = this.buttonEditArea5.Text = dataTable.Rows[4]["M_Name"].ToString();
                areaInfo.Title = this.textBoxArea5.Text = dataTable.Rows[4]["M_Title"].ToString();
                areaInfo.Used = Convert.ToInt32(dataTable.Rows[4]["M_Used"].ToString());
                this.checkBox5.Checked = (areaInfo.Used > 0);
                this.buttonEditArea5.Tag = areaInfo;
            }
            if (dataTable.Rows.Count > 5)
            {
                AreaInfo areaInfo = new AreaInfo();
                areaInfo.AreaId = dataTable.Rows[5]["M_AreaId"].ToString();
                areaInfo.AreaDevs = dataTable.Rows[5]["M_Devs"].ToString();
                areaInfo.AreaName = this.buttonEditArea6.Text = dataTable.Rows[5]["M_Name"].ToString();
                areaInfo.Title = this.textBoxArea6.Text = dataTable.Rows[5]["M_Title"].ToString();
                areaInfo.Used = Convert.ToInt32(dataTable.Rows[5]["M_Used"].ToString());
                this.checkBox6.Checked = (areaInfo.Used > 0);
                this.buttonEditArea6.Tag = areaInfo;
            }
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

        private void buttonEditArea1_Click(object sender, EventArgs e)
        {
            FrmAreaSelect frmAreaSelect = new FrmAreaSelect(this.buttonEditArea1.Tag as AreaInfo);
            frmAreaSelect.ShowDialog();
            AreaInfo areaInfo = frmAreaSelect.AreaInfo;
            if (!this.buttonEditArea1.Text.Equals(areaInfo.AreaName))
            {
                this.buttonEditArea1.Text = areaInfo.AreaName;
            }
        }

        private void buttonEditArea2_Click(object sender, EventArgs e)
        {
            FrmAreaSelect frmAreaSelect = new FrmAreaSelect(this.buttonEditArea2.Tag as AreaInfo);
            frmAreaSelect.ShowDialog();
            AreaInfo areaInfo = frmAreaSelect.AreaInfo;
            if (!this.buttonEditArea2.Text.Equals(areaInfo.AreaName))
            {
                this.buttonEditArea2.Text = areaInfo.AreaName;
            }
        }

        private void buttonEditArea3_Click(object sender, EventArgs e)
        {
            FrmAreaSelect frmAreaSelect = new FrmAreaSelect(this.buttonEditArea3.Tag as AreaInfo);
            frmAreaSelect.ShowDialog();
            AreaInfo areaInfo = frmAreaSelect.AreaInfo;
            if (!this.buttonEditArea3.Text.Equals(areaInfo.AreaName))
            {
                this.buttonEditArea3.Text = areaInfo.AreaName;
            }
        }

        private void buttonEditArea4_Click(object sender, EventArgs e)
        {
            FrmAreaSelect frmAreaSelect = new FrmAreaSelect(this.buttonEditArea4.Tag as AreaInfo);
            frmAreaSelect.ShowDialog();
            AreaInfo areaInfo = frmAreaSelect.AreaInfo;
            if (!this.buttonEditArea4.Text.Equals(areaInfo.AreaName))
            {
                this.buttonEditArea4.Text = areaInfo.AreaName;
            }
        }

        private void buttonEditArea5_Click(object sender, EventArgs e)
        {
            FrmAreaSelect frmAreaSelect = new FrmAreaSelect(this.buttonEditArea5.Tag as AreaInfo);
            frmAreaSelect.ShowDialog();
            AreaInfo areaInfo = frmAreaSelect.AreaInfo;
            if (!this.buttonEditArea5.Text.Equals(areaInfo.AreaName))
            {
                this.buttonEditArea5.Text = areaInfo.AreaName;
            }
        }

        private void buttonEditArea6_Click(object sender, EventArgs e)
        {
            FrmAreaSelect frmAreaSelect = new FrmAreaSelect(this.buttonEditArea6.Tag as AreaInfo);
            frmAreaSelect.ShowDialog();
            AreaInfo areaInfo = frmAreaSelect.AreaInfo;
            if (!this.buttonEditArea6.Text.Equals(areaInfo.AreaName))
            {
                this.buttonEditArea6.Text = areaInfo.AreaName;
            }
        }

        private void InsertAreaCountTable(string areaFieldName, string devsId)
        {
            SqlParameter[] param = null;
            string sql = "";
            string rolesId = "";
            if (0 != comboBoxCardType.SelectedIndex)
            {
                rolesId = String.Format(" and F.Base_RoleID={0}", (comboBoxCardType.SelectedItem as RoleInfo).Value);
            }
            string whereSQL = String.Format(" AND F.Base_GroupID IN({0})", mGroupsId);

            sql = "insert into IO_AreaCount(M_PerID," + areaFieldName + ")" +
                        " select E.Base_PerID,1 from" +
                        " (select top 500000 a.* from AcvB_AccessLog a where ISNULL(Base_PerID,'')<>''" +
                        "  and a.Device_ID in(" + devsId + ")" +
                        " and a.Access_DateTime=(select MAX(Access_DateTime) from AcvB_AccessLog" +
                        " where Base_PerID=a.Base_PerID and isnull(Reserved,'')<>'1' ) order by Base_PerID) E," +
                        " General_Personnel F,General_Role G,General_Group H" +
                        " where E.Base_PerID=F.Base_PerID and F.Base_RoleID=G.Base_RoleID" +
                        " and F.Base_GroupID=H.Base_GroupID and E.InOutFlag='0'and E.Card_Status='1'" +
                        whereSQL + rolesId;

            SqlHelper.ExecuteSql(sql, param);
        }

        private void InsertAreaCountTable2(string areaFieldName, string devsId)
        {
            SqlParameter[] param = null;
            string sql = "";
            string rolesId = "";
            if (0 != comboBoxCardType.SelectedIndex)
            {
                rolesId = String.Format(" and F.Base_RoleID={0}", (comboBoxCardType.SelectedItem as RoleInfo).Value);
            }
            string whereSQL = String.Format(" and F.Base_GroupID IN({0})", mGroupsId);

            cleanAreaCountTempTable();

            sql = "insert into IO_AreaCountTemp(M_PerID,M_Area)" +
                        " select E.Base_PerID,1 from" +
                        " (select top 500000 a.* from AcvB_AccessLog a where ISNULL(Base_PerID,'')<>''" +
                        "  and a.Device_ID in(" + devsId + ")" +
                        " and a.Access_DateTime=(select MAX(Access_DateTime) from AcvB_AccessLog" +
                        " where Base_PerID=a.Base_PerID and isnull(Reserved,'')<>'1' ) order by Base_PerID) E," +
                        " General_Personnel F,General_Role G,General_Group H" +
                        " where E.Base_PerID=F.Base_PerID and F.Base_RoleID=G.Base_RoleID" +
                        " and F.Base_GroupID=H.Base_GroupID and E.InOutFlag='0'and E.Card_Status='1'" +
                        whereSQL + rolesId;

            SqlHelper.ExecuteSql(sql, param);

            sql = "insert into IO_AreaCount(M_PerID," + areaFieldName + ")" +
                " select * from IO_AreaCountTemp A where A.M_PerID not in (select M_PerID from IO_AreaCount)";
            SqlHelper.ExecuteSql(sql, param);

            sql = String.Format("update A set A.{0}=B.M_Area from IO_AreaCount A, IO_AreaCountTemp B where A.M_PerID=B.M_PerID", areaFieldName);
            SqlHelper.ExecuteSql(sql, param);
        }

        private void cleanAreaCountTable()
        {
            string sql = "delete from IO_AreaCount ";

            SqlParameter[] param = null;
            SqlHelper.ExecuteSql(sql, param);
        }

        private void cleanAreaCountTempTable()
        {
            string sql = "delete from IO_AreaCountTemp ";

            SqlParameter[] param = null;
            SqlHelper.ExecuteSql(sql, param);
        }

        private bool CheckSelectArea()
        {
            string devsId = "";

            cleanAreaCountTable();

            if (checkBox1.Checked)
            {
                (buttonEditArea1.Tag as AreaInfo).Used = 1;
                if (buttonEditArea1.Text.Length > 0)
                {
                    (buttonEditArea1.Tag as AreaInfo).Title = textBoxArea1.Text;
                    devsId = convertToSqlStr((buttonEditArea1.Tag as AreaInfo).AreaDevs);
                    InsertAreaCountTable("M_Area1", devsId);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                (buttonEditArea1.Tag as AreaInfo).Used = 0;
            }
            if (checkBox2.Checked)
            {
                (buttonEditArea2.Tag as AreaInfo).Used = 1;
                if (buttonEditArea2.Text.Length > 0)
                {
                    (buttonEditArea2.Tag as AreaInfo).Title = textBoxArea2.Text;
                    devsId = convertToSqlStr((buttonEditArea2.Tag as AreaInfo).AreaDevs);
                    InsertAreaCountTable2("M_Area2", devsId);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                (buttonEditArea2.Tag as AreaInfo).Used = 0;
            }
            if (checkBox3.Checked)
            {
                (buttonEditArea3.Tag as AreaInfo).Used = 1;
                if (buttonEditArea3.Text.Length > 0)
                {
                    (buttonEditArea3.Tag as AreaInfo).Title = textBoxArea3.Text;
                    devsId = convertToSqlStr((buttonEditArea3.Tag as AreaInfo).AreaDevs);
                    InsertAreaCountTable2("M_Area3", devsId);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                (buttonEditArea3.Tag as AreaInfo).Used = 0;
            }
            if (checkBox4.Checked)
            {
                (buttonEditArea4.Tag as AreaInfo).Used = 1;
                if (buttonEditArea4.Text.Length > 0)
                {
                    (buttonEditArea4.Tag as AreaInfo).Title = textBoxArea4.Text;
                    devsId = convertToSqlStr((buttonEditArea4.Tag as AreaInfo).AreaDevs);
                    InsertAreaCountTable2("M_Area4", devsId);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                (buttonEditArea4.Tag as AreaInfo).Used = 0;
            }
            if (checkBox5.Checked)
            {
                (buttonEditArea5.Tag as AreaInfo).Used = 1;
                if (buttonEditArea5.Text.Length > 0)
                {
                    (buttonEditArea5.Tag as AreaInfo).Title = textBoxArea5.Text;
                    devsId = convertToSqlStr((buttonEditArea5.Tag as AreaInfo).AreaDevs);
                    InsertAreaCountTable2("M_Area5", devsId);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                (buttonEditArea5.Tag as AreaInfo).Used = 0;
            }
            if (checkBox6.Checked)
            {
                (buttonEditArea6.Tag as AreaInfo).Used = 1;
                if (buttonEditArea6.Text.Length > 0)
                {
                    (buttonEditArea6.Tag as AreaInfo).Title = textBoxArea6.Text;
                    devsId = convertToSqlStr((buttonEditArea6.Tag as AreaInfo).AreaDevs);
                    InsertAreaCountTable2("M_Area6", devsId);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                (buttonEditArea6.Tag as AreaInfo).Used = 0;
            }
            return true;
        }

        private string convertToSqlStr(string devList)
        {
            string word = "";
            string[] split = devList.Split(new Char[] { ',' });
            foreach(string dev in split)
            {
                if(word.Length > 0)
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

        private void queryAreaAndPerview()
        {
            string sql = "select E.M_PerID,E.M_Area1,E.M_Area2,E.M_Area3,E.M_Area4,E.M_Area5,E.M_Area6,(isnull(E.M_Area1,0)+isnull(E.M_Area2,0)+isnull(E.M_Area3,0)+isnull(E.M_Area4,0)+isnull(E.M_Area5,0)+isnull(E.M_Area6,0)) as AreaCount,F.Base_RoleID,G.Base_RoleName,F.Base_PerNo," +
                " F.Base_PerName,H.Base_GroupName from IO_AreaCount E,General_Personnel F,General_Role G,General_Group H" +
                " where E.M_PerID=F.Base_PerID and F.Base_RoleID=G.Base_RoleID and" +
                " F.Base_GroupID=H.Base_GroupID  order by F.Base_RoleID,F.Base_GroupID";

            SqlParameter[] param = null;
            DataTable dataTable = null;
            dataTable = SqlHelper.ExecuteDataTable(sql, param);
            perAreaList.Clear();
            foreach (DataRow dt in dataTable.Rows)
            {
                PerInAreaInfo areaInfo = new PerInAreaInfo();
                areaInfo.CardType = dt["Base_RoleName"].ToString();
                areaInfo.GroupName = dt["Base_GroupName"].ToString();
                areaInfo.PersonName = dt["Base_PerName"].ToString();
                areaInfo.InNum = Convert.ToInt32(dt["AreaCount"].ToString());
                string test = dt["M_Area1"].ToString();
                if (test.Length > 0)
                {
                    areaInfo.InNum1 = Convert.ToInt32(dt["M_Area1"].ToString());
                }
                test = dt["M_Area2"].ToString();
                if (test.Length > 0)
                {
                    areaInfo.InNum2 = Convert.ToInt32(dt["M_Area2"].ToString());
                }
                test = dt["M_Area3"].ToString();
                if (test.Length > 0)
                {
                    areaInfo.InNum3 = Convert.ToInt32(dt["M_Area3"].ToString());
                }
                test = dt["M_Area4"].ToString();
                if (test.Length > 0)
                {
                    areaInfo.InNum4 = Convert.ToInt32(dt["M_Area4"].ToString());
                }
                test = dt["M_Area5"].ToString();
                if (test.Length > 0)
                {
                    areaInfo.InNum5 = Convert.ToInt32(dt["M_Area5"].ToString());
                }
                test = dt["M_Area6"].ToString();
                if (test.Length > 0)
                {
                    areaInfo.InNum6 = Convert.ToInt32(dt["M_Area6"].ToString());
                }
                perAreaList.Add(areaInfo);
            }
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

        private void treeViewGroup_MouseUp(object sender, MouseEventArgs e)
        {
            mGroupsId = "";
            foreach (TreeNode newNode in this.treeViewGroup.Nodes)
            {
                WalkCheckNode(newNode);
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SqlParameter[] param = null;

            AreaInfo areaInfo = this.buttonEditArea1.Tag as AreaInfo;
            string sql = String.Format("update IO_AreaName2 set M_Name='{0}', M_Devs='{1}', M_Title='{2}', M_Used={3} where M_AreaId = {4}",
                areaInfo.AreaName, areaInfo.AreaDevs, this.textBoxArea1.Text, Convert.ToInt32(this.checkBox1.Checked), areaInfo.AreaId);

            areaInfo = this.buttonEditArea2.Tag as AreaInfo;
            sql += String.Format(" update IO_AreaName2 set M_Name='{0}', M_Devs='{1}', M_Title='{2}', M_Used={3} where M_AreaId = {4}",
                areaInfo.AreaName, areaInfo.AreaDevs, this.textBoxArea2.Text, Convert.ToInt32(this.checkBox2.Checked), areaInfo.AreaId);

            areaInfo = this.buttonEditArea3.Tag as AreaInfo;
            sql += String.Format(" update IO_AreaName2 set M_Name='{0}', M_Devs='{1}', M_Title='{2}', M_Used={3} where M_AreaId = {4}",
                areaInfo.AreaName, areaInfo.AreaDevs, this.textBoxArea3.Text, Convert.ToInt32(this.checkBox3.Checked), areaInfo.AreaId);

            areaInfo = this.buttonEditArea4.Tag as AreaInfo;
            sql += String.Format(" update IO_AreaName2 set M_Name='{0}', M_Devs='{1}', M_Title='{2}', M_Used={3} where M_AreaId = {4}",
                areaInfo.AreaName, areaInfo.AreaDevs, this.textBoxArea4.Text, Convert.ToInt32(this.checkBox4.Checked), areaInfo.AreaId);

            areaInfo = this.buttonEditArea5.Tag as AreaInfo;
            sql += String.Format(" update IO_AreaName2 set M_Name='{0}', M_Devs='{1}', M_Title='{2}', M_Used={3} where M_AreaId = {4}",
                areaInfo.AreaName, areaInfo.AreaDevs, this.textBoxArea5.Text, Convert.ToInt32(this.checkBox5.Checked), areaInfo.AreaId);

            areaInfo = this.buttonEditArea6.Tag as AreaInfo;
            sql += String.Format(" update IO_AreaName2 set M_Name='{0}', M_Devs='{1}', M_Title='{2}', M_Used={3} where M_AreaId = {4}",
                areaInfo.AreaName, areaInfo.AreaDevs, this.textBoxArea6.Text, Convert.ToInt32(this.checkBox6.Checked), areaInfo.AreaId);

            SqlHelper.ExecuteSql(sql, param);

            MessageBox.Show("保存成功", "提示");
        }

        private void toolStripButtonQuery_Click(object sender, EventArgs e)
        {
            if (mGroupsId.Length > 0)
            {
                if (CheckSelectArea())
                {
                    queryAreaAndPerview();
                    List<AreaInfo> areaInfoList = new List<AreaInfo>();
                    areaInfoList.Add(buttonEditArea1.Tag as AreaInfo);
                    areaInfoList.Add(buttonEditArea2.Tag as AreaInfo);
                    areaInfoList.Add(buttonEditArea3.Tag as AreaInfo);
                    areaInfoList.Add(buttonEditArea4.Tag as AreaInfo);
                    areaInfoList.Add(buttonEditArea5.Tag as AreaInfo);
                    areaInfoList.Add(buttonEditArea6.Tag as AreaInfo);

                    XtraReportArea reportArea = new XtraReportArea(areaInfoList, perAreaList);
                    ReportPrintTool printTool = new ReportPrintTool(reportArea);
                    //printTool.ShowRibbonPreview();
                    //printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
                    //printTool.ShowPreview();
                    printTool.ShowPreviewDialog(UserLookAndFeel.Default);
                }
                else
                {
                    MessageBox.Show("请选择区域设备.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
