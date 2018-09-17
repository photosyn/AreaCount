using System;
using System.Linq;
using System.Windows.Forms;

namespace AreaCount
{
    public partial class FrmDBSet : Form
    {
        public FrmDBSet()
        {
            InitializeComponent();
            LoadDbInfo();
        }

        private void LoadDbInfo()
        {
            string iniFileName = System.AppDomain.CurrentDomain.BaseDirectory + "SysData.ini";
            this.textBoxDbName.Text = IniFileOp.ReadIniData("SYSCONFIG", "SQLDataBase", "", iniFileName);
            this.textBoxDbServer.Text = IniFileOp.ReadIniData("SYSCONFIG", "SQLServer", "", iniFileName);
            this.textBoxDbUser.Text = IniFileOp.ReadIniData("SYSCONFIG", "SQLSysUser", "", iniFileName);
            this.textBoxDbPwd.Text = IniFileOp.ReadIniData("SYSCONFIG", "SQLSysPassword", "", iniFileName);
        }

        private void buttonDbTest_Click(object sender, EventArgs e)
        {
            if (SqlHelper.Connect(this.textBoxDbName.Text, this.textBoxDbServer.Text, this.textBoxDbUser.Text, this.textBoxDbPwd.Text))
            {
                MessageBox.Show("测试连接成功.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("测试连接失败.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDbOk_Click(object sender, EventArgs e)
        {
            string iniFileName = System.AppDomain.CurrentDomain.BaseDirectory + "SysData.ini";
            if (this.textBoxDbServer.Text.Length > 0 && this.textBoxDbName.Text.Length > 0 && this.textBoxDbUser.Text.Length > 0)
            {
                if (SqlHelper.Connect(this.textBoxDbName.Text, this.textBoxDbServer.Text, this.textBoxDbUser.Text, this.textBoxDbPwd.Text))
                {
                    IniFileOp.WriteIniData("SYSCONFIG", "SQLServer", this.textBoxDbServer.Text, iniFileName);
                    IniFileOp.WriteIniData("SYSCONFIG", "SQLDataBase", this.textBoxDbName.Text, iniFileName);
                    IniFileOp.WriteIniData("SYSCONFIG", "SQLSysUser", this.textBoxDbUser.Text, iniFileName);
                    IniFileOp.WriteIniData("SYSCONFIG", "SQLSysPassword", this.textBoxDbPwd.Text, iniFileName);
                    MessageBox.Show("保存成功.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("数据库连接失败.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("输入的信息不能为空,请重新输入!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
