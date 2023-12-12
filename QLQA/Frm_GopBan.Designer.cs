namespace QLQA
{
    partial class Frm_GopBan
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.cboBanGop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboBanCanGop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel1.Size = new System.Drawing.Size(350, 25);
            this.panel1.TabIndex = 4;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(132, 6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(120, 19);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Gộp Bàn";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(132, 102);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(82, 38);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 10;
            this.buttonX1.Text = "Xác Nhận";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // cboBanGop
            // 
            this.cboBanGop.DisplayMember = "Text";
            this.cboBanGop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBanGop.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboBanGop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBanGop.FormattingEnabled = true;
            this.cboBanGop.ItemHeight = 21;
            this.cboBanGop.Location = new System.Drawing.Point(206, 58);
            this.cboBanGop.Name = "cboBanGop";
            this.cboBanGop.Size = new System.Drawing.Size(121, 27);
            this.cboBanGop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBanGop.TabIndex = 7;
            // 
            // cboBanCanGop
            // 
            this.cboBanCanGop.DisplayMember = "Text";
            this.cboBanCanGop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBanCanGop.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboBanCanGop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBanCanGop.FormattingEnabled = true;
            this.cboBanCanGop.ItemHeight = 21;
            this.cboBanCanGop.Location = new System.Drawing.Point(16, 58);
            this.cboBanCanGop.Name = "cboBanCanGop";
            this.cboBanCanGop.Size = new System.Drawing.Size(121, 27);
            this.cboBanCanGop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBanCanGop.TabIndex = 8;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(206, 31);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(98, 19);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Bàn Gộp";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(16, 31);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(120, 19);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Bàn Cần Gộp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLQA.Properties.Resources.if_right_16_22618__1_;
            this.pictureBox1.Location = new System.Drawing.Point(143, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_GopBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 152);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboBanGop);
            this.Controls.Add(this.cboBanCanGop);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Name = "Frm_GopBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gộp Bàn";
            this.Load += new System.EventHandler(this.Frm_GopBan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBanGop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBanCanGop;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}