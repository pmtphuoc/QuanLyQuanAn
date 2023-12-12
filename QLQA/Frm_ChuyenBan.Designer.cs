namespace QLQA
{
    partial class Frm_ChuyenBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboBanCanChuyen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboBanChuyen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnXacNhanChuyenBan = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 26);
            this.panel1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(121, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(120, 19);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Chuyển Bàn";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(29, 32);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(120, 19);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Bàn Cần Chuyển";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(219, 32);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(98, 19);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Bàn Chuyển";
            // 
            // cboBanCanChuyen
            // 
            this.cboBanCanChuyen.DisplayMember = "Text";
            this.cboBanCanChuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBanCanChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboBanCanChuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBanCanChuyen.FormattingEnabled = true;
            this.cboBanCanChuyen.ItemHeight = 21;
            this.cboBanCanChuyen.Location = new System.Drawing.Point(29, 59);
            this.cboBanCanChuyen.Name = "cboBanCanChuyen";
            this.cboBanCanChuyen.Size = new System.Drawing.Size(121, 27);
            this.cboBanCanChuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBanCanChuyen.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLQA.Properties.Resources.if_right_16_22618__1_;
            this.pictureBox1.Location = new System.Drawing.Point(156, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cboBanChuyen
            // 
            this.cboBanChuyen.DisplayMember = "Text";
            this.cboBanChuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBanChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboBanChuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBanChuyen.FormattingEnabled = true;
            this.cboBanChuyen.ItemHeight = 21;
            this.cboBanChuyen.Location = new System.Drawing.Point(219, 59);
            this.cboBanChuyen.Name = "cboBanChuyen";
            this.cboBanChuyen.Size = new System.Drawing.Size(121, 27);
            this.cboBanChuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBanChuyen.TabIndex = 1;
            // 
            // btnXacNhanChuyenBan
            // 
            this.btnXacNhanChuyenBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXacNhanChuyenBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXacNhanChuyenBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanChuyenBan.Location = new System.Drawing.Point(146, 102);
            this.btnXacNhanChuyenBan.Name = "btnXacNhanChuyenBan";
            this.btnXacNhanChuyenBan.Size = new System.Drawing.Size(82, 38);
            this.btnXacNhanChuyenBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXacNhanChuyenBan.TabIndex = 3;
            this.btnXacNhanChuyenBan.Text = "Xác Nhận";
            this.btnXacNhanChuyenBan.Click += new System.EventHandler(this.btnXacNhanChuyenBan_Click);
            // 
            // Frm_ChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 152);
            this.Controls.Add(this.btnXacNhanChuyenBan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboBanChuyen);
            this.Controls.Add(this.cboBanCanChuyen);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ChuyenBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển Bàn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ChuyenBan_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ChuyenBan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBanCanChuyen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBanChuyen;
        private DevComponents.DotNetBar.ButtonX btnXacNhanChuyenBan;
    }
}