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
using DAO;
using System.Globalization;
using System.Drawing.Printing;

namespace QLQA.UCform
{
    public partial class UCBanHang : UserControl
    {
        public UCBanHang()
        {
            InitializeComponent();
            Loadtable();
            Hienthidanhmuc();
            banhang = this;

        }
        public void Loadtable()
        {
            FLPBanAn.Controls.Clear();
            List<DTO_BanAn> tablelist = BUS_BanAn.laydsBanAn();
            foreach (DTO_BanAn item in tablelist)
            {
                Button btn = new Button()
                {
                    Width = DAO_BanAn.Tablewith,
                    Height = DAO_BanAn.Tableheight
                };
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "TRỐNG":

                        btn.ImageList = imgList;
                        btn.ImageIndex = 0;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.FromArgb(244, 247, 252);
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Text = item.Name + Environment.NewLine;
                        break;
                    default:
                        btn.ImageList = imgList;
                        btn.ImageIndex = 1;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.FromArgb(244, 247, 252);
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Text = item.Name + Environment.NewLine;
                        break;
                }

                FLPBanAn.Controls.Add(btn);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {

            int tableID = ((sender as Button).Tag as DTO_BanAn).ID;
            string status = ((sender as Button).Tag as DTO_BanAn).Status;
            this.tabControl1.SelectedTabIndex = 0;
            lsvBill.Tag = (sender as Button).Tag;
            showBill(tableID);
            gdvxetcolum(tableID);
            ShowBillInCBO(tableID);
            if (status != "TRỐNG")
            {
                tabxoamon.Visible = true;
            }
            else
                tabxoamon.Visible = false;

        }
        private void ShowBillInCBO(int id)
        {
            cboDanhSachMon.DataSource = BUS_Menu.GetListMenuByTable(id);
            cboDanhSachMon.DisplayMember = "FoodName";
        }
        void showBill(int id)
        {

            lsvBill.Items.Clear();
            List<DTO.Menu_DTO> ListBillinfo = BUS_Menu.GetListMenuByTable(id);
            float totalPrice = 0; //goi totalPrice de lay show tong tien
            foreach (DTO.Menu_DTO item in ListBillinfo)
            {
                ListViewItem lsvitem = new ListViewItem(item.FoodName.ToString());
                lsvitem.SubItems.Add(item.Count.ToString());
                lsvitem.SubItems.Add(item.Price.ToString());
                lsvitem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice; // dinh nghi totalPrice
                lsvBill.Items.Add(lsvitem);
            }
            CultureInfo cultrue = new CultureInfo("vi-VN");

            labTien.Text = totalPrice.ToString("c", cultrue);

        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            Frm_ChuyenBan chuyenban = new Frm_ChuyenBan();
            chuyenban.ShowDialog();
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            Frm_GopBan gopban = new Frm_GopBan();
            gopban.ShowDialog();
        }
        void LoadFoodListByCategory(int id)
        {
            List<DTO_ThucAn> listFood = BUS_ThucAn.DSmonAntuDM(id);
            cbMonAn.DataSource = listFood;
            cbMonAn.DisplayMember = "name";
        }
        void Hienthidanhmuc()
        {
            List<DTO_DanhMuc> listCategory = DAO_DanhMuc.Instance.GetListDanhMuc();
            cbDanhMuc.DataSource = listCategory;
            cbDanhMuc.DisplayMember = "name";


        }
        public static UCBanHang banhang;
        internal void UCBanHang_Load(object sender, EventArgs e)
        {
            
            cbogia.Enabled = false;
            this.tabxoamon.Visible = false;
            this.tabControl1.SelectedTabIndex = 0;
            Loadtable();

        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_BanAn table = lsvBill.Tag as DTO_BanAn;
                int idBill = DAO_HoaDon.Instance.GetUncheckBillIDByTableID(table.ID);
                int discount = (int)numGiamGIa.Value;
                float totalPrice = float.Parse(labTien.Text.Split(',')[0]);
                float finalprice = totalPrice - (totalPrice / 100) * discount;
                if (idBill != -1)
                {
                    if (MessageBox.Show(String.Format("Bạn có muốn thanh toán hóa đơn cho bàn {0}\nTổng tiền: {1}\nTổng tiền sau khi giảm {2}% = {3} VNĐ", table.Name, totalPrice, discount, finalprice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {

                        BUS_HoaDon.checkout(idBill, discount, finalprice);
                       
                        showBill(table.ID);
                        Loadtable();
                        UCBanHang_Load(sender, e);
                        numGiamGIa.Value = 0;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Bạn chưa chọn bàn cần thanh toán", "Thông báo"); }
        }


        private void cbDanhMuc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            DTO_DanhMuc selected = cb.SelectedItem as DTO_DanhMuc;
            id = selected.ID;
            LoadFoodListByCategory(id);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            try
            {

                {
                    DTO_BanAn table = lsvBill.Tag as DTO_BanAn;
                    int idBill = BUS_HoaDon.GetUncheckBillIDByTableID(table.ID);
                    int foodID = (cbMonAn.SelectedItem as DTO_ThucAn).ID;
                    int count = (int)numSoLuong.Value;

                    if (idBill == -1)
                    {
                        BUS_HoaDon.InsertBill(table.ID);
                        ThongTinHoaDon_BUS.InsertBillInfo(DAO_HoaDon.Instance.GetMAxIdBill(), foodID, count);


                    }
                    else
                    {
                        
                        
                        ThongTinHoaDon_BUS.InsertBillInfo(idBill, foodID, count);
                    }
                    showBill(table.ID);
                    Loadtable();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn bàn", "Thông báo");
            }
        }

        void gdvxetcolum(int id)
        {
            dgvxetcolum.DataSource = BUS_Menu.GetListMenuByTable(id);

        }
        private void btnXoaMon_Click_1(object sender, EventArgs e)
        {
            DTO_BanAn table = lsvBill.Tag as DTO_BanAn;
            int idBill = BUS_HoaDon.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cboDanhSachMon.SelectedItem as Menu_DTO).Idfood;
            int count = (int)numxoamon.Value;

            ThongTinHoaDon_BUS.InsertBillInfo(idBill, foodID, count);

            ShowBillInCBO(table.ID);
            showBill(table.ID);
            Loadtable();
            gdvxetcolum(table.ID);
            if (dgvxetcolum.Rows.Count == 0)
            {

                DAO_HoaDon.Instance.deletebill(table.ID);
                ShowBillInCBO(table.ID);
                showBill(table.ID);
                Loadtable();
            }
            else
            {


            }
        }

        private void cbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            DTO_ThucAn selected = cb.SelectedItem as DTO_ThucAn;
            id = selected.ID;
            giamon(id);
        }
        void giamon(int id)
        {
            List<DTO_ThucAn> listFood = BUS_ThucAn.ingiamon(id);
            cbogia.DataSource = listFood;

            float totalPrice = 0; //goi totalPrice de lay show tong tien
            foreach (DTO.DTO_ThucAn item in listFood)
            {

                totalPrice = item.Price; // dinh nghi totalPrice

            }
            CultureInfo cultrue = new CultureInfo("vi-VN");

            cbogia.Text = totalPrice.ToString("c", cultrue);


        }

        private void cbMonAn_Click(object sender, EventArgs e)
        {
            this.cbMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void cbDanhMuc_Click(object sender, EventArgs e)
        {
            this.cboDanhSachMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
    }
}
