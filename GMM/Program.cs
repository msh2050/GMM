using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Drawing;
using DevExpress.XtraBars.Controls;

namespace GMM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle(("DevExpress Style"));
            Animator.AllowFadeAnimation = false;
            SkinManager.DisableFormSkins();
            SkinManager.DisableMdiFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new Font("Courier New", 12);Application.Run(new MainForm());
        }
    }
}
