using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_ChamCong
    {
        SqlDataAdapter da;
        
        SqlConnection connetion = new SqlConnection(@"server=DESKTOP-32URAA1\PHUOC; Database=QuanLyQuanAn;integrated security=true");
        public DataTable getDS(string sql)
        {
            DataTable table = new DataTable();
            da = new SqlDataAdapter(sql, connetion);
            da.Fill(table);
            return table;
        }
        public DataTable getDSNV()
        {
            string query = "Select * from tblNhanVien";
            return getDS(query);
        }

        public DataTable getDSNV(string maNV)
        {
            string query = "Select *from tblNhanVien where MaNV='" + maNV + "'";
            return getDS(query);
        }

    }
}
