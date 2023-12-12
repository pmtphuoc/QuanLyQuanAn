using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
   public class DAO_ThucAn
    {
        private static DAO_ThucAn instance;

        public static DAO_ThucAn Instance
        {
            get { if (instance == null) instance = new DAO_ThucAn(); return DAO_ThucAn.instance; }
            private set { DAO_ThucAn.instance = value; }
        }
        public DAO_ThucAn() { }
        public List<DTO_ThucAn> LaydsthucAntuDm(int id)
        {
            List<DTO_ThucAn> list = new List<DTO_ThucAn>();
            string query = "select * from Food where idCategory =" + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO_ThucAn food = new DTO_ThucAn(item);
                list.Add(food);
            }
            return list;
        }
        public List<DTO_ThucAn> LayThucAn()
        {
            List<DTO_ThucAn> list = new List<DTO_ThucAn>();
            string query = "select * from Food where idCategory !=  '5'";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO_ThucAn food = new DTO_ThucAn(item);
                list.Add(food);
            }
            return list;
        }
        public static List<DTO_ThucAn> timkiemmonan(string name)
        {
            List<DTO_ThucAn> list = new List<DTO_ThucAn>();
            string query = string.Format("select * from Food where dbo.GetUnsignString(name) like N'%' +dbo.GetUnsignString(N'{0}') +'%' and idCategory !=  '5' ", name);
            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO_ThucAn food = new DTO_ThucAn(item);
                list.Add(food);
            }
            return list;
        }
        public static List<DTO_ThucAn> timkiemthucuong(string name)
        {
            List<DTO_ThucAn> list = new List<DTO_ThucAn>();
            string query = string.Format("select * from Food where dbo.GetUnsignString(name) like N'%' +dbo.GetUnsignString(N'{0}') +'%' and idCategory =  '5' ",name);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO_ThucAn food = new DTO_ThucAn(item);
                list.Add(food);
            }
            return list;
        }
        public List<DTO_ThucAn> LayNuocUong()
        {
            List<DTO_ThucAn> list = new List<DTO_ThucAn>();
            string query = "select * from Food where idCategory = '5'";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO_ThucAn food = new DTO_ThucAn(item);
                list.Add(food);
            }
            return list;
        }
       
        public bool ThemMonAn(string tenmonan, int iddanhmuc, float gia)
        {
            string query = string.Format("INSERT INTO Food (name,idCategory,price)VALUES(N'{0}','{1}','{2}')", tenmonan,iddanhmuc,gia);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        public bool SuaMonAn(int idfood, string tenmonan, int iddanhmuc, float gia)
        {
            string query = string.Format("UPDATE Food SET name = N'{0}', idCategory = N'{1}', price = N'{2}' WHERE id = N'{3}'", tenmonan, iddanhmuc, gia, idfood);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        public bool XoaMonAn(int idfood)
        {
            DAO_ThongTinHoaDon.Instance.xoaidthongtinhoadon(idfood);
            string query = string.Format("DELETE Food WHERE id = '{0}'", idfood);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        public void xoaidthongtinthucan(int id)
        {
            Dataprovider.Instance.ExecuteNonQuery("DELETE from dbo.Food where idCategory = " + id);
        }

        public List<DTO_ThucAn> Ingia(int id)
        {
           
            List<DTO_ThucAn> list = new List<DTO_ThucAn>();
            string query = "select * from dbo.Food where id = " + id ;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO_ThucAn food = new DTO_ThucAn(item);
                list.Add(food);
            }
            return list;
        }
    }
}
