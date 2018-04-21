namespace GMM.helpers
{
    partial class Checkin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phonenumberLabel;
            System.Windows.Forms.Label membershipEndDateLabel;
            System.Windows.Forms.Label label1;
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new GMM.dataDataSet();
            this.phonenumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pictureTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.enddatelabel = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.remainingdayslabel = new DevExpress.XtraEditors.LabelControl();
            this.lablelastentrytime = new DevExpress.XtraEditors.LabelControl();
            this.labelcurrenttime = new DevExpress.XtraEditors.LabelControl();
            this.membersTableAdapter = new GMM.dataDataSetTableAdapters.membersTableAdapter();
            this.tableAdapterManager = new GMM.dataDataSetTableAdapters.TableAdapterManager();
            this.membershipsTableAdapter = new GMM.dataDataSetTableAdapters.membershipsTableAdapter();
            this.memcheckTableAdapter1 = new GMM.dataDataSetTableAdapters.memcheckTableAdapter();
            this.membershipsTableAdapter1 = new GMM.dataDataSetTableAdapters.membershipsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            nameLabel = new System.Windows.Forms.Label();
            phonenumberLabel = new System.Windows.Forms.Label();
            membershipEndDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonenumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Enabled = false;
            nameLabel.Location = new System.Drawing.Point(43, 14);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(96, 17);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "اسم المشترك:";
            // 
            // phonenumberLabel
            // 
            phonenumberLabel.AutoSize = true;
            phonenumberLabel.Enabled = false;
            phonenumberLabel.Location = new System.Drawing.Point(65, 42);
            phonenumberLabel.Name = "phonenumberLabel";
            phonenumberLabel.Size = new System.Drawing.Size(74, 17);
            phonenumberLabel.TabIndex = 2;
            phonenumberLabel.Text = "رقم الهاتف:";
            // 
            // membershipEndDateLabel
            // 
            membershipEndDateLabel.AutoSize = true;
            membershipEndDateLabel.Enabled = false;
            membershipEndDateLabel.Location = new System.Drawing.Point(12, 81);
            membershipEndDateLabel.Name = "membershipEndDateLabel";
            membershipEndDateLabel.Size = new System.Drawing.Size(127, 17);
            membershipEndDateLabel.TabIndex = 6;
            membershipEndDateLabel.Text = "تاريخ انتهاء الاشتراك:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new System.Drawing.Point(12, 232);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 17);
            label1.TabIndex = 6;
            label1.Text = "وقت الدخول السابق:";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membersBindingSource, "name", true));
            this.nameTextEdit.Enabled = false;
            this.nameTextEdit.Location = new System.Drawing.Point(145, 11);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(358, 22);
            this.nameTextEdit.TabIndex = 1;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phonenumberTextEdit
            // 
            this.phonenumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membersBindingSource, "phonenumber", true));
            this.phonenumberTextEdit.Enabled = false;
            this.phonenumberTextEdit.Location = new System.Drawing.Point(145, 39);
            this.phonenumberTextEdit.Name = "phonenumberTextEdit";
            this.phonenumberTextEdit.Size = new System.Drawing.Size(358, 22);
            this.phonenumberTextEdit.TabIndex = 3;
            // 
            // pictureTextEdit
            // 
            this.pictureTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membersBindingSource, "Picture", true));
            this.pictureTextEdit.Enabled = false;
            this.pictureTextEdit.Location = new System.Drawing.Point(515, 133);
            this.pictureTextEdit.Name = "pictureTextEdit";
            this.pictureTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureTextEdit.Properties.Appearance.Options.UseFont = true;
            this.pictureTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.pictureTextEdit.Size = new System.Drawing.Size(100, 22);
            this.pictureTextEdit.TabIndex = 5;
            // 
            // enddatelabel
            // 
            this.enddatelabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.enddatelabel.Appearance.Options.UseForeColor = true;
            this.enddatelabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.enddatelabel.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.enddatelabel.LineVisible = true;
            this.enddatelabel.Location = new System.Drawing.Point(189, 68);
            this.enddatelabel.Name = "enddatelabel";
            this.enddatelabel.Size = new System.Drawing.Size(312, 30);
            this.enddatelabel.TabIndex = 9;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.Location = new System.Drawing.Point(514, 5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pictureEdit1.Properties.ReadOnly = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(101, 123);
            this.pictureEdit1.TabIndex = 11;
            // 
            // remainingdayslabel
            // 
            this.remainingdayslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remainingdayslabel.Appearance.FontSizeDelta = 4;
            this.remainingdayslabel.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.remainingdayslabel.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.remainingdayslabel.Appearance.Options.UseFont = true;
            this.remainingdayslabel.Appearance.Options.UseForeColor = true;
            this.remainingdayslabel.Appearance.Options.UseTextOptions = true;
            this.remainingdayslabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.remainingdayslabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.remainingdayslabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.remainingdayslabel.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.remainingdayslabel.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.remainingdayslabel.LineVisible = true;
            this.remainingdayslabel.Location = new System.Drawing.Point(160, 104);
            this.remainingdayslabel.Name = "remainingdayslabel";
            this.remainingdayslabel.Size = new System.Drawing.Size(341, 69);
            this.remainingdayslabel.TabIndex = 12;
            // 
            // lablelastentrytime
            // 
            this.lablelastentrytime.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lablelastentrytime.Appearance.Options.UseForeColor = true;
            this.lablelastentrytime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lablelastentrytime.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lablelastentrytime.LineVisible = true;
            this.lablelastentrytime.Location = new System.Drawing.Point(174, 219);
            this.lablelastentrytime.Name = "lablelastentrytime";
            this.lablelastentrytime.Size = new System.Drawing.Size(312, 30);
            this.lablelastentrytime.TabIndex = 9;
            // 
            // labelcurrenttime
            // 
            this.labelcurrenttime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelcurrenttime.Appearance.FontSizeDelta = -2;
            this.labelcurrenttime.Appearance.Options.UseFont = true;
            this.labelcurrenttime.Appearance.Options.UseTextOptions = true;
            this.labelcurrenttime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelcurrenttime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelcurrenttime.LineVisible = true;
            this.labelcurrenttime.Location = new System.Drawing.Point(408, 179);
            this.labelcurrenttime.Name = "labelcurrenttime";
            this.labelcurrenttime.Size = new System.Drawing.Size(207, 34);
            this.labelcurrenttime.TabIndex = 13;
            this.labelcurrenttime.Text = "cct";
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.membershipsTableAdapter = this.membershipsTableAdapter;
            this.tableAdapterManager.membersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.memcheckTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GMM.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membershipsTableAdapter
            // 
            this.membershipsTableAdapter.ClearBeforeFill = true;
            // 
            // memcheckTableAdapter1
            // 
            this.memcheckTableAdapter1.ClearBeforeFill = true;
            // 
            // membershipsTableAdapter1
            // 
            this.membershipsTableAdapter1.ClearBeforeFill = true;
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 267);
            this.Controls.Add(this.labelcurrenttime);
            this.Controls.Add(this.remainingdayslabel);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lablelastentrytime);
            this.Controls.Add(this.enddatelabel);
            this.Controls.Add(label1);
            this.Controls.Add(membershipEndDateLabel);
            this.Controls.Add(this.pictureTextEdit);
            this.Controls.Add(phonenumberLabel);
            this.Controls.Add(this.phonenumberTextEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Name = "Checkin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "checkin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Checkin_Load);
            this.Shown += new System.EventHandler(this.Checkin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonenumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private dataDataSetTableAdapters.membersTableAdapter membersTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dataDataSetTableAdapters.membershipsTableAdapter membershipsTableAdapter;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit phonenumberTextEdit;
        private DevExpress.XtraEditors.TextEdit pictureTextEdit;
        private DevExpress.XtraEditors.LabelControl enddatelabel;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl remainingdayslabel;
        private dataDataSetTableAdapters.memcheckTableAdapter memcheckTableAdapter1;
        private dataDataSetTableAdapters.membershipsTableAdapter membershipsTableAdapter1;
        private DevExpress.XtraEditors.LabelControl lablelastentrytime;
        private DevExpress.XtraEditors.LabelControl labelcurrenttime;
        private System.Windows.Forms.Timer timer1;
    }
}