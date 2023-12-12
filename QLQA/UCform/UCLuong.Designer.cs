
namespace QLQA.UCform
{
    partial class UCLuong
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
            this.tableAdapterManager1 = new QLQA.NewFolder1.DataSet1TableAdapters.TableAdapterManager();
            this.usP_GetListByDateTableAdapter1 = new QLQA.NewFolder1.DataSet1TableAdapters.USP_GetListByDateTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = QLQA.NewFolder1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.USP_GetListByDateTableAdapter = this.usP_GetListByDateTableAdapter1;
            // 
            // usP_GetListByDateTableAdapter1
            // 
            this.usP_GetListByDateTableAdapter1.ClearBeforeFill = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // UCLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UCLuong";
            this.Size = new System.Drawing.Size(1333, 645);
            this.Load += new System.EventHandler(this.UCLuong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private NewFolder1.DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NewFolder1.DataSet1TableAdapters.USP_GetListByDateTableAdapter usP_GetListByDateTableAdapter1;
       
    }
}
