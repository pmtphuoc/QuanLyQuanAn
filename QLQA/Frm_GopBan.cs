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

namespace QLQA
{
    public partial class Frm_GopBan : Form
    {
        public Frm_GopBan()
        {
            InitializeComponent();
           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            DTO.DTO_BanAn table = cboBanCanGop.SelectedItem as DTO.DTO_BanAn;
            int idBill = DAO.DAO_HoaDon.Instance.GetUncheckBillIDByTableID(table.ID);
            int id1 = (cboBanCanGop.SelectedItem as DTO.DTO_BanAn).ID;
            int id2 = (cboBanGop.SelectedItem as DTO.DTO_BanAn).ID;

            if (cboBanCanGop.Text == cboBanGop.Text)
            { MessageBox.Show("Hai bàn trùng tên không thể gộp"); }
            else if (MessageBox.Show(String.Format("Bạn muốn thật sự chuyển bàn {0} qua bàn {1}", (cboBanCanGop.SelectedItem as DTO.DTO_BanAn).Name, (cboBanGop.SelectedItem as DTO.DTO_BanAn).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DAO.DAO_BanAn.Instance.GopBan(id1, id2);
                UCform.UCBanHang.banhang.UCBanHang_Load(sender, e);
                Frm_GopBan_Load(sender, e);
            }
           
        }

        private void Frm_GopBan_Load(object sender, EventArgs e)
        {
            cboBanCanGop.DataSource = BUS_BanAn.laydsBanCoNguoi();
            cboBanCanGop.DisplayMember = "Name";
            cboBanGop.DataSource = BUS_BanAn.laydsBanCoNguoi();
            cboBanGop.DisplayMember = "Name";
            if (cboBanCanGop.Text == "")
            { buttonX1.Enabled = false;
                cboBanCanGop.Enabled = false;
                cboBanGop.Enabled = false;
            }
            else { buttonX1.Enabled = true;
                cboBanCanGop.Enabled = true;
                cboBanGop.Enabled = true;
            }
        }
    }
}
