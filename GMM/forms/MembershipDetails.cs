using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;

namespace GMM.forms
{
    public partial class MembershipDetails : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly int _memberId;
        private readonly int _memshipId;
        public MembershipDetails(int memberid = -1 , int memshipId = -1)
        {
            _memberId = memberid;
            _memshipId = memshipId;
            InitializeComponent();
            
        }
     

        private void MembershipDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.dataDataSet.members);
            // TODO: This line of code loads data into the 'dataDataSet.memberships' table. You can move, or remove it, as needed.
            this.membershipsTableAdapter.Fill(this.dataDataSet.memberships);
            if (_memshipId == -1)
            {
                membershipsBindingSource.AddNew(); 
            }
            else
            {
                membershipsBindingSource.Position = membershipsBindingSource.Find("ID", _memshipId);
            }


        }
        
        private void mambershipDaysSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (mambershipDaysSpinEdit.EditValue != null && membershipStartDateDateEdit.EditValue != null)
            {DateTime st = membershipStartDateDateEdit.DateTime;
                membershipEndDateDateEdit.DateTime = st.AddDays((int)mambershipDaysSpinEdit.Value); 
            }
        }

        private void membershipStartDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (mambershipDaysSpinEdit.EditValue != null && membershipStartDateDateEdit.EditValue != null)
            {
                DateTime ST = membershipStartDateDateEdit.DateTime;
                membershipEndDateDateEdit.DateTime = ST.AddDays((int)mambershipDaysSpinEdit.Value);
            }
        }

        private void membershipPriceSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (membershipPriceSpinEdit.EditValue != null && amountPaidedSpinEdit.EditValue != null)
            {
                amountRemainingSpinEdit.Value = membershipPriceSpinEdit.Value - amountPaidedSpinEdit.Value;

            }

        }

        private void amountPaidedSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (membershipPriceSpinEdit.EditValue != null && amountPaidedSpinEdit.EditValue != null)
            {
                amountRemainingSpinEdit.Value = membershipPriceSpinEdit.Value - amountPaidedSpinEdit.Value;

            }}

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           SaveChanges();
            
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
            this.Close();}

        private void SaveChanges()
        {
            try
            {
                this.Validate();
                this.membershipsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void MembershipDetails_Shown(object sender, EventArgs e)
        {
            if( _memshipId != -1) return;
            if (_memberId != -1)
            {
                nameSpinEdit.EditValue = _memberId;
                nameSpinEdit.ReadOnly = true;

            }
            

            //var enddate = membershipsTableAdapter.GetData().FirstOrDefault(x => x.Mname == _memberId)?.MembershipEndDate;
            var enddate = membershipsTableAdapter.GetData().Where(x => x.Mname == _memberId)?
                .OrderByDescending(qw => qw.MembershipEndDate).FirstOrDefault();

            if (enddate != null && !enddate.IsMembershipEndDateNull())
            {
                membershipStartDateDateEdit.DateTime = enddate.MembershipEndDate.AddDays(1);
                mambershipDaysSpinEdit.Value = enddate.MambershipDays;
                membershipEndDateDateEdit.DateTime = enddate.MembershipEndDate.AddDays(enddate.MambershipDays + 1);
            }
            else
            {
                var st = DateTime.Today;
                membershipStartDateDateEdit.DateTime = st;
                membershipEndDateDateEdit.DateTime = st.AddDays(30);
                mambershipDaysSpinEdit.Value = 30;
            }



        }
    }
    
}
