namespace QLQA.UCform
{
    partial class UCDoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uSPGetListByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanAnDataSet = new QLQA.QuanLyQuanAnDataSet();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.reportdoanhthu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dateTimePickercheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickercheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.uSP_GetListByDateTableAdapter = new QLQA.QuanLyQuanAnDataSetTableAdapters.USP_GetListByDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanAnDataSet)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uSPGetListByDateBindingSource
            // 
            this.uSPGetListByDateBindingSource.DataMember = "USP_GetListByDate";
            this.uSPGetListByDateBindingSource.DataSource = this.quanLyQuanAnDataSet;
            // 
            // quanLyQuanAnDataSet
            // 
            this.quanLyQuanAnDataSet.DataSetName = "QuanLyQuanAnDataSet";
            this.quanLyQuanAnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.reportdoanhthu);
            this.groupPanel1.Controls.Add(this.panelEx1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1366, 587);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Quản Lý Doanh Thu";
            // 
            // reportdoanhthu
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPGetListByDateBindingSource;
            this.reportdoanhthu.LocalReport.DataSources.Add(reportDataSource1);
            this.reportdoanhthu.LocalReport.ReportEmbeddedResource = "QLQA.NewFolder1.Report1.rdlc";
            this.reportdoanhthu.Location = new System.Drawing.Point(340, 139);
            this.reportdoanhthu.Name = "reportdoanhthu";
            this.reportdoanhthu.ServerReport.BearerToken = null;
            this.reportdoanhthu.Size = new System.Drawing.Size(699, 422);
            this.reportdoanhthu.TabIndex = 8;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.dateTimePickercheckIn);
            this.panelEx1.Controls.Add(this.dateTimePickercheckOut);
            this.panelEx1.Controls.Add(this.btnTim);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1360, 139);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Click += new System.EventHandler(this.panelEx1_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(888, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(101, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Ngày Kết Thúc";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(393, 1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(107, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Ngày Bắt Đầu";
            // 
            // dateTimePickercheckIn
            // 
            this.dateTimePickercheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickercheckIn.Location = new System.Drawing.Point(340, 30);
            this.dateTimePickercheckIn.Name = "dateTimePickercheckIn";
            this.dateTimePickercheckIn.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickercheckIn.TabIndex = 7;
            // 
            // dateTimePickercheckOut
            // 
            this.dateTimePickercheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickercheckOut.Location = new System.Drawing.Point(839, 30);
            this.dateTimePickercheckOut.Name = "dateTimePickercheckOut";
            this.dateTimePickercheckOut.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickercheckOut.TabIndex = 7;
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(608, 77);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(156, 53);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // uSP_GetListByDateTableAdapter
            // 
            this.uSP_GetListByDateTableAdapter.ClearBeforeFill = true;
            // 
            // UCDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel1);
            this.Name = "UCDoanhThu";
            this.Size = new System.Drawing.Size(1366, 587);
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanAnDataSet)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.DateTimePicker dateTimePickercheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePickercheckOut;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.Reporting.WinForms.ReportViewer reportdoanhthu;
        private System.Windows.Forms.BindingSource uSPGetListByDateBindingSource;
        private QuanLyQuanAnDataSet quanLyQuanAnDataSet;
        private QuanLyQuanAnDataSetTableAdapters.USP_GetListByDateTableAdapter uSP_GetListByDateTableAdapter;
    }
}
