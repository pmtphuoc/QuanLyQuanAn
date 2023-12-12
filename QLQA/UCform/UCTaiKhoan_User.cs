using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Security.Cryptography;

namespace QLQA.UCform
{
    public partial class UCTaiKhoan_User : UserControl
    {
        string hash = "f0xle@rn";
        private DTO.DTO_TaiKHoan laytk;

        public DTO_TaiKHoan Laytk { get => laytk; set => laytk = value; }

        public UCTaiKhoan_User(DTO_TaiKHoan acc)
        {
            InitializeComponent();
            Laytk = acc;
        }

        private void UCTaiKhoan_Load(object sender, EventArgs e)
        {
            txtChucvu.Enabled = false;
            txtMK.Enabled = false;
            txtTenndDN.Enabled = false;
            txtTentkDN.Enabled = false;
            txtTenndDN.Text = Laytk.DisPlayName;
            txtTentkDN.Text = Laytk.UserName;
            txtMK.Text = Laytk.PassWord;
            int CN;
            CN = Laytk.Type;
            if (CN == 1)
            { txtChucvu.Text = "User"; }
            else
            { txtChucvu.Text = "Admin"; }
            grBdoimatkhau.Hide();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            grBdoimatkhau.Show();
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
                            else { UCTaiKhoan_Load( sender,e); btnDoiMK.Enabled = false; }
                        }
                        else
                        {
                            MessageBox.Show("Sửa Không thành công!");
                        }
                    }
                }
            }
        }

       

     

        private void pBXemMK_MouseDown(object sender, MouseEventArgs e)
        {
            byte[] data = Convert.FromBase64String(txtMK.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtMK.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        private void pBXemMK_MouseUp(object sender, MouseEventArgs e)
        {
            txtMK.Text = Laytk.PassWord;
        }
    }
}
