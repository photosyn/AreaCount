using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AreaCount
{

    public partial class FrmMain : Form
    {
        // <summary>
        /// 程序目录（无需斜杠）
        /// </summary>
        public static string ApplicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private Button m_Button;

        public FrmMain()
        {
            UpdateAreaCount();
            InitializeComponent();
            //Image img1 = Image.FromFile(ApplicationDirectory + "1.png");
            //Image img2 = Image.FromFile(ApplicationDirectory + "2.png");
            //Image img3 = Image.FromFile(ApplicationDirectory + "3.png");
            //Image img4 = Image.FromFile(ApplicationDirectory + "4.png");
            //Image img5 = Image.FromFile(ApplicationDirectory + "5.png");
            //Image img6 = Image.FromFile(ApplicationDirectory + "6.png");

            //Image[] images = new Image[] { img1, img2, img3, img4, img5, img6 };
            //LinkedList<TileItem> tileItemList = new LinkedList<TileItem>();
            //LinkedList<TileItem> tileItemList2 = new LinkedList<TileItem>();
            //LinkedList<TileItem> tileItemList3 = new LinkedList<TileItem>();
            //tileItemList.AddLast(new TileItem()
            //{
            //    Image = images[0]
            //});
            //tileItemList.AddLast(new TileItem()
            //{
            //    Image = images[1]
            //});
            //tileItemList2.AddLast(new TileItem()
            //{
            //    Image = images[2]
            //});
            //tileItemList2.AddLast(new TileItem()
            //{
            //    Image = images[3]
            //});
            //tileItemList3.AddLast(new TileItem()
            //{
            //    Image = images[4]
            //});
            //tileItemList3.AddLast(new TileItem()
            //{
            //    Image = images[5]
            //});
            /*Random random = new Random();
            for (int i = 0; i < images.Length; i++)
            {
                tileItemList.AddLast(new TileItem()
                {
                    Image = images[random.Next(1, 4)]
                });
            }*/
            ////申明磁贴
            //Tile tile = new Tile(btnArea, tileItemList);
            ////设置图片切换间隔时间
            //tile.Interval = 2000;
            ////申明磁贴
            //Tile tile2 = new Tile(btnDuty, tileItemList2);
            ////设置图片切换间隔时间
            //tile2.Interval = 2000;
            ////申明磁贴
            //Tile tile3 = new Tile(btnPerson, tileItemList3);
            ////设置图片切换间隔时间
            //tile3.Interval = 2000;
        }

        private void UpdateAreaCount()
        {
            //string sql = "IF NOT EXISTS (SELECT* FROM sysobjects WHERE Name = 'AcvB_AsyMonitorInfo') " +
            //    "CREATE TABLE AcvB_AsyMonitorInfo([Screen_ID] [int] IDENTITY(1,1) NOT NULL,[Monitor_Roles] [varchar](200) NULL,[Monitor_Devs] [varchar](200) NULL)" +
            //    "INSERT INTO AcvB_AsyMonitorInfo(Monitor_Roles,Monitor_Devs) VALUES ('', ''),('', '')";
            string sql = "SELECT * FROM sysobjects WHERE Name = 'IO_AreaName2'";
            SqlParameter[] paras = null;

            DataTable dataTable = null;
            dataTable = SqlHelper.ExecuteDataTable(sql, paras);
            if (dataTable.Rows.Count <= 0)
            {

                dataTable = SqlHelper.ExecuteDataTable("select * from IO_AreaName order by M_AreaID", paras);

                if (dataTable.Rows.Count >= 2)
                {
                    paras = new SqlParameter[4];
                    paras[0] = new SqlParameter("@Name1", dataTable.Rows[0]["M_Name"].ToString());
                    paras[1] = new SqlParameter("@Devs1", dataTable.Rows[0]["M_Devs"].ToString());
                    paras[2] = new SqlParameter("@Name2", dataTable.Rows[1]["M_Name"].ToString());
                    paras[3] = new SqlParameter("@Devs2", dataTable.Rows[1]["M_Devs"].ToString());

                    sql = "CREATE TABLE IO_AreaName2([M_AreaId] [int] IDENTITY(1,1) NOT NULL,[M_Name] [varchar](200) NULL,[M_Devs] [varchar](50) NULL,[M_Title] [varchar](20) NULL,[M_Used] [int] NULL)" +
                    "INSERT INTO IO_AreaName2(M_Name,M_Devs,M_Title,M_Used) VALUES (@Name1, @Devs1, '生产区', 1)," +
                    "(@Name2, @Devs2, '办公区', 1),('', '', '无', 0),('', '', '无', 0),('', '', '无', 0),('', '', '无', 0)";
                    SqlHelper.ExecuteSql(sql, paras);
                }
            }

            sql = "SELECT * FROM sysobjects WHERE Name = 'IO_AreaCountTemp'";
            dataTable = SqlHelper.ExecuteDataTable(sql, paras);
            if (dataTable.Rows.Count <= 0)
            {
                sql = "CREATE TABLE IO_AreaCountTemp([M_PerID] [varchar] (20) NOT NULL,[M_Area] [int])";
                SqlHelper.ExecuteSql(sql, paras);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("请确定是否退出程序？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (re == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnDuty_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            if (m_Button != null)
            {
                m_Button.BackColor = System.Drawing.Color.Transparent;
            }
            m_Button = sender as Button;
            m_Button.BackColor = System.Drawing.Color.Gainsboro;
            FrmDuty SetDuty = new FrmDuty();
            SetDuty.TopLevel = false;
            this.pnlMain.Controls.Add(SetDuty);
            SetDuty.Show();
            
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            if (m_Button != null)
            {
                m_Button.BackColor = System.Drawing.Color.Transparent;
            }
            m_Button = sender as Button;
            m_Button.BackColor = System.Drawing.Color.Gainsboro;
            FrmInAreaInfo areaInfo = new FrmInAreaInfo();
            areaInfo.TopLevel = false;
            this.pnlMain.Controls.Add(areaInfo);
            areaInfo.Show();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            if (m_Button != null)
            {
                m_Button.BackColor = System.Drawing.Color.Transparent;
            }
            m_Button = sender as Button;
            m_Button.BackColor = System.Drawing.Color.Gainsboro;
            FrmPerSelect perSelect = new FrmPerSelect();
            perSelect.TopLevel = false;
            this.pnlMain.Controls.Add(perSelect);
            perSelect.Show();
        }

        private void buttonRealTime_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            if (m_Button != null)
            {
                m_Button.BackColor = System.Drawing.Color.Transparent;
            }
            m_Button = sender as Button;
            m_Button.BackColor = System.Drawing.Color.Gainsboro;
            FrmRealTime frmReal = new FrmRealTime();
            frmReal.TopLevel = false;
            this.pnlMain.Controls.Add(frmReal);
            frmReal.Show();
        }

        private void buttonRecordHandle_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            if (m_Button != null)
            {
                m_Button.BackColor = System.Drawing.Color.Transparent;
            }
            m_Button = sender as Button;
            m_Button.BackColor = System.Drawing.Color.Gainsboro;
            FrmRealTime frmReal = new FrmRealTime(true);
            frmReal.TopLevel = false;
            this.pnlMain.Controls.Add(frmReal);
            frmReal.Show();
        }
    }
}
