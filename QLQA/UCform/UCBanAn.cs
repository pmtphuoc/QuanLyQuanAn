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
using DAO;
using DTO;
namespace QLQA.UCform
{
    public partial class UCBanAn : UserControl
    {
       BUS_ChamCong ccBO = new BUS_ChamCong();
        DAO_ChamCong nvBO = new DAO_ChamCong();
        BUS_BangLuong blBO = new BUS_BangLuong();
        public UCBanAn()
        {
            InitializeComponent();
        }
        #region Thuoc_tinh
        private void UCBanAn_Load(object sender, EventArgs e)
        {

          
            comboCa.Items.Add("Ca Sáng");
            comboCa.Items.Add("Ca Chiều");
            DataTable tableNV = new DataTable();
                tableNV = nvBO.getDSNV();
             comboMaNV.DataSource =tableNV;
            
            comboMaNV.DisplayMember = "MaNV";//UserName
            comboMaNV.ValueMember = "MaNV";
            comboMaNV.SelectedIndex = 0;
            comboCa.SelectedIndex = 0;
            DataTable tableCCNV = new DataTable();
            tableCCNV = ccBO.getDSCCNV();
            tblChamCongNVDataGridView.DataSource = tableCCNV;
            binData();
        }
        
        private DTO_ChamCong getCCNV()
        {

           DTO_ChamCong ccnv = new DTO_ChamCong();
            float i = 0;
            if (txtSoGio.Text == "")
                ccnv.SoGioLam = 0;
            else
            {
                i = float.Parse(txtSoGio.Text);
                ccnv.SoGioLam = 8 - i;
            }
            ccnv.CaLam = comboCa.Text;
            ccnv.MaNV = comboMaNV.SelectedValue.ToString();
            ccnv.NgayLam = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            ccnv.TenNV = txtTenNV.Text;
            return ccnv;
        }

        private DTO_BangLuong getBangLuong()
        {
           
            DTO_BangLuong bl = new DTO_BangLuong();
            int thang = DateTime.Now.Day;
            bl.Thang = thang;
            bl.MaNV = comboMaNV.SelectedValue.ToString();
            bl.TenNV = txtTenNV.Text;
            float mucluong = 0;
            string chucvu = blBO.layChucVu(comboMaNV.SelectedValue.ToString());
            if (chucvu == "Quản Lý")
                mucluong = 12000;
            if (chucvu == "Phục Vụ" || chucvu == "Giữ Xe")
                mucluong = 7000;
            if (chucvu == "Thu Ngân" || chucvu == "Pha Chế")
                mucluong = 10000;
            if (chucvu == "Tạp Vụ")
                mucluong = 8000;
            bl.MucLuong = (float)mucluong;
            float tienluong = 0;
            tienluong = bl.TongGioLam;
            bl.TienLuong = tienluong;
            return bl;
        }
        public void clearBind()
        {
            //txtTenNV.DataBindings.Clear();
            tblChamCongNVDataGridView.DataBindings.Clear();
        }

        public void binData()
        {
            BindingSource bindSourceNV = new BindingSource();
            bindSourceNV.DataSource = ccBO.getDSCCNV();
            clearBind();
            //txtTenNV.DataBindings.Add("Text", bindSourceNV, "TenNV");
            tblChamCongNVDataGridView.DataSource = bindSourceNV;

        }
        #endregion
        #region Event_LoadDateGV
        private void tblChamCongNVDataGridView_Click(object sender, EventArgs e)
        { 
            DataGridViewRow dr =tblChamCongNVDataGridView.SelectedRows[0];
            comboMaNV.Text = dr.Cells["MaNV"].Value.ToString();
          
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
        #endregion
        #region Event_
        private void comboMaNV_Click(object sender, EventArgs e)
        {
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

           


            if (comboMaNV.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !!!!");
                return;
            }
            string ma = comboMaNV.Text;
            string ten = txtTenNV.Text;
            string ca = comboCa.Text;
            DateTime ngay = dateTimePicker1.Value;
         
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
                DTO_ChamCong ccnv = getCCNV();
                DTO_BangLuong bl = getBangLuong();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (ccBO.XoaCC(ccnv))
                    {
                        float soGioLamDaCham = 0;
                        float.TryParse(txtSoGioLam.Text, out soGioLamDaCham);
                        float tgl = 0;
                        string tggiolam = blBO.layGioLam(bl.MaNV, bl.Thang);
                        float.TryParse(tggiolam, out tgl);
                        float giolam = tgl - soGioLamDaCham;
                        bl.TongGioLam = giolam;
                        bl.TienLuong = bl.TongGioLam * bl.MucLuong;
                        blBO.SuaBangLuong(bl);
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                        MessageBox.Show("Không thể xóa");
                    binData();
                }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_ChamCong ccnv = getCCNV();
            DTO_BangLuong bl = getBangLuong();
            ccnv.CaLam = comboCa.Text;
            int thang = DateTime.Now.Day;
            DateTime ngaylam = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            string calam = comboCa.Text;
            string manv = comboMaNV.SelectedValue.ToString();
            if (ccBO.kiemtraCCNV(manv, ngaylam, calam))
            {
                if (ccBO.SuaCC(ccnv))
                {
                    float soGioLamDaCham = 0;
                    float.TryParse(txtSoGio.Text, out soGioLamDaCham);
                    float tgl = 0;
                    string tggiolam = blBO.layGioLam(bl.MaNV, bl.Thang);
                    float.TryParse(tggiolam, out tgl);
                    string sogiotru = txtSoGio.Text;
                    float giotru = 0;
                    float.TryParse(sogiotru, out giotru);
                    float sogiolamdung = 8 - giotru;
                    float giolam = (tgl + sogiolamdung) - soGioLamDaCham;
                    bl.TongGioLam = giolam;
                    bl.TienLuong = bl.TongGioLam * bl.MucLuong;
                    blBO.SuaBangLuong(bl);
                    MessageBox.Show("Sửa thành công");
                }
                else
                    MessageBox.Show("Không thể sửa");
            }
            else
            {
                if (ccBO.ThemCC(ccnv))
                {
                    if (blBO.kiemTraBangLuong(thang, manv) == false)
                        blBO.ThemBangLuong(bl);
                    float giotru = 0;
                    string sogiotru = txtSoGio.Text;
                    float.TryParse(sogiotru, out giotru);
                    float sogiolamdung = 8 - giotru;
                    float tgl = 0;
                    string tggiolam = blBO.layGioLam(bl.MaNV, bl.Thang);
                    float.TryParse(tggiolam, out tgl);
                    float giolam = tgl + sogiolamdung;
                    bl.TongGioLam = giolam;
                    bl.TienLuong = bl.TongGioLam * bl.MucLuong;
                    blBO.SuaBangLuong(bl);
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Không thể thêm");
            }
            binData();


        }
        #endregion
        

        

        
private void tblChamCongNVDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblChamCongNVDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelect = e.RowIndex;
            comboMaNV.Text = tblChamCongNVDataGridView.Rows[rowSelect].Cells[0].Value.ToString();
            txtTenNV.Text = tblChamCongNVDataGridView.Rows[rowSelect].Cells[1].Value.ToString();
            comboCa.Text = tblChamCongNVDataGridView.Rows[rowSelect].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(tblChamCongNVDataGridView.Rows[rowSelect].Cells[3].Value);
            txtSoGio.Text = tblChamCongNVDataGridView.Rows[rowSelect].Cells[4].Value.ToString();
        }

        private void comboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNV.Text = ccBO.getTenNV(comboMaNV.SelectedValue.ToString());
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoGio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
