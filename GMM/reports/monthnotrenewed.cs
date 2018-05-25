using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraReports.UI;
using GMM.forms;

namespace GMM.reports
{
    public partial class monthnotrenewed : DevExpress.XtraReports.UI.XtraReport
    {
        public monthnotrenewed()
        {
            InitializeComponent();
        }

        private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrPictureBox1.ImageUrl = "";if (String.IsNullOrEmpty(GetCurrentColumnValue("Picture").ToString())) return;
            string imjurlstrin = MemberDetails.Saveloaction + Convert.ToString(GetCurrentColumnValue("Picture"));

            if (File.Exists(imjurlstrin))
            {
                xrPictureBox1.ImageUrl = imjurlstrin;
            }

        }
    }
}
