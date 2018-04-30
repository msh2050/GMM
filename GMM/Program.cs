using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Drawing;
using System.Reflection;
using System.Security.Principal;
using DevExpress.XtraBars.Controls;
using GMM.helpers;

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

            if (!IsRunAsAdministrator())
            {
                // It is not possible to launch a ClickOnce app as administrator directly, so instead we launch the
                // app as administrator in a new process.
                var processInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().CodeBase);

                // The following properties run the new process as administrator
                processInfo.UseShellExecute = true;
                processInfo.Verb = "runas";

                // Start the new process
                try
                {
                    Process.Start(processInfo);
                }
                catch (Exception)
                {
                    // The user did not allow the application to run as administrator
                    MessageBox.Show(@"Sorry, this application must be run as Administrator.");
                }

                // Shut down the current process
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                BonusSkins.Register();
                SkinManager.EnableFormSkins();
                UserLookAndFeel.Default.SetSkinStyle(("DevExpress Style"));
                Animator.AllowFadeAnimation = false;
                SkinManager.DisableFormSkins();
                SkinManager.DisableMdiFormSkins();
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new Font("Courier New", 12);
                BarecodeScan.Subscribe();
                Application.Run(new MainForm());

            }

            
        }

        private static bool IsRunAsAdministrator()
        {
            var wi = WindowsIdentity.GetCurrent();
            var wp = new WindowsPrincipal(wi);
            return true;
            //return wp.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
