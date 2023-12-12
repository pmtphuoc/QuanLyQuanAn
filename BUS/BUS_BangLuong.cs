using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    
    public class BUS_BangLuong
    {
        BUS_ChamCong db =new BUS_ChamCong();
        SqlDataAdapter da;
        SqlCommand command ;
        SqlConnection connetion = new SqlConnection(@"server=DESKTOP-32URAA1\PHUOC; Database=QuanLyQuanAn;integrated security=true");
        public string layChucVu(string maNV)
        {
           
            string chucvu = "";
            string query = "Select ChucVu from tblNhanVien where MaNV='" + maNV + "'";
            da.SelectCommand = new SqlCommand(query, connetion);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNhanVien");
            DataTable dt = ds.Tables["tblNhanVien"];
            foreach (DataRow row in dt.Rows)
                chucvu = row["ChucVu"].ToString();
            return chucvu;
        }
        public bool kiemTraBangLuong(int thang, string maNV)
        {
            string query = "Select count (*) from tblBangLuong where Thang='" + thang + "' and MaNV='" + maNV + "'";
            command = new SqlCommand(query, connetion);
            int number = 0;
            try
            {
                if (connetion.State == ConnectionState.Closed)
                {
                    connetion.Open();
                }
                number = (int)command.ExecuteScalar();
                connetion.Close();
            }
            catch (Exception ex)
            {
               
            }
            if (number > 0)
                return true;
            else
                return false;
        }
        public string layGioLam(string maNV, int thang)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string sgl = "";
            string query = "Select TongGioLam from tblBangLuong where MaNV='" + maNV + "' and Thang='" + thang + "'";
            da.SelectCommand = new SqlCommand(query, connetion);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblBangLuong");
            DataTable dt = ds.Tables["tblBangLuong"];
            foreach (DataRow row in dt.Rows)
                sgl = row["TongGioLam"].ToString();
            return sgl;
        }
        public bool ThemBangLuong(DTO_BangLuong bl)
        {
            string[] param = { "@Thang", "@MaNV", "@TenNV", "@TongGioLam", "@MucLuong", "@TienLuong" };
            object[] values = { bl.Thang, bl.MaNV, bl.TenNV, bl.TongGioLam, bl.MucLuong, bl.TienLuong };
            string query = "Insert into tblBangLuong(Thang,MaNV,TenNV,TongGioLam,MucLuong,TienLuong) values(@Thang,@MaNV,@TenNV,@TongGioLam,@MucLuong,@TienLuong)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool SuaBangLuong(DTO_BangLuong bl)
        {
            string[] param = { "@Thang", "@MaNV", "@TongGioLam", "@TienLuong" };
            object[] values = { bl.Thang, bl.MaNV, bl.TongGioLam, bl.TienLuong };
            string query = "Update tblBangLuong set TongGioLam=@TongGioLam,TienLuong=@TienLuong where Thang=@Thang and MaNV=@MaNV";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
