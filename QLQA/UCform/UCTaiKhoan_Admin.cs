using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DAO;
using System.Security.Cryptography;
using System.IO;

namespace QLQA.UCform
{
    public partial class UCTaiKhoan_Admin : UserControl
    {
        private DTO.DTO_TaiKHoan laytk;

        public DTO_TaiKHoan Laytk { get => laytk; set => laytk = value; }

        public UCTaiKhoan_Admin(DTO_TaiKHoan acc)
        {
            InitializeComponent();
            Laytk = acc;
        }





        #region EnventLoadDateGV

        private void UCTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvtaikhoan.Enabled = true;
            pictureBox2.Visible = false;
            txtTenndDN.Enabled = false;
            txtTentkDN.Enabled = false;
            txtMatkhauDN.Enabled = false;
            txtChucvuDN.Enabled = false;
            txtMaLoaiTK.Enabled = false;
            txtMatKhau.Enabled = false;
            txtSoTK.Enabled = false;
            txtNguoiDung.Enabled = false;
            cboCapDo.Enabled = false;

            
            txtTenndDN.Text = Laytk.DisPlayName;
            txtTentkDN.Text = Laytk.UserName;
            txtMatkhauDN.Text = Laytk.PassWord;

            int CN;
            CN = Laytk.Type;
            if (CN == 1)
            { txtChucvuDN.Text = "User"; }
            else
            { txtChucvuDN.Text = "Admin"; }
            grBdoimatkhau.Hide();
            load();
            pBXacNhan.Visible = false;


        }
        #region

        #endregion

