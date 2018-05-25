using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GMM.dataDataSetTableAdapters;
using GMM.forms;

namespace GMM.helpers
{
    public partial class Checkin : DevExpress.XtraEditors.XtraForm
    {
        private readonly int _memberId;
        private DateTime? _enddate;

        public Checkin(int memberid)
        {
            _memberId = memberid;
            InitializeComponent();
        }

        private void setfocustomainform()
        {
            var form = new MainForm();if (Application.OpenForms[form.Name] == null)
            {
                form.Show();
            }
            else
            {
                Application.OpenForms[form.Name].Activate();
            }
        }

        private void Checkin_Load(object sender, EventArgs e)
        {
            
            //_enddate = membershipsTableAdapter.GetData().FirstOrDefault(x => x.Mname == _memberId)?.MembershipEndDate;

            _enddate = membershipsTableAdapter.GetData().Where(x => x.Mname == _memberId)
                ?.Max(o => o.MembershipEndDate);

            // TODO: This line of code loads data into the 'dataDataSet.members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.FillByID(this.dataDataSet.members , _memberId);

            string piclocation = MemberDetails.Saveloaction + pictureTextEdit.Text;
            if (File.Exists(piclocation))
            {
                pictureEdit1.Image = Image.FromFile(piclocation);
            }

            if (_enddate.HasValue)
            {
                enddatelabel.Text = $@"{_enddate:dd/MM/yyyy}";
                int remainigdates = ((DateTime) _enddate - DateTime.Today).Days;
                if (remainigdates > 0)
                {
                    timer1.Interval = 10000;
                    timer1.Tick += new EventHandler(timer_Tick);
                    timer1.Start();
                    remainingdayslabel.Text = $@"{"باقي "} {remainigdates} {"يوم"}";
                }
                else
                {
                    remainingdayslabel.Text = @"الاشتراك منتهي";
                }

                labelcurrenttime.Text = DateTime.Now.ToString("dd-MM-yy -- h:m:s tt");

                if (memcheckTableAdapter1.GetData().Any(x => x.Mname == _memberId))
                {DateTime? lastentryDateTime =
                        memcheckTableAdapter1.GetData().Where(x => x.Mname == _memberId).Max(b => b.checkintime);
                    lablelastentrytime.Text = $@"{lastentryDateTime:dd-MM-yy -- h:m:s tt}";
                }
                else
                {
                    lablelastentrytime.Text = labelcurrenttime.Text;
                }
                memcheckTableAdapter1.Insertcheck(_memberId, DateTime.Now);
                }
            else
            {
                enddatelabel.Text = @"غير مشترك";
                remainingdayslabel.Text = @"N/A";
            }
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Checkin_Shown(object sender, EventArgs e)
        {
            setfocustomainform();
            
        }
    }
}