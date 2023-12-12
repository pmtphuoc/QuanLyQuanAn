using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
  public  class DAO_DanhMuc
    {
        private static DAO_DanhMuc instance;

        public static DAO_DanhMuc Instance
        {
            get { if (instance == null) instance = new DAO_DanhMuc(); return DAO_DanhMuc.instance; }
            private set { DAO_DanhMuc.instance = value; }
        }
        public DAO_DanhMuc() { }
        public  List<DTO_DanhMuc> GetListDanhMuc()
        {
            List<DTO_DanhMuc> list = new List<DTO_DanhMuc>();
            string query = "select * from FoodCategory";
            DataTable data = Dataprovider.Instance.ExecuteQuery(query); //datatable lay du lieu ra kakakak
            foreach (DataRow item in data.Rows)
            {
                DTO_DanhMuc DanhMuc = new DTO_DanhMuc(item);
                list.Add(DanhMuc);
            }
            return list;
        }
        public List<DTO_DanhMuc> Seach(string name)
        {
            List<DTO_DanhMuc> list = new List<DTO_DanhMuc>();
            string query = string.Format("select * from FoodCategory where dbo.GetUnsignString(name) like N'%' +dbo.GetUnsignString(N'{0}') +'%' ", name);
            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO_DanhMuc DanhMuc = new DTO_DanhMuc(item);
                list.Add(DanhMuc);
            }
            return list;
        }
        public DTO_DanhMuc GetIDDanhMuc(int id)
        {
            DTO_DanhMuc dm = null;
            string query = "select * from FoodCategory Where id =" + id;
            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                dm = new DTO_DanhMuc(item);
                return dm;
            }
            return dm;
        }
        public bool ThemDanhMuc(string tendanhmuc)
        {
            string query = string.Format("INSERT INTO FoodCategory (name)VALUES(N'{0}')", tendanhmuc);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        public bool SuaDanhMuc(int id, string tendanhmuc)
        {
            string query = string.Format("UPDATE FoodCategory SET name = N'{0}' WHERE id = N'{1}'", tendanhmuc, id);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        public bool XoaDanhMuc(int id)
        {
            DAO_ThongTinHoaDon.Instance.xoaidthongtinhoadon(id);
            DAO_ThucAn.Instance.xoaidthongtinthucan(id);
            string query = string.Format("DELETE from FoodCategory WHERE id = N'{0}'", id);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
    }
}
