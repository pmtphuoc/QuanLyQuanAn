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
namespace QLQA.UCform
{
    
    public partial class UCKho : UserControl
    {
        private bool isThem;
        public UCKho()
        {
            InitializeComponent();
        }
        #region Thuoc_tinh
        private void UCKho_Load(object sender, EventArgs e)
        {
            txtTenDanhMuc.Enabled = false;
            txtTen.Enabled = false;
            btnXacNhan.Visible = false;
            pBXacNhan.Visible = false;
            btnSuaTD.Enabled = true;
            btnXoaTD.Enabled = true;
            btnSuaDM.Enabled = true;
            btnXoaDM.Enabled = true;
            loadmonan();
            loaddanhmuc();
          //  Hienthidanhmuc();
        }
        void Hienthidanhmuc()
        {
            List<DTO_DanhMuc> listCategory = DAO_DanhMuc.Instance.GetListDanhMuc();
            cboDanhMuc.DataSource = listCategory;
            cboDanhMuc.DisplayMember = "name";
            //cbMonAn.ValueMember = "name";
        }
        void loadmonan()
        {
            dgVMonAn.DataSource = BUS_ThucAn.laythucan();
            dgvLoaiNuoc.DataSource = BUS_ThucAn.laynuocuong();

            dgVMonAn.Columns["name"].HeaderText = "Tên Món Ăn";
            dgVMonAn.Columns["name"].Width = 250;

            dgvLoaiNuoc.Columns["name"].HeaderText = "Tên Thức Uống";
            dgvLoaiNuoc.Columns["name"].Width = 250;

            dgVMonAn.Columns["idCategory"].HeaderText = " ";
            dgVMonAn.Columns["idCategory"].Width = 0;
            dgVMonAn.Columns["idCategory"].Visible = false;


            dgvLoaiNuoc.Columns["idCategory"].HeaderText = " ";
            dgvLoaiNuoc.Columns["idCategory"].Width = 0;
            dgvLoaiNuoc.Columns["idCategory"].Visible = false;

            dgVMonAn.Columns["price"].HeaderText = "Giá";
            dgVMonAn.Columns["price"].Width = 100;

            dgvLoaiNuoc.Columns["price"].HeaderText = "Giá";
            dgvLoaiNuoc.Columns["price"].Width = 100;

            dgvLoaiNuoc.Columns["id"].HeaderText = "";
            dgvLoaiNuoc.Columns["id"].Width = 0;
            dgvLoaiNuoc.Columns["id"].Visible = false;
            dgVMonAn.Columns["id"].HeaderText = "";
            dgVMonAn.Columns["id"].Width = 0;
            dgVMonAn.Columns["id"].Visible = false;
        }
        void loaddanhmuc()
        {
            dgvDm.DataSource = DanhMuc_BUS.GetListDanhMuc();

            dgvDm.DataSource = DanhMuc_BUS.GetListDanhMuc();
            dgvDm.Columns["name"].HeaderText = "Tên Danh Mục";
            dgvDm.Columns["name"].Width = 490;
            dgvDm.Columns["id"].HeaderText = " ";
            dgvDm.Columns["id"].Width = 0;
            dgvDm.Columns["id"].Visible = false;
        }
        #endregion
        #region Event_LoadDAtaGV
        private void dgVMonAn_Click(object sender, EventArgs e)
        {
            
            btnSuaTD.Enabled = true;
            btnThemTD.Enabled = true;
            btnXoaTD.Enabled = true;
            Hienthidanhmuc();
            DataGridViewRow dr = dgVMonAn.SelectedRows[0];
            txtID.Text = dr.Cells["ID"].Value.ToString();
            txtTen.Text = dr.Cells["Name"].Value.ToString();
            nbGia.Value = int.Parse(dr.Cells["Price"].Value.ToString());
            if (dgVMonAn.SelectedCells.Count > 0)
            {
                int id = (int)dgVMonAn.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;
                DTO_DanhMuc dm = DAO_DanhMuc.Instance.GetIDDanhMuc(id);
                cboDanhMuc.SelectedItem = dm;
                int index = -1;
                int i = 0;
                foreach (DTO_DanhMuc item in cboDanhMuc.Items)
                {
                    if (item.ID == dm.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cboDanhMuc.SelectedIndex = index;
            }
        }
        private void dgvDm_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDm.SelectedRows[0];
            txtIDDanhMuc.Text = dr.Cells["ID"].Value.ToString();
            txtTenDanhMuc.Text = dr.Cells["Name"].Value.ToString();
            btnXoaDM.Enabled = true;
            btnSuaDM.Enabled = true;
        }
        private void dgvLoaiNuoc_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvLoaiNuoc.SelectedRows[0];
            txtID.Text = dr.Cells["ID"].Value.ToString();
            txtTen.Text = dr.Cells["Name"].Value.ToString();
            nbGia.Value = int.Parse(dr.Cells["Price"].Value.ToString());
            btnXoaTD.Enabled = true;
            btnSuaTD.Enabled = true;
            if (dgvLoaiNuoc.SelectedCells.Count > 0)
            {
                int id = (int)dgvLoaiNuoc.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;
                DTO_DanhMuc dm = DAO_DanhMuc.Instance.GetIDDanhMuc(id);
                cboDanhMuc.SelectedItem = dm;
                int index = -1;
                int i = 0;
                foreach (DTO_DanhMuc item in cboDanhMuc.Items)
                {
                    if (item.ID == dm.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cboDanhMuc.SelectedIndex = index;
            }
        }
        #endregion
        #region Event
        private void txtTenDanhMuc_Click(object sender, EventArgs e)
        {
            btnXoaDM.Enabled = false;
            btnSuaDM.Enabled = false;
        }
        private void txtTen_Click(object sender, EventArgs e)
        {
            Hienthidanhmuc();
            btnSuaTD.Enabled = false;
            btnXoaTD.Enabled = false;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            Hienthidanhmuc();
            string name = txtTen.Text;
            int iddanhmuc = (cboDanhMuc.SelectedItem as DTO_DanhMuc).ID;
            float price = (float)nbGia.Value;
            if (BUS_ThucAn.themMonAn(name, iddanhmuc, price))
            {
                MessageBox.Show("thêm món ăn thành công!");
                loadmonan();
            }
            else
            {
                MessageBox.Show("Thêm Không thành công!");
            }
        }
        private void buttonThemdanhmuc_Click(object sender, EventArgs e)
        {
            
            string name = txtTenDanhMuc.Text;
            if (DanhMuc_BUS.themDanhMuc(name))
            {
                MessageBox.Show("thêm món ăn thành công!");
                loaddanhmuc();
            }
            else
            {
                MessageBox.Show("Thêm Không thành công!");
            }
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            string name = txtTen.Text;
            int iddanhmuc = (cboDanhMuc.SelectedItem as DTO_DanhMuc).ID;
            float price = (float)nbGia.Value;
            int idfood = Convert.ToInt32(txtID.Text);
            if (BUS_ThucAn.suaMonAn(idfood, name, iddanhmuc, price))
            {
                MessageBox.Show("Sửa món ăn thành công!");
                loadmonan();
            }
            else
            {
                MessageBox.Show("Sửa Không thành công!");
            }
        }
        private void buttonsuaDanhmuc_Click(object sender, EventArgs e)
        {
            string name = txtTenDanhMuc.Text;
            int id = Convert.ToInt32(txtIDDanhMuc.Text);
            if (DanhMuc_BUS.suaDanhMuc(id,name))
            {
                MessageBox.Show("Sửa món ăn thành công!");
                loaddanhmuc();
            }
            else
            {
                MessageBox.Show("Sửa Không thành công!");
            }
        }
        private void buttonxoamonan_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            if (BUS_ThucAn.xoaMonAn(id))
            {
                MessageBox.Show("Xóa món ăn thành công!");
                loadmonan();
            }
            else
            {
                MessageBox.Show("Xóa Không thành công!");
            }
        }
        private void buttonxoadanhmuc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDanhMuc.Text);
            if (DanhMuc_BUS.xoaDanhMuc(id))
            {
                MessageBox.Show("Xóa món ăn thành công!");
                loaddanhmuc();
            }
            else
            {
                MessageBox.Show("Xóa Không thành công!");
            }
        }
        private void btnSuaTD_Click(object sender, EventArgs e)
        {
            isThem = false;
            btnXacNhan.Enabled = true;
            string name = txtTen.Text;
            int iddanhmuc = (cboDanhMuc.SelectedItem as DTO_DanhMuc).ID;
            float price = (float)nbGia.Value;
            int idfood = Convert.ToInt32(txtID.Text);
            if (MessageBox.Show("Bạn có muốn sửa món ăn " + txtTen.Text + " không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (BUS_ThucAn.suaMonAn(idfood, name, iddanhmuc, price))
                {
                    MessageBox.Show("Sửa món ăn thành công!");
                    loadmonan();
                }
                else
                {
                    MessageBox.Show("Sửa Không thành công!");
                }
            }
            txtID.Text = "";
            txtTen.Text = "";
            nbGia.Value = 0;
        }
        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            if (MessageBox.Show("Bạn có muốn xóa món ăn" + txtTen.Text + " không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (BUS_ThucAn.xoaMonAn(id))
                {
                    MessageBox.Show("Xóa món ăn thành công!");
                    loadmonan();
                }
                else
                {
                    MessageBox.Show("Xóa Không thành công!");
                }
            }
            txtID.Text = "";
            txtTen.Text = "";
            nbGia.Value = 0;
        }
        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDanhMuc.Text);
            if (MessageBox.Show("Bạn có muốn xóa danh mục " + txtTenDanhMuc.Text + " không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (DanhMuc_BUS.xoaDanhMuc(id))
                {
                    MessageBox.Show("Xóa danh mục thành công!");
                    loaddanhmuc();
                }
                else
                {
                    MessageBox.Show("Xóa Không thành công!");
                }
            }
            txtIDDanhMuc.Text = "";
            txtTenDanhMuc.Text = "";
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                string name = txtTen.Text;
                int iddanhmuc = (cboDanhMuc.SelectedItem as DTO_DanhMuc).ID;
                float price = (float)nbGia.Value;
                //
                if (txtTen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập hết tất cả các thông tin !!!");
                    return;
                }
                if (nbGia.Value.ToString().Length == 1)
                {
                    MessageBox.Show("Vui lòng nhập thông tin giá đầy đủ !!!");
                    return;
                }
                //
                List<DTO_ThucAn> tk = BUS_ThucAn.Timmonan(name);
                List<DTO_ThucAn> tu = BUS_ThucAn.Timthucuong(name);
                if (tk.Count != 0)
                {
                    MessageBox.Show("Tên món ăn đã tồn tại!!!");
                }
                else if (tu.Count !=0)
                { MessageBox.Show("Tên loại nước đã tồn tại!!!"); }
                else if (BUS_ThucAn.themMonAn(name, iddanhmuc, price))
                {
                    MessageBox.Show("thêm món ăn thành công!");
                    btnSuaTD.Enabled = true;
                    btnXoaTD.Enabled = true;
                    loadmonan();
                }
                else
                {
                    MessageBox.Show("Thêm Không thành công!");
                }
                txtID.Text = "";
                txtTen.Text = "";
                nbGia.Value = 0;
            }
            else
            {
                string name = txtTen.Text;
                int iddanhmuc = (cboDanhMuc.SelectedItem as DTO_DanhMuc).ID;
                float price = (float)nbGia.Value;
                int idfood = Convert.ToInt32(txtID.Text);
                if (BUS_ThucAn.suaMonAn(idfood, name, iddanhmuc, price))
                {
                    MessageBox.Show("Sửa món ăn thành công!");
                    loadmonan();
                    btnXacNhan.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa Không thành công!");
                }
               
            }
        }
        private void btnThemDM_Click(object sender, EventArgs e)
        {
            txtTenDanhMuc.Enabled = true;
            txtTenDanhMuc.Focus();
            btnXoaDM.Enabled = false;
            btnSuaDM.Enabled = false;
            isThem = true;
            pBXacNhan.Visible = true;
        } //xac nhan
        private void btnThemTD_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = true;
            txtTen.Focus();
            Hienthidanhmuc();
            btnSuaTD.Enabled = false;
            btnXoaTD.Enabled = false;
            isThem = true;
            btnXacNhan.Visible = true;
        }//xac nhan
        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            isThem = false;
            pBXacNhan.Visible = true;
        }//xac nhan
        private void pBXacNhan_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                if (txtTenDanhMuc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tên danh mục !!!");
                    return;
                }
                string name = txtTenDanhMuc.Text;
                List<DTO_DanhMuc> tk = DanhMuc_BUS.seach(name);
                if (tk.Count != 0)
                {
                    MessageBox.Show("Tên danh mục đã tồn tại!!!");
                }
                else if (DanhMuc_BUS.themDanhMuc(name))
                {
                    MessageBox.Show("thêm danh mục thành công!");
                    btnXoaDM.Enabled = true;
                    btnSuaDM.Enabled = true;
                    loaddanhmuc();
                }
                else
                {
                    MessageBox.Show("Thêm Không thành công!");
                }
                txtIDDanhMuc.Text = "";
                txtTenDanhMuc.Text = "";
            }
            else
            {
                string name = txtTenDanhMuc.Text;
                int id = Convert.ToInt32(txtIDDanhMuc.Text);
                if (MessageBox.Show("Bạn có muốn sửa danh mục  " + txtTenDanhMuc.Text + " không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (DanhMuc_BUS.suaDanhMuc(id, name))
                    {
                        MessageBox.Show("Sửa danh mục thành công!");
                        loaddanhmuc();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không thành công!");
                    }
                }
                txtIDDanhMuc.Text = "";
                txtTenDanhMuc.Text = "";
            }
        }   
        #endregion
        #region Ecent_timkiem
        private void txtTimMonAn_TextChanged(object sender, EventArgs e)
        {
            string name = txtTimMonAn.Text;
            dgVMonAn.DataSource = BUS_ThucAn.Timmonan(name);
        }
        private void txttimDanhMuc_TextChanged(object sender, EventArgs e)
        {
            string name = txttimDanhMuc.Text;
            dgvDm.DataSource = DanhMuc_BUS.seach(name);
        }

        private void txtTimLoaiNuoc_TextChanged(object sender, EventArgs e)
        {
            string name = txtTimLoaiNuoc.Text;
            dgvLoaiNuoc.DataSource = BUS_ThucAn.Timthucuong(name);
        }
        private void txtTimMonAn_Click(object sender, EventArgs e)
        {
            txtTimMonAn.Clear();
        }

        private void txtTimLoaiNuoc_Click(object sender, EventArgs e)
        {
            txtTimLoaiNuoc.Clear();
        }

        private void txttimDanhMuc_Click(object sender, EventArgs e)
        {
            txttimDanhMuc.Clear();
        }






        #endregion

        private void resetform_Click(object sender, EventArgs e)
        {
            UCKho_Load(sender, e);
        }
    }
}
