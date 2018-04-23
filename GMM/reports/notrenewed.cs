using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using DevExpress.XtraReports.UI;
using GMM.forms;

namespace GMM.reports
{
    public partial class notrenewed : DevExpress.XtraReports.UI.XtraReport
    {
        public notrenewed()
        {
            InitializeComponent();
        }

        private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string imjurlstrin = MemberDetails.Saveloaction + Convert.ToString(GetCurrentColumnValue("Picture"));

            if (File.Exists(imjurlstrin))
            {
                xrPictureBox1.ImageUrl = imjurlstrin;
            }}
    }
}