        void load()
        {
            dgvtaikhoan.DataSource = BUS_TaiKhoan.laydstaikhoan();
            dgvtaikhoan.Columns["UserName"].HeaderText = "Tài Khoản";
            dgvtaikhoan.Columns["UserName"].Width = 170;

            dgvtaikhoan.Columns["DisplayName"].HeaderText = "Tên Hiển Thị";
            dgvtaikhoan.Columns["DisplayName"].Width = 180;

            dgvtaikhoan.Columns["PassWord"].HeaderText = "Mật Khẩu";
            dgvtaikhoan.Columns["PassWord"].Width = 130;

            dgvtaikhoan.Columns["Type"].HeaderText = "Quyền";
            dgvtaikhoan.Columns["Type"].Width = 80;
        }
        #endregion
        #region Thuoc_tinh
        private void txtTenTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57)) || (e.KeyChar == 8))
            {

                e.Handled = false;
            }
            else
            {
                if (e.KeyChar == (char)32)
                {
                    MessageBox.Show("Không được cách khoảng trong <Tên Tài Khoản>! ");
                }
                else
                    MessageBox.Show("Không được nhập ký tự này vào <Tên Tài Khoản>!");
                e.Handled = true;
            }
        }
        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57)) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                if (e.KeyChar == (char)32)
                {
                    MessageBox.Show("Không được cách khoảng trong < Mật Khẩu>! ");
                }
                else
                    MessageBox.Show("Không được nhập ký tự này vào <Mật Khẩu>!");
                e.Handled = true;
            }
        }
        private void cboCapDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCapDo.Text == "Admin")
            {
                txtMaLoaiTK.Text = "AD";
            }
            else { txtMaLoaiTK.Text = "US"; }
        }
        #endregion
        #region Envent
        private void txtMaLoaiTK_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {

            grBdoimatkhau.Show();
        }
        private void dgvtaikhoan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvtaikhoan.SelectedRows[0];
            txtSoTK.Text = dr.Cells["UserName"].Value.ToString();
            txtNguoiDung.Text = dr.Cells["DisplayName"].Value.ToString();
            txtMatKhau.Text = dr.Cells["PassWord"].Value.ToString();
            byte[] data = Convert.FromBase64String(txtMatKhau.Text);
            
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtMatKhau.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
            
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int id = (int)dgvtaikhoan.SelectedCells[0].OwningRow.Cells["Type"].Value;
            if (id == 0)
            {
                cboCapDo.Text = "Admin";
            }
            else { cboCapDo.Text = "User"; }

        }
        private bool isThem = true;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string username = txtSoTK.Text;
                if (BUS_TaiKhoan.xoataikhoan(username))
                {
                    MessageBox.Show("Xóa tài khoảng thành công!");
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa Không thành công!");
                }
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string mk = Laytk.PassWord;

            #region dịch ngược mật khẩu
            byte[] data = Convert.FromBase64String(mk);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    mk = UTF8Encoding.UTF8.GetString(results);
                }
            }
            #endregion
            if (txtMKold.Text != mk)
            {
                MessageBox.Show("Mật khẩu nhập không đúng");
            }
            else if (txtMKnew.Text != txtmatkhauKT.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng");
            }
            else if (txtMKnew.Text == txtMKold.Text)
            { MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ"); }
            else
            {
                string username = txtTentkDN.Text;
                string displayname = txtTenndDN.Text;

                byte[] sua = UTF8Encoding.UTF8.GetBytes(txtMKnew.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(sua, 0, sua.Length);
                        string password = Convert.ToBase64String(results, 0, results.Length);
                       

                        int i = 0; int type = i;
                        if (BUS_TaiKhoan.suataikhoan(username, displayname, password))
                        {
                            if (MessageBox.Show("Sửa mật khẩu thành công bạn có muốn thoát đăng nhập lại để reset thông tin mật khẩu hiện tại", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                            {
                                FrmMain.main.Thoat();
                            }
                            else { load(); buttonX1.Enabled = false; }
                        }
                        else
                        {
                            MessageBox.Show("Sửa Không thành công!");
                        }
                    }
                }
            }
        }
        private void pBXacNhan_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                try
                {
                    if (txtSoTK.Text == "")
                    { MessageBox.Show("Tên Tài Khoản Không Được Bỏ Trống"); txtSoTK.Focus(); }
                    else
                       if (txtMatKhau.Text == "")
                    { MessageBox.Show("Mật khẩu Không Được Bỏ Trống"); txtMatKhau.Focus(); }
                    else
                            if (txtNguoiDung.Text == "")
                    { MessageBox.Show("Ten nguoi dung Không Được Bỏ Trống"); txtNguoiDung.Focus(); }
                    else
                    {
                        #region
                        if (cboCapDo.Text == "Admin")
                        {
                            string username = txtMaLoaiTK.Text + txtSoTK.Text;
                            string displayname = txtNguoiDung.Text;
                            //string password = txtMatKhau.Text;
                            #region mã hóa MK
                            byte[] data = UTF8Encoding.UTF8.GetBytes(txtMatKhau.Text);
                            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                            {
                                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                                {
                                    ICryptoTransform transform = tripDes.CreateEncryptor();
                                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                                    string password = Convert.ToBase64String(results, 0, results.Length);

                                    #endregion

                                    int i = 0; int type = i;
                                    if (BUS_TaiKhoan.themtaikhoan(username, displayname, password, type))
                                    {
                                        MessageBox.Show("them tài khoảng thành công!");
                                        btnXoa.Enabled = true;
                                        btnSua.Enabled = true;
                                        load();
                                    }
                                    else
                                    {
                                        MessageBox.Show("them Không thành công!");
                                    }
                                }
                            }
                        }
                        else
                        {

                            string username = txtMaLoaiTK.Text + txtSoTK.Text;
                            string displayname = txtNguoiDung.Text;
                            byte[] data = UTF8Encoding.UTF8.GetBytes(txtMatKhau.Text);
                            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                            {
                                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                                {
                                    ICryptoTransform transform = tripDes.CreateEncryptor();
                                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                                    string password = Convert.ToBase64String(results, 0, results.Length);

                                    int i = 1; int type = i;
                                    if (BUS_TaiKhoan.themtaikhoan(username, displayname, password, type))
                                    {
                                        MessageBox.Show("them tài khoảng thành công!");
                                        load();
                                    }
                                    else
                                    {
                                        MessageBox.Show("them Không thành công!");
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                { throw ex; }
            }
            #endregion
            else
            {
                if (cboCapDo.Text == "Admin")
                {
                    string username = txtSoTK.Text;
                    string displayname = txtNguoiDung.Text;
                    byte[] sua = UTF8Encoding.UTF8.GetBytes(txtMatKhau.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripDes.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(sua, 0, sua.Length);
                            string password = Convert.ToBase64String(results, 0, results.Length);

                            int i = 0; int type = i;
                            if (BUS_TaiKhoan.suataikhoan(username, displayname, password))
                            {
                                MessageBox.Show("Sửa tài khoảng thành công!");
                                load();
                            }
                            else
                            {
                                MessageBox.Show("Sửa Không thành công!");
                            }
                        }
                    }
                }
                else
                {
                    string username = txtSoTK.Text;
                    string displayname = txtNguoiDung.Text;
                    byte[] sua = UTF8Encoding.UTF8.GetBytes(txtMatKhau.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripDes.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(sua, 0, sua.Length);
                            string password = Convert.ToBase64String(results, 0, results.Length);

                            int i = 1; int type = i;
                            if (BUS_TaiKhoan.suataikhoan(username, displayname, password))
                            {
                                MessageBox.Show("Sửa tài khoảng thành công!");
                                load();
                            }
                            else
                            {
                                MessageBox.Show("Sửa Không thành công!");
                            }
                        }
                    }
                }
            }
            UCTaiKhoan_Load(sender, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = true;
            pBXacNhan.Visible = true;
            isThem = false;
            txtMatKhau.Enabled = true;
            txtSoTK.Enabled = true;
            txtNguoiDung.Enabled = true;
            cboCapDo.Enabled = true;
        } //xac nhan
        private void btnThem_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            isThem = true;
            txtMatKhau.Enabled = true;

            txtSoTK.Enabled = true;
            txtSoTK.Focus();
            txtNguoiDung.Enabled = true;
            cboCapDo.Enabled = true;
            pBXacNhan.Visible = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtmatkhauKT.Clear();
            txtSoTK.Clear();
            txtNguoiDung.Clear();
            dgvtaikhoan.Enabled = false;
        } //xac nhan
        #endregion
        string hash = "f0xle@rn";
        private void pBxemMK_Click(object sender, EventArgs e)
        {

        }

        private void pBxemMK_MouseUp(object sender, MouseEventArgs e)
        {
            eventtxt();
            this.txtMatkhauDN.PasswordChar = '*';
        }
        void eventtxt()
        {
            txtMatkhauDN.Text = Laytk.PassWord;
        }
        private void pBxemMK_MouseDown(object sender, MouseEventArgs e)
        {
            byte[] data = Convert.FromBase64String(txtMatkhauDN.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtMatkhauDN.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
            this.txtMatkhauDN.PasswordChar = '\0';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UCTaiKhoan_Load(sender,e);
        }

        private void pBHienMKmoi_MouseDown(object sender, MouseEventArgs e)
        {
           txtMKnew.PasswordChar = '\0';
        }

        private void pBHienMKmoi_MouseUp(object sender, MouseEventArgs e)
        {
             txtMKnew.PasswordChar = '*';
        }

        private void pBHienMKcheck_MouseDown(object sender, MouseEventArgs e)
        {
             txtmatkhauKT.PasswordChar = '\0';
        }

        private void pBHienMKcheck_MouseUp(object sender, MouseEventArgs e)
        {
           txtmatkhauKT.PasswordChar = '*';
        }

        private void dgvtaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
