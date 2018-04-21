using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using GMM.helpers;
using DevExpress.BarCodes;
using DevExpress.XtraReports.UI;
using GMM.reports;

namespace GMM.forms
{
    public partial class MemberDetails : RibbonForm
    {
        private readonly int _memberId;
        public static readonly string Saveloaction = AppDomain.CurrentDomain.BaseDirectory + @"GMMpic";

        public MemberDetails(int memberid = -1)
        {
            _memberId = memberid;
            InitializeComponent();
        }

        private void SaveChanges()
        {
            try
            {
                string photoname = $@"\{DateTime.Now.Ticks}.jpg";
                if (!Directory.Exists(Saveloaction))
                {
                    Directory.CreateDirectory(Saveloaction);
                }
                if (pictureEdit1.Image != null)
                {
                    pictureEdit1.Image.Save(Saveloaction + photoname, ImageFormat.Jpeg);
                    pictureTextEdit.Text = photoname;
                }
                Validate();
                membersBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dataDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MemberDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.memberships' table. You can move, or remove it, as needed.
            this.membershipsTableAdapter.Fill(this.dataDataSet.memberships);
            // TODO: This line of code loads data into the 'dataDataSet.memberships' table. You can move, or remove it, as needed.
            this.membershipsTableAdapter.Fill(this.dataDataSet.memberships);
            if (_memberId == -1)
            {
                membersBindingSource.AddNew();
                
            }
            else
            {
                // TODO: This line of code loads data into the 'dataDataSet.members' table. You can move, or remove it, as needed.
                membersTableAdapter.Fill(dataDataSet.members);
                membersBindingSource.Position = membersBindingSource.Find("ID", _memberId);
                if (File.Exists(Saveloaction + pictureTextEdit.Text))
                {
                    pictureEdit1.Image = Image.FromFile(Saveloaction + pictureTextEdit.Text);
                }
            }
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void bbiSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveChanges();
            Close();
        }

        private void bbiSaveAndNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveChanges();
            membersBindingSource.AddNew();
        }

        private void bbiReset_ItemClick(object sender, ItemClickEventArgs e)
        {
            membersBindingSource.ResetCurrentItem();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            membersBindingSource.RemoveCurrent();
            SaveChanges();
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void EditPhotoButton_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.Image == null)
                return;
            Crop crop = new Crop();
            crop.pictureEdit1.Image = pictureEdit1.Image;
            var result = crop.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureEdit1.Image = crop.pictureEdit1.Image;
                pictureEdit1.Refresh();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveChanges();
            MembershipDetails membershipDetails = new MembershipDetails(_memberId)
            {
                MdiParent = this.MdiParent
            };
            membershipDetails.Show();
        }

     
        private void layoutControlItem5_CustomDraw(object sender, DevExpress.XtraLayout.ItemCustomDrawEventArgs e)
        {
            if (_memberId == -1 &&  barecodeTextEdit.Text == "")
            {
                barecodeTextEdit.Text = UniqueId.Get();
            }

            BarCode barCode = new BarCode();
            barCode.Symbology = Symbology.Code93;
            barCode.CodeText = barecodeTextEdit.Text;
            barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
            barecodeTextEdit.Text = barCode.CodeText;pictureEdit2.Image = barCode.BarCodeImage;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraReport1 report1 = new XtraReport1();
            report1.Parameters["IDP"].Value = _memberId;
            report1.Parameters["IDP"].Visible = false;
            report1.ShowPreview();
        }
    }}