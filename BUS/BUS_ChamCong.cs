using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
   public class BUS_ChamCong
    {
        SqlConnection connetion = new SqlConnection(@"server=DESKTOP-32URAA1\PHUOC; Database=QuanLYQuanAn;integrated security=true");
        SqlDataAdapter da;
        public DataTable getDS(string sql)
        {
            DataTable table = new DataTable();
            da = new SqlDataAdapter(sql, connetion);
            da.Fill(table);
            return table;
        }
        public DataTable getDSCCNV()
        {
            string query = "Select * from tblChamCongNV";
            return getDS(query);
        }

        //public DataTable getDSCCNV(string maNV)
        //{
        //    string query = "Select * from tblDTO_ChamCong where Ngay='" +maNV + "'";
        //    return db.getDS(query);
        //}
        public string layTenNV(string maNV)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string tenNV = "";
            string query = "Select TenNV from tblNhanVien where MaNV='" + maNV + "'";
            da.SelectCommand = new SqlCommand(query, connetion);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNhanVien");
            DataTable dt = ds.Tables["tblNhanVien"];
            foreach (DataRow row in dt.Rows)
                tenNV = row["TenNV"].ToString();
            return tenNV;
        }
        public string getTenNV(string maNV)
        {
            return layTenNV(maNV);
        }
        public bool kiemtontaiCCNV(string giaTri1, DateTime giaTri2, string giaTri3)
        {
            SqlCommand command ;
            string query = "Select count(*) from tblChamCongNV where MaNV='" + giaTri1 + "' and Ngay='" + giaTri2 + "' and CaLam='" + giaTri3 + "'";
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
        public bool kiemtraCCNV(string maNV, DateTime ngay, string caLam)
        {
            return kiemtontaiCCNV(maNV, ngay, caLam);
        }

        public bool ThemCC(DTO_ChamCong ccnv)
        {
            string[] param = { "@MaNV", "@TenNV", "@CaLam", "@Ngay", "@SoGioLam" };
            object[] values = { ccnv.MaNV, ccnv.TenNV, ccnv.CaLam, ccnv.NgayLam, ccnv.SoGioLam };
            string query = "Insert into tblChamCongNV(MaNV,TenNV,CaLam,Ngay,SoGioLam) values (@MaNV,@TenNV,@CaLam,@Ngay,@SoGioLam)";
            return ExecuteNonQueryPara(query, param, values);
        }

        public bool SuaCC(DTO_ChamCong ccnv)
        {
            string[] param = { "@MaNV", "@CaLam", "@Ngay", "@SoGioLam" };
            object[] values = { ccnv.MaNV, ccnv.CaLam, ccnv.NgayLam, ccnv.SoGioLam };
            string query = "Update tblChamCongNV set SoGioLam=@SoGioLam where MaNV=@MaNV and CaLam=@CaLam and Ngay=@Ngay";
            return ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaCC(DTO_ChamCong ccnv)
        {
            string[] param = { "@MaNV", "@TenNV", "@CaLam", "@Ngay", "@SoGioLam" };
            object[] values = { ccnv.MaNV, ccnv.TenNV, ccnv.CaLam, ccnv.NgayLam, ccnv.SoGioLam };
            string query = "Delete from tblChamCongNV where MaNV=@MaNV and TenNV=@TenNV and CaLam=@CaLam and Ngay=@Ngay";
            return ExecuteNonQueryPara(query, param, values);
        }
        public bool ExecuteNonQueryPara(string query, string[] parameters, object[] value)
        {
            int number = 0;
           
                try
                {
                    if (connetion.State == ConnectionState.Closed)
                    {
                        connetion.Open();


                    }
                    SqlCommand command = new SqlCommand(query, connetion);

                    SqlParameter p;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        p = new SqlParameter(parameters[i], value[i]);
                        command.Parameters.Add(p);
                    }
                    number = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
            if (number > 0)
                return true;
            else
                return false;
        }

    }
}
