using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using GMM.dataDataSetTableAdapters;
using GMM.forms;
using GMM.helpers;
using GMM.reports;

namespace GMM
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(10);
        public MainForm()
        {
            InitializeComponent();
        }

        private void NavBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MembersList membersList = new MembersList();
            membersList.MdiParent = this;
            membersList.Show();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MemberDetails memberDetails = new MemberDetails();
            memberDetails.MdiParent = this;
            memberDetails.Show();

        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MembershipDetails membership = new MembershipDetails();
            membership.MdiParent = this;
            membership.Show();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
                _barcode.Clear();

            // record keystroke & timestamp
            _barcode.Add(e.KeyChar);
            _lastKeystroke = DateTime.Now;

            // process barcode
            if (e.KeyChar == 13 && _barcode.Count > 7)
            {
                string barcode = new String(this._barcode.ToArray());
                
                int  cusid = (int)(membersTableAdapter1.ScalarQuery(barcode.TrimEnd('\r') ) ?? -1);
                if (cusid == -1) return;
                var checkin = new Checkin(cusid);
                checkin.Show();
            }
            }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var checkreport = new checkreport();
            checkreport.ShowRibbonPreview();}
    }
}
