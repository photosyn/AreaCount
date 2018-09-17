using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AreaCount
{
    public partial class FrmLoading : Form
    {
        Image m_Image;
        int m_Angle = 0;
        System.Timers.Timer m_Timer;

        public FrmLoading(BackgroundWorker worker)
        {
            InitializeComponent();
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted);
            m_Image = Properties.Resources.Loading;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            m_Timer.Stop();
            m_Timer.Dispose();
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = this.panel1.CreateGraphics();
            graphics.Clear(Color.WhiteSmoke);

            //装入图片
            Image image = m_Image;

            //获取当前窗口的中心点
            Rectangle rect = new Rectangle(0, 0, this.panel1.ClientSize.Width, this.panel1.ClientSize.Height);
            PointF center = new PointF(rect.Width / 2, rect.Height * 3 / 5);

            float offsetX = 0;
            float offsetY = 0;
            offsetX = center.X - image.Width / 2;
            offsetY = center.Y - image.Height / 2;
            //构造图片显示区域:让图片的中心点与窗口的中心点一致
            RectangleF picRect = new RectangleF(offsetX, offsetY, image.Width, image.Height);
            PointF Pcenter = new PointF(picRect.X + picRect.Width / 2,
             picRect.Y + picRect.Height / 2);

            // 绘图平面以图片的中心点旋转
            graphics.TranslateTransform(Pcenter.X, Pcenter.Y);
            graphics.RotateTransform(m_Angle);
            //恢复绘图平面在水平和垂直方向的平移
            graphics.TranslateTransform(-Pcenter.X, -Pcenter.Y);
            //绘制图片并延时
            graphics.DrawImage(image, picRect);
            //重置绘图平面的所有变换
            graphics.ResetTransform();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            m_Timer = new System.Timers.Timer(200);//定时周期2秒
            m_Timer.Elapsed += myTimer_Elapsed;//到2秒了做的事件
            m_Timer.AutoReset = true; //是否不断重复定时器操作
            m_Timer.Start();
        }

        void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            m_Angle = (m_Angle + 30) % 360;
            //this.Invoke(new MethodInvoker(DisplayReceiveMessage));
            this.Invalidate();
        }
    }
}
