using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAO_BanAn
    {
        private static DAO_BanAn instance;

        public static DAO_BanAn Instance
        {
            get { if (instance == null) instance = new DAO_BanAn(); return DAO_BanAn.instance; }
            private set { DAO_BanAn.instance = value; }
        }

        public static int Tablewith = 100;
        public static int Tableheight = 100;
        private DAO_BanAn() { }
        public void ChuyenBan(int id1, int id2)
        {
            Dataprovider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        public void GopBan(int id1, int id2)
        {
            Dataprovider.Instance.ExecuteQuery("USP_Puttables @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        public static List<DTO_BanAn> LaydsBanAn()
        {
            List<DTO_BanAn> tablelist = new List<DTO_BanAn>();
            DataTable data = Dataprovider.Instance.ExecuteQuery("select* from dbo.tablefood");
            foreach (DataRow item in data.Rows)
            {
                DTO_BanAn table = new DTO_BanAn(item);
                tablelist.Add(table);

            }
            return tablelist;
        }
        public static List<DTO_BanAn> SeachBanAn(string name)
        {
            List<DTO_BanAn> tablelist = new List<DTO_BanAn>();
            string query = string.Format("select* from dbo.tablefood where dbo.GetUnsignString(name) like N'%' +dbo.GetUnsignString(N'{0}') +'%' ", name);
            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO_BanAn table = new DTO_BanAn(item);
                tablelist.Add(table);

            }
            return tablelist;
        }
        public bool ThemBanAn(string name, string status)
        {
            string query = string.Format("INSERT INTO tablefood (name,status)VALUES(N'{0}',N'{1}')", name, status);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        public bool SuaBanAn(int id,string name, string status)
        {
            string query = string.Format("UPDATE tablefood SET name =N'{0}',status =N'{1}' WHERE id = N'{2}'", name, status,id);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        public bool XoaBanAn(int id)
        {
            string query = string.Format("DELETE from tablefood WHERE id = N'{0}'",id);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        public static List<DTO_BanAn> HienBanTrong()
        {
            List<DTO_BanAn> tablelist = new List<DTO_BanAn>();
            DataTable data = Dataprovider.Instance.ExecuteQuery("USP_LayBanTrong");
            foreach (DataRow item in data.Rows)
            {
                DTO_BanAn table = new DTO_BanAn(item);
                tablelist.Add(table);

            }

            return tablelist;
        }
        public static List<DTO_BanAn> HienBanCoNguoi()
        {
            List<DTO_BanAn> tablelist = new List<DTO_BanAn>();
            DataTable data = Dataprovider.Instance.ExecuteQuery("USP_LayBanCoNguoi");
            foreach (DataRow item in data.Rows)
            {
                DTO_BanAn table = new DTO_BanAn(item);
                tablelist.Add(table);

            }

            return tablelist;
        }

    }
}
