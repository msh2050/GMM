namespace GMM.forms
{
    partial class NewMembersList
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
            DevExpress.Utils.ContextButton contextButton1 = new DevExpress.Utils.ContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMembersList));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan4 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement8 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement9 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement10 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colname = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.coltotalcheck = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.coltotalcheckMonth = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.coltotalcheckDay = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colphonenumber = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAmountRemaining = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colMembershipEndDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet1 = new GMM.dataDataSet();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colBarecode = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colIsDeactivated = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colIsCanceled = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataTable2TableAdapter1 = new GMM.dataDataSetTableAdapters.DataTable2TableAdapter();
            this.memcheckTableAdapter1 = new GMM.dataDataSetTableAdapters.memcheckTableAdapter();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // coltotalcheck
            // 
            this.coltotalcheck.FieldName = "totalcheck";
            this.coltotalcheck.Name = "coltotalcheck";
            this.coltotalcheck.Visible = true;
            this.coltotalcheck.VisibleIndex = 9;
            // 
            // coltotalcheckMonth
            // 
            this.coltotalcheckMonth.FieldName = "totalcheckMonth";
            this.coltotalcheckMonth.Name = "coltotalcheckMonth";
            this.coltotalcheckMonth.Visible = true;
            this.coltotalcheckMonth.VisibleIndex = 10;
            // 
            // coltotalcheckDay
            // 
            this.coltotalcheckDay.FieldName = "totalcheckDay";
            this.coltotalcheckDay.Name = "coltotalcheckDay";
            this.coltotalcheckDay.Visible = true;
            this.coltotalcheckDay.VisibleIndex = 11;
            // 
            // colphonenumber
            // 
            this.colphonenumber.FieldName = "phonenumber";
            this.colphonenumber.Name = "colphonenumber";
            this.colphonenumber.Visible = true;
            this.colphonenumber.VisibleIndex = 2;
            // 
            // colAmountRemaining
            // 
            this.colAmountRemaining.FieldName = "AmountRemaining";
            this.colAmountRemaining.Name = "colAmountRemaining";
            this.colAmountRemaining.Visible = true;
            this.colAmountRemaining.VisibleIndex = 7;
            // 
            // colMembershipEndDate
            // 
            this.colMembershipEndDate.DisplayFormat.FormatString = "dd / MM / yyyy";
            this.colMembershipEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMembershipEndDate.FieldName = "MembershipEndDate";
            this.colMembershipEndDate.Name = "colMembershipEndDate";
            this.colMembershipEndDate.Visible = true;
            this.colMembershipEndDate.VisibleIndex = 6;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchControl1);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 96);
            this.panel1.TabIndex = 0;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControl1;
            this.searchControl1.Location = new System.Drawing.Point(12, 61);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton(),
            new DevExpress.XtraEditors.Repository.MRUButton()});
            this.searchControl1.Properties.Client = this.gridControl1;
            this.searchControl1.Properties.ShowMRUButton = true;
            this.searchControl1.Size = new System.Drawing.Size(256, 22);
            this.searchControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataTable2BindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 96);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1000, 305);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dataDataSet1;
            this.dataTable2BindingSource.Sort = "";
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "dataDataSet";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colname,
            this.colphonenumber,
            this.colPicture,
            this.colBarecode,
            this.colIsDeactivated,
            this.colMembershipEndDate,
            this.colAmountRemaining,
            this.colIsCanceled,
            this.coltotalcheck,
            this.coltotalcheckMonth,
            this.coltotalcheckDay});
            this.tileView1.ColumnSet.GroupColumn = this.colIsDeactivated;
            contextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            contextButton1.AppearanceHover.BackColor = System.Drawing.Color.Chartreuse;
            contextButton1.AppearanceHover.Options.UseBackColor = true;
            contextButton1.AppearanceNormal.BackColor = System.Drawing.Color.Gold;
            contextButton1.AppearanceNormal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            contextButton1.AppearanceNormal.ForeColor = System.Drawing.Color.CadetBlue;
            contextButton1.AppearanceNormal.Options.UseBackColor = true;
            contextButton1.AppearanceNormal.Options.UseFont = true;
            contextButton1.AppearanceNormal.Options.UseForeColor = true;
            contextButton1.Caption = "تسجيل الدخول";
            contextButton1.HyperLinkColor = System.Drawing.Color.Red;
            contextButton1.Id = new System.Guid("eee631b9-9e03-4c02-bfea-c775907f14c0");
            contextButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            contextButton1.Name = "contextButton1";
            this.tileView1.ContextButtons.Add(contextButton1);
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ColumnCount = 4;
            this.tileView1.OptionsTiles.IndentBetweenGroups = 42;
            this.tileView1.OptionsTiles.IndentBetweenItems = 5;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(240, 120);
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(5);
            this.tileView1.OptionsTiles.RowCount = 5;
            this.tileView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIsDeactivated, DevExpress.Data.ColumnSortOrder.Ascending)});
            tableColumnDefinition1.Length.Value = 55D;
            tableColumnDefinition2.Length.Value = 53D;
            tableColumnDefinition3.Length.Value = 90D;
            tableColumnDefinition4.Length.Value = 66D;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            this.tileView1.TileColumns.Add(tableColumnDefinition3);
            this.tileView1.TileColumns.Add(tableColumnDefinition4);
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            this.tileView1.TileRows.Add(tableRowDefinition3);
            this.tileView1.TileRows.Add(tableRowDefinition4);
            tableSpan1.ColumnIndex = 2;
            tableSpan1.ColumnSpan = 2;
            tableSpan2.ColumnIndex = 2;
            tableSpan2.ColumnSpan = 2;
            tableSpan2.RowIndex = 1;
            tableSpan3.ColumnSpan = 2;
            tableSpan3.RowSpan = 3;
            tableSpan4.ColumnIndex = 2;
            tableSpan4.ColumnSpan = 2;
            tableSpan4.RowIndex = 2;
            this.tileView1.TileSpans.Add(tableSpan1);
            this.tileView1.TileSpans.Add(tableSpan2);
            this.tileView1.TileSpans.Add(tableSpan3);
            this.tileView1.TileSpans.Add(tableSpan4);
            tileViewItemElement1.Appearance.Normal.FontSizeDelta = 1;
            tileViewItemElement1.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            tileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.Red;
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement1.Column = this.colname;
            tileViewItemElement1.ColumnIndex = 2;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colname";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement2.Appearance.Normal.FontSizeDelta = -2;
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.colID;
            tileViewItemElement2.ColumnIndex = 3;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.Text = "colID";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileViewItemElement3.Column = this.coltotalcheck;
            tileViewItemElement3.ColumnIndex = 2;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 3;
            tileViewItemElement3.Text = "coltotalcheck";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileViewItemElement4.Appearance.Normal.FontSizeDelta = -2;
            tileViewItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.Red;
            tileViewItemElement4.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement4.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement4.Column = this.coltotalcheckMonth;
            tileViewItemElement4.ColumnIndex = 3;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 3;
            tileViewItemElement4.Text = "coltotalcheckMonth";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileViewItemElement5.Appearance.Normal.FontSizeDelta = -2;
            tileViewItemElement5.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement5.Column = this.coltotalcheckDay;
            tileViewItemElement5.ColumnIndex = 3;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.RowIndex = 3;
            tileViewItemElement5.Text = "coltotalcheckDay";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileViewItemElement6.Column = this.colphonenumber;
            tileViewItemElement6.ColumnIndex = 2;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.RowIndex = 1;
            tileViewItemElement6.Text = "colphonenumber";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement7.Appearance.Normal.FontSizeDelta = 2;
            tileViewItemElement7.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement7.Column = this.colAmountRemaining;
            tileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement7.RowIndex = 3;
            tileViewItemElement7.Text = "colAmountRemaining";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileViewItemElement8.Appearance.Normal.FontSizeDelta = -1;
            tileViewItemElement8.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement8.Column = this.colMembershipEndDate;
            tileViewItemElement8.ColumnIndex = 2;
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement8.RowIndex = 2;
            tileViewItemElement8.Text = "colMembershipEndDate";
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement9.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileViewItemElement9.Name = "Picture";
            tileViewItemElement9.StretchHorizontal = true;
            tileViewItemElement9.StretchVertical = true;
            tileViewItemElement9.Text = "Picture";
            tileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement9.TextVisible = false;
            tileViewItemElement10.Column = this.colPicture;
            tileViewItemElement10.ColumnIndex = 3;
            tileViewItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement10.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement10.RowIndex = 1;
            tileViewItemElement10.Text = "colPicture";
            tileViewItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileViewItemElement10.TextVisible = false;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            this.tileView1.TileTemplate.Add(tileViewItemElement5);
            this.tileView1.TileTemplate.Add(tileViewItemElement6);
            this.tileView1.TileTemplate.Add(tileViewItemElement7);
            this.tileView1.TileTemplate.Add(tileViewItemElement8);
            this.tileView1.TileTemplate.Add(tileViewItemElement9);
            this.tileView1.TileTemplate.Add(tileViewItemElement10);
            this.tileView1.ContextButtonClick += new DevExpress.Utils.ContextItemClickEventHandler(this.tileView1_ContextButtonClick);
            this.tileView1.ItemCustomize += new DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(this.tileView1_ItemCustomize);
            this.tileView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.tileView1_CustomColumnDisplayText);
            this.tileView1.DoubleClick += new System.EventHandler(this.tileView1_DoubleClick);
            // 
            // colBarecode
            // 
            this.colBarecode.FieldName = "Barecode";
            this.colBarecode.Name = "colBarecode";
            this.colBarecode.Visible = true;
            this.colBarecode.VisibleIndex = 4;
            // 
            // colIsDeactivated
            // 
            this.colIsDeactivated.FieldName = "IsDeactivated";
            this.colIsDeactivated.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIsDeactivated.Name = "colIsDeactivated";
            this.colIsDeactivated.Visible = true;
            this.colIsDeactivated.VisibleIndex = 5;
            // 
            // colIsCanceled
            // 
            this.colIsCanceled.FieldName = "IsCanceled";
            this.colIsCanceled.Name = "colIsCanceled";
            this.colIsCanceled.Visible = true;
            this.colIsCanceled.VisibleIndex = 8;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(276, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 82);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "تعديل المشترك";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(385, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 82);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "اضافة مشترك";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dataTable2TableAdapter1
            // 
            this.dataTable2TableAdapter1.ClearBeforeFill = true;
            // 
            // memcheckTableAdapter1
            // 
            this.memcheckTableAdapter1.ClearBeforeFill = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton3.Location = new System.Drawing.Point(595, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(91, 82);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "تحديث";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // NewMembersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 401);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "NewMembersList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "قائمة المشتركين";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private dataDataSet dataDataSet1;
        private dataDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colID;
        private DevExpress.XtraGrid.Columns.TileViewColumn colname;
        private DevExpress.XtraGrid.Columns.TileViewColumn colphonenumber;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPicture;
        private DevExpress.XtraGrid.Columns.TileViewColumn colBarecode;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIsDeactivated;
        private DevExpress.XtraGrid.Columns.TileViewColumn colMembershipEndDate;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAmountRemaining;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIsCanceled;
        private DevExpress.XtraGrid.Columns.TileViewColumn coltotalcheck;
        private DevExpress.XtraGrid.Columns.TileViewColumn coltotalcheckMonth;
        private DevExpress.XtraGrid.Columns.TileViewColumn coltotalcheckDay;
        private dataDataSetTableAdapters.memcheckTableAdapter memcheckTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}