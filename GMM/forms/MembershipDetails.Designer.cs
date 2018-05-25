using System;
using System.Windows.Forms;

namespace GMM.forms
{
    partial class MembershipDetails
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.membershipStartDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.membershipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new GMM.dataDataSet();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mambershipDaysSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.membershipEndDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.membershipPriceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.amountPaidedSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.amountRemainingSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nameSpinEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.membershipsTableAdapter = new GMM.dataDataSetTableAdapters.membershipsTableAdapter();
            this.tableAdapterManager = new GMM.dataDataSetTableAdapters.TableAdapterManager();
            this.membersTableAdapter = new GMM.dataDataSetTableAdapters.membersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membershipStartDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipStartDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mambershipDaysSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipEndDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipEndDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipPriceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountPaidedSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountRemainingSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.membershipStartDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.mambershipDaysSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.membershipEndDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.membershipPriceSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.amountPaidedSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.amountRemainingSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.nameSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.checkEdit1);
            this.dataLayoutControl1.DataSource = this.membershipsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 179);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(981, 424, 812, 500);
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(939, 593);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // membershipStartDateDateEdit
            // 
            this.membershipStartDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membershipsBindingSource, "MembershipStartDate", true));
            this.membershipStartDateDateEdit.EditValue = null;
            this.membershipStartDateDateEdit.Location = new System.Drawing.Point(16, 44);
            this.membershipStartDateDateEdit.MenuManager = this.mainRibbonControl;
            this.membershipStartDateDateEdit.Name = "membershipStartDateDateEdit";
            this.membershipStartDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.membershipStartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.membershipStartDateDateEdit.Properties.DisplayFormat.FormatString = "dd - MM - yyyy";
            this.membershipStartDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.membershipStartDateDateEdit.Properties.EditFormat.FormatString = "dd - MM - yyyy";
            this.membershipStartDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.membershipStartDateDateEdit.Properties.Mask.EditMask = "dd - MM - yyyy";
            this.membershipStartDateDateEdit.Size = new System.Drawing.Size(785, 22);
            this.membershipStartDateDateEdit.StyleController = this.dataLayoutControl1;
            this.membershipStartDateDateEdit.TabIndex = 7;
            this.membershipStartDateDateEdit.EditValueChanged += new System.EventHandler(this.membershipStartDateDateEdit_EditValueChanged);
            // 
            // membershipsBindingSource
            // 
            this.membershipsBindingSource.DataMember = "memberships";
            this.membershipsBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(939, 179);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // mambershipDaysSpinEdit
            // 
            this.mambershipDaysSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membershipsBindingSource, "MambershipDays", true));
            this.mambershipDaysSpinEdit.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.mambershipDaysSpinEdit.Location = new System.Drawing.Point(16, 72);
            this.mambershipDaysSpinEdit.MenuManager = this.mainRibbonControl;
            this.mambershipDaysSpinEdit.Name = "mambershipDaysSpinEdit";
            this.mambershipDaysSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mambershipDaysSpinEdit.Properties.IsFloatValue = false;
            this.mambershipDaysSpinEdit.Properties.Mask.EditMask = "N00";
            this.mambershipDaysSpinEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mambershipDaysSpinEdit.Size = new System.Drawing.Size(785, 22);
            this.mambershipDaysSpinEdit.StyleController = this.dataLayoutControl1;
            this.mambershipDaysSpinEdit.TabIndex = 9;
            this.mambershipDaysSpinEdit.EditValueChanged += new System.EventHandler(this.mambershipDaysSpinEdit_EditValueChanged);
            // 
            // membershipEndDateDateEdit
            // 
            this.membershipEndDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membershipsBindingSource, "MembershipEndDate", true));
            this.membershipEndDateDateEdit.EditValue = null;
            this.membershipEndDateDateEdit.Location = new System.Drawing.Point(16, 100);
            this.membershipEndDateDateEdit.MenuManager = this.mainRibbonControl;
            this.membershipEndDateDateEdit.Name = "membershipEndDateDateEdit";
            this.membershipEndDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.membershipEndDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.membershipEndDateDateEdit.Properties.DisplayFormat.FormatString = "dd - MM- yyyy";
            this.membershipEndDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.membershipEndDateDateEdit.Properties.EditFormat.FormatString = "dd - MM - yyyy";
            this.membershipEndDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.membershipEndDateDateEdit.Properties.Mask.EditMask = "dd - MM - yyyy";
            this.membershipEndDateDateEdit.Size = new System.Drawing.Size(785, 22);
            this.membershipEndDateDateEdit.StyleController = this.dataLayoutControl1;
            this.membershipEndDateDateEdit.TabIndex = 11;
            // 
            // membershipPriceSpinEdit
            // 
            this.membershipPriceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membershipsBindingSource, "MembershipPrice", true));
            this.membershipPriceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.membershipPriceSpinEdit.Location = new System.Drawing.Point(16, 128);
            this.membershipPriceSpinEdit.MenuManager = this.mainRibbonControl;
            this.membershipPriceSpinEdit.Name = "membershipPriceSpinEdit";
            this.membershipPriceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.membershipPriceSpinEdit.Properties.IsFloatValue = false;
            this.membershipPriceSpinEdit.Properties.Mask.EditMask = "N00";
            this.membershipPriceSpinEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.membershipPriceSpinEdit.Size = new System.Drawing.Size(785, 22);
            this.membershipPriceSpinEdit.StyleController = this.dataLayoutControl1;
            this.membershipPriceSpinEdit.TabIndex = 13;
            this.membershipPriceSpinEdit.EditValueChanged += new System.EventHandler(this.membershipPriceSpinEdit_EditValueChanged);
            // 
            // amountPaidedSpinEdit
            // 
            this.amountPaidedSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membershipsBindingSource, "AmountPaided", true));
            this.amountPaidedSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.amountPaidedSpinEdit.Location = new System.Drawing.Point(16, 156);
            this.amountPaidedSpinEdit.MenuManager = this.mainRibbonControl;
            this.amountPaidedSpinEdit.Name = "amountPaidedSpinEdit";
            this.amountPaidedSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.amountPaidedSpinEdit.Properties.IsFloatValue = false;
            this.amountPaidedSpinEdit.Properties.Mask.EditMask = "N00";
            this.amountPaidedSpinEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amountPaidedSpinEdit.Size = new System.Drawing.Size(785, 22);
            this.amountPaidedSpinEdit.StyleController = this.dataLayoutControl1;
            this.amountPaidedSpinEdit.TabIndex = 15;
            this.amountPaidedSpinEdit.EditValueChanged += new System.EventHandler(this.amountPaidedSpinEdit_EditValueChanged);
            // 
            // amountRemainingSpinEdit
            // 
            this.amountRemainingSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membershipsBindingSource, "AmountRemaining", true));
            this.amountRemainingSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.amountRemainingSpinEdit.Location = new System.Drawing.Point(16, 184);
            this.amountRemainingSpinEdit.MenuManager = this.mainRibbonControl;
            this.amountRemainingSpinEdit.Name = "amountRemainingSpinEdit";
            this.amountRemainingSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.amountRemainingSpinEdit.Properties.IsFloatValue = false;
            this.amountRemainingSpinEdit.Properties.Mask.EditMask = "N00";
            this.amountRemainingSpinEdit.Properties.ReadOnly = true;
            this.amountRemainingSpinEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amountRemainingSpinEdit.Size = new System.Drawing.Size(785, 22);
            this.amountRemainingSpinEdit.StyleController = this.dataLayoutControl1;
            this.amountRemainingSpinEdit.TabIndex = 17;
            // 
            // nameSpinEdit
            // 
            this.nameSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membershipsBindingSource, "Mname", true));
            this.nameSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nameSpinEdit.Location = new System.Drawing.Point(16, 16);
            this.nameSpinEdit.MenuManager = this.mainRibbonControl;
            this.nameSpinEdit.Name = "nameSpinEdit";
            this.nameSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nameSpinEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "الكود", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "اسم المشترك", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("dateofbirth", "تاريخ الميلاد", 79, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("phonenumber", "رقم الهاتف", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AlternatePhoneNumber", "رقم الهاتف البديل", 109, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Adress", "العنوان", 47, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Picture", "الصورة", 46, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Barecode", "الباركود", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.nameSpinEdit.Properties.DataSource = this.membersBindingSource;
            this.nameSpinEdit.Properties.DisplayMember = "name";
            this.nameSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.nameSpinEdit.Properties.NullText = "";
            this.nameSpinEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.nameSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.nameSpinEdit.Properties.ValueMember = "ID";
            this.nameSpinEdit.Size = new System.Drawing.Size(785, 22);
            this.nameSpinEdit.StyleController = this.dataLayoutControl1;
            this.nameSpinEdit.TabIndex = 5;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.dataDataSet;
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.membershipsBindingSource, "IsCanceled", true));
            this.checkEdit1.Location = new System.Drawing.Point(16, 212);
            this.checkEdit1.MenuManager = this.mainRibbonControl;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "الغاء الاشتراك";
            this.checkEdit1.Size = new System.Drawing.Size(907, 21);
            this.checkEdit1.StyleController = this.dataLayoutControl1;
            this.checkEdit1.TabIndex = 18;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(939, 593);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem12,
            this.layoutControlItem14,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(913, 567);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.nameSpinEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(913, 28);
            this.layoutControlItem2.Text = "الاسم:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.membershipStartDateDateEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(913, 28);
            this.layoutControlItem4.Text = "تاريخ الاشتراك:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.mambershipDaysSpinEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(913, 28);
            this.layoutControlItem6.Text = "مدة الاشتراك:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.membershipEndDateDateEdit;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(913, 28);
            this.layoutControlItem8.Text = "تاريخ انتهاء الاشتراك:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.membershipPriceSpinEdit;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(913, 28);
            this.layoutControlItem10.Text = "مبلغ الاشتراك:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.amountPaidedSpinEdit;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(913, 28);
            this.layoutControlItem12.Text = "المبلغ الواصل:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.amountRemainingSpinEdit;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(913, 28);
            this.layoutControlItem14.Text = "المبلغ المتبقي:";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 196);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(913, 371);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // membershipsTableAdapter
            // 
            this.membershipsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.membershipsTableAdapter = this.membershipsTableAdapter;
            this.tableAdapterManager.membersTableAdapter = null;
            this.tableAdapterManager.memcheckTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GMM.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // MembershipDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(939, 772);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MembershipDetails";
            this.Ribbon = this.mainRibbonControl;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الاشتراك";
            this.Load += new System.EventHandler(this.MembershipDetails_Load);
            this.Shown += new System.EventHandler(this.MembershipDetails_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membershipStartDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipStartDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mambershipDaysSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipEndDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipEndDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipPriceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountPaidedSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountRemainingSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource membershipsBindingSource;
        private dataDataSetTableAdapters.membershipsTableAdapter membershipsTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.DateEdit membershipStartDateDateEdit;
        private DevExpress.XtraEditors.SpinEdit mambershipDaysSpinEdit;
        private DevExpress.XtraEditors.DateEdit membershipEndDateDateEdit;
        private DevExpress.XtraEditors.SpinEdit membershipPriceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit amountPaidedSpinEdit;
        private DevExpress.XtraEditors.SpinEdit amountRemainingSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraEditors.LookUpEdit nameSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private dataDataSetTableAdapters.membersTableAdapter membersTableAdapter;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}