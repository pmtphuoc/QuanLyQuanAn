using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;
namespace QLQA
{
    public partial class Frm_ChuyenBan : Form
    {
        public Frm_ChuyenBan()
        {
            InitializeComponent();

        }

        private void Frm_ChuyenBan_Load(object sender, EventArgs e)
        {
            danhsachban();
            UCform.UCBanHang.banhang.UCBanHang_Load(sender, e);
            if (cboBanCanChuyen.Text == "")
            { btnXacNhanChuyenBan.Enabled = false; }
        }
        void danhsachban()
        {

            cboBanCanChuyen.DataSource = BUS_BanAn.laydsBanCoNguoi();
            cboBanCanChuyen.DisplayMember = "Name";
            cboBanChuyen.DataSource = BUS_BanAn.laydsBanTrong();
            cboBanChuyen.DisplayMember = "Name";
        }

        private void btnXacNhanChuyenBan_Click(object sender, EventArgs e)
        {
            
            DTO_BanAn table = cboBanCanChuyen.SelectedItem as DTO_BanAn;
            int idBill = DAO_HoaDon.Instance.GetUncheckBillIDByTableID(table.ID);
            int id1 = (cboBanCanChuyen.SelectedItem as DTO.DTO_BanAn).ID;
            int id2 = (cboBanChuyen.SelectedItem as DTO.DTO_BanAn).ID;
            if (MessageBox.Show(String.Format("Bạn muốn thật sự chuyển bàn {0} qua bàn {1}", (cboBanCanChuyen.SelectedItem as DTO.DTO_BanAn).Name, (cboBanChuyen.SelectedItem as DTO.DTO_BanAn).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                DAO.DAO_BanAn.Instance.ChuyenBan(id1, id2);
                
                UCform.UCBanHang.banhang.UCBanHang_Load(sender, e);
                Frm_ChuyenBan_Load(sender, e);
            }
        }

        private void Frm_ChuyenBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

    }
}
