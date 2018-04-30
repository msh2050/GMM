using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using GMM.dataDataSetTableAdapters;

namespace GMM.helpers
{
    internal static class BarecodeScan
    {
        private static IKeyboardMouseEvents _mGlobalHook;
        static DateTime _lastKeystroke = new DateTime(0);
        static readonly List<char> Barcodechar = new List<char>(10);
        public static void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            _mGlobalHook = Hook.AppEvents();

            _mGlobalHook.KeyDown += GlobalHookKeyPress;
        }

        private static void GlobalHookKeyPress(object sender, KeyEventArgs e)
        {
            var membersTableAdapter1 = new membersTableAdapter();
           
                // check timing (keystrokes within 100 ms)
                var elapsed = (DateTime.Now - _lastKeystroke);
                if (elapsed.TotalMilliseconds > 120)
                    Barcodechar.Clear();

                // record keystroke & timestamp
                Barcodechar.Add((char)e.KeyValue);
                _lastKeystroke = DateTime.Now;
                
                // process barcode
            if (e.KeyValue != 13 || Barcodechar.Count <= 7) return;

            e.Handled = true; e.SuppressKeyPress = true;
            string barcode = new String(Barcodechar.ToArray());
            int cusid = (int)(membersTableAdapter1.ScalarQuery(barcode.TrimEnd('\r')) ?? -1);
            if (cusid == -1) return;
            var checkin = new Checkin(cusid);
            checkin.Show();

        }

    }
}
