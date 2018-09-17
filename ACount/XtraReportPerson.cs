using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace AreaCount
{
    public partial class XtraReportPerson : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportPerson(string title)
        {
            InitializeComponent();
            xrLabel1.Text = title;
        }

    }
}
