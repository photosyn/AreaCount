using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreaCount;

namespace AreaCount
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("zh-Hans");
            //System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
            //System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            //System.Globalization.CultureInfo.DefaultThreadCurrentCulture = culture;
            //System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool ret;
            System.Threading.Mutex mutex;
            mutex = new System.Threading.Mutex(true, "AreaCount", out ret);

            if (!ret)
            {
                MessageBox.Show("已有一个程序实例运行");
                Environment.Exit(0);
            }

            FrmLogIn login = new FrmLogIn();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                login.Dispose();
                Application.Run(new FrmMain());
            }
            else if (login.DialogResult == DialogResult.Cancel)
            {
                login.Dispose();
                return;
            }
        }
    }
}
