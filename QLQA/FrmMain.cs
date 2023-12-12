using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DTO;

namespace QLQA
{
    public partial class FrmMain : Form
    {
        public static FrmMain main;
        private DTO.DTO_TaiKHoan laytk;

        public DTO_TaiKHoan Laytk { get => laytk; set => laytk = value; }

        public FrmMain(DTO_TaiKHoan acc)
        {
            InitializeComponent();
            main = this;
            int quyen;
            this.Laytk = acc;
            labTenUSER.Text = Laytk.DisPlayName;
            quyen = Laytk.Type;
            if (quyen == 0)
            {
                labQuyen.Text = "Admin";
                
            }
            else
            { labQuyen.Text = "User";
                rbNameBanAn.Visible = false;
                rbNameKho.Visible = false;
            }
        }



        // Thêm tab
        private void addNewTab(string strTabName, UserControl ucContent)
        {
           
            foreach (TabItem tabPage in tabMain.Tabs)
                if (tabPage.Text == strTabName)
                {
                    tabMain.SelectedTab = tabPage;
                    return;
                }
           


            TabControlPanel newTabPanel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newTabPage = new TabItem(this.components);
            newTabPage.ImageIndex = 0;
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = "panel" + strTabName;
            newTabPanel.Padding = new System.Windows.Forms.Padding(1);
            newTabPanel.Size = new System.Drawing.Size(1230, 384);
            newTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            newTabPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            newTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newTabPanel.Style.GradientAngle = 90;
            newTabPanel.TabIndex = 2;
            newTabPanel.TabItem = newTabPage;
            //-------------New  tab page---------------------
            Random ran = new Random();
            newTabPage.Name = strTabName + ran.Next(100000) + ran.Next(22342);
            newTabPage.AttachedControl = newTabPanel;
            newTabPage.Text = strTabName;
            ucContent.Dock = DockStyle.Fill;
            newTabPanel.Controls.Add(ucContent);
            //------------add Tab page to Tab control-------------
            tabMain.Controls.Add(newTabPanel);
            tabMain.Tabs.Add(newTabPage);
            tabMain.SelectedTab = newTabPage;
        }
        // Chức năng
        private void btnBanHanng_Click(object sender, EventArgs e)
        {
            UCform.UCBanHang banhang = new UCform.UCBanHang();
            addNewTab("Bán Hàng", banhang);
        }
        public void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất chương trình", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Thoat();
            }
        }

        public void Thoat()
        {
            this.Hide();
            Frm_LOGIN f = new Frm_LOGIN();
            f.ShowDialog();
        }
        private void tabMain_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            tabMain.Tabs.Remove(tabMain.SelectedTab);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            UCform.UCKho kho = new UCform.UCKho();
            addNewTab("Kho", kho);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            UCform.UCDoanhThu thongke = new UCform.UCDoanhThu();
            addNewTab("Thống Kê", thongke);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (labQuyen.Text == "Admin")
            {
                UCform.UCTaiKhoan_Admin taikhoan = new UCform.UCTaiKhoan_Admin(Laytk);
                addNewTab("Tài khoản", taikhoan);
            }
            else
            {
                UCform.UCTaiKhoan_User taikhoanU = new UCform.UCTaiKhoan_User(Laytk);
                addNewTab("Tài khoản", taikhoanU);
            }

        }

        private void btnBanAn_Click(object sender, EventArgs e)
        {
            UCform.UCBanAn banan = new UCform.UCBanAn();
            addNewTab("Bàn Ăn", banan);
        }

        private void rbNameBanHang_ItemClick(object sender, EventArgs e)
        {

        }
    }
}
