using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AreaCount
{
    public partial class FrmAreaSelect : Form
    {
        private AreaInfo areaInfo;

        public AreaInfo AreaInfo { get => areaInfo; set => areaInfo = value; }

        public FrmAreaSelect(AreaInfo info)
        {
            this.AreaInfo = info;
            InitializeComponent();
            LoadTreeViewData();
            InitializeListView();
        }

        private void LoadTreeViewData()
        {
            string sql = "select len(Group_No) as LenNO, * from AcvB_Group order by LenNO, Group_Name";

            SqlParameter[] param = null;
            DataTable dataTable = null;
            TreeNode treeNode = null;
            TreeNode tempNode = null;

            GroupInfo groupRoot = new GroupInfo();
            groupRoot.GroupName = "全部";
            groupRoot.GroupId = "";
            groupRoot.AuthId = "";
            treeNode = this.treeViewGroup.Nodes.Add(groupRoot.GroupName);
            treeNode.Tag = groupRoot;
            string strLastParent = groupRoot.GroupId;

            dataTable = SqlHelper.ExecuteDataTable(sql, param);
            foreach (DataRow dt in dataTable.Rows)
            {
                GroupInfo groupInfo = new GroupInfo();
                groupInfo.GroupId = dt["Group_No"].ToString();
                groupInfo.GroupName = dt["Group_Name"].ToString();
                string paraentKey = groupInfo.GroupId.Substring(0, groupInfo.GroupId.Length - 2);

                groupInfo.AuthId = paraentKey;

                if (!groupInfo.AuthId.Equals(strLastParent))
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
                strLastParent = (treeNode.Tag as GroupInfo).GroupId;
            }

            this.treeViewGroup.ExpandAll();
        }

        private TreeNode CheckTreeViewList(TreeNode nodes, GroupInfo groupInfo)
        {
            TreeNode targetNode = null;
            if (nodes.Tag != null)
            {
                if (groupInfo.AuthId.Equals((nodes.Tag as GroupInfo).GroupId))
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

        private void InitializeListView()
        {
            string[] devList = AreaInfo.AreaDevs.Split(',');

            SqlParameter[] paras = null;
            DataTable dataTable = SqlHelper.ExecuteDataTable("select Device_ID as Did, Device_Name as Name, Device_Location as Location from AcvB_Device where Device_Status <> '1' " +
                "and Board_ID not in (select Board_ID from AcvB_DevForbidden where Base_OperCode = 'SYSTEM') Order by Device_Name", paras);
            foreach (DataRow dt in dataTable.Rows)
            {
                bool isCheck = false;
                foreach (string dev in devList)
                {
                    if (dt["Did"].ToString().Equals(dev))
                    {
                        isCheck = true;
                    }
                }
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = dt["Did"].ToString();
                lvi.SubItems.Add(dt["Name"].ToString());
                lvi.SubItems.Add(dt["Location"].ToString());
                lvi.Checked = isCheck;
                this.listViewDevice.Items.Add(lvi);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string devsGroup = "";
            string areaNameGroup = "";
            foreach (ListViewItem item in this.listViewDevice.Items)
            {
                if (item.Checked)
                {
                    if (devsGroup.Length == 0)
                    {
                        devsGroup = item.Tag as string;
                        areaNameGroup = item.SubItems[1].Text;
                    }
                    else
                    {
                        devsGroup += "," + item.Tag as string;
                        areaNameGroup += "," + item.SubItems[1].Text;
                    }
                }
            }
            AreaInfo.AreaDevs = devsGroup;
            AreaInfo.AreaName = areaNameGroup;

            this.Close();
        }
    }
}
