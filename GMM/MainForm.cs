using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using Gma.System.MouseKeyHook;
using GMM.dataDataSetTableAdapters;
using GMM.forms;
using GMM.helpers;
using GMM.reports;

namespace GMM
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        //DateTime _lastKeystroke = new DateTime(0);
        //List<char> _barcode = new List<char>(10);

        public MainForm()
        {
            InitializeComponent();
            var mGlobalHook = Hook.AppEvents();
            //mGlobalHook.KeyDown += GlobalHookKeyPress;
        }

        //private void GlobalHookKeyPress(object sender, KeyEventArgs e)
        //{
        //    CheckifItIsBacecode(e);

        //}

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



        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var checkreport = new checkreport();
            checkreport.ShowRibbonPreview();

        }

        //public void CheckifItIsBacecode(KeyEventArgs e)
        //{
        //    // check timing (keystrokes within 100 ms)
        //    TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
        //    if (elapsed.TotalMilliseconds > 120)
        //        _barcode.Clear();

        //    // record keystroke & timestamp
        //    _barcode.Add((char)e.KeyValue);
        //    _lastKeystroke = DateTime.Now;
            
            
        //    // process barcode
        //    if (e.KeyValue == 13 && _barcode.Count > 7)
        //    {
        //        e.SuppressKeyPress = true;
        //        string barcode = new String(this._barcode.ToArray());
        //        int cusid = (int) (membersTableAdapter1.ScalarQuery(barcode.TrimEnd('\r')) ?? -1);
        //        if (cusid == -1) return;
        //        var checkin = new Checkin(cusid);
        //        checkin.Show();
        //    }
        //}

        private void الاشتراكات_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var notrenewed = new notrenewed();
            notrenewed.ShowRibbonPreview();

        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            NewMembersList newMembersList = new NewMembersList();
            newMembersList.MdiParent = this;
            newMembersList.Show();
        }

        private void navBarItem6_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthnotrenewed _monthnotrenewed = new monthnotrenewed();
            _monthnotrenewed.ShowRibbonPreview();

        }
    }
}
