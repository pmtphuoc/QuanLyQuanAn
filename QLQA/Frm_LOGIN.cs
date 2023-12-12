using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA
{
    public partial class Frm_LOGIN : Form
    {
        public Frm_LOGIN()
        {
            InitializeComponent();
         
        }

       
        bool dangnhap(string username, string password)
        {
            return DAO.DAO_TaiKhoan.Instance.danghap(username, password);
        }

       
       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            
            string username = cboLoaiTK.Text + txtname.Text;
            string password = txtpass.Text;
            if (dangnhap(username, password))
            {
                DTO.DTO_TaiKHoan layTTTK = DAO.DAO_TaiKhoan.Instance.laythongtinTK(username);
                this.Hide();
                FrmMain f = new FrmMain(layTTTK);
                f.ShowDialog();

            }
            else
            { labtest.Text = "*Sai tài khoản hoặc mật khẩu"; }
        }

       

        private void cboLoaiTK_Click(object sender, EventArgs e)
        {
            this.cboLoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }
        private bool issee = true;
        private void pBsee_Click_1(object sender, EventArgs e)
        {
            
        }
        private void Frm_LOGIN_Load(object sender, EventArgs e)
        {
            
            txtname.Enabled = false;
            cboLoaiTK_Click(sender, e);
            

        }

       

        private void cboLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            txtname.Enabled = true;
            txtname.Clear();
            txtname.Focus();
        }




    }
}
