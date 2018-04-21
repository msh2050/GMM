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
        public MembershipDetails(int memberid = -1)
        {
            _memberId = memberid;
            InitializeComponent();
            
        }
        private void membershipsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membershipsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void MembershipDetails_Load(object sender, EventArgs e)
        {
            if (_memberId == -1)
            {
                // TODO: This line of code loads data into the 'dataDataSet.members' table. You can move, or remove it, as needed.
                this.membersTableAdapter.Fill(this.dataDataSet.members);
            // TODO: This line of code loads data into the 'dataDataSet.memberships' table. You can move, or remove it, as needed.
            this.membershipsTableAdapter.Fill(this.dataDataSet.memberships);
                membershipsBindingSource.AddNew();

             
            }
            else
            {
                this.membersTableAdapter.Fill(this.dataDataSet.members);
                membershipsBindingSource.AddNew();
                
            }
           
        }
        
        private void mambershipDaysSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (mambershipDaysSpinEdit.EditValue != null && membershipStartDateDateEdit.EditValue != null)
            {DateTime ST = membershipStartDateDateEdit.DateTime;
                membershipEndDateDateEdit.DateTime = ST.AddDays((int)mambershipDaysSpinEdit.Value); 
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

        private void layoutControlItem2_CustomDraw(object sender, ItemCustomDrawEventArgs e)
        {
            if (_memberId != -1)
            {
                nameSpinEdit.EditValue = _memberId;
                nameSpinEdit.ReadOnly = true;
                
            }
            DateTime ST = membershipStartDateDateEdit.DateTime;
            membershipEndDateDateEdit.DateTime = ST.AddDays((int)mambershipDaysSpinEdit.Value);}

        private void layoutControlItem4_CustomDraw(object sender, ItemCustomDrawEventArgs e)
        {
            membershipStartDateDateEdit.DateTime = DateTime.Today;
        }

        private void layoutControlItem6_CustomDraw(object sender, ItemCustomDrawEventArgs e)
        {
            mambershipDaysSpinEdit.Value = 30;
            
        }
    }
    
}
