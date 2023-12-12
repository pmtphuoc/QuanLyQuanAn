using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
  public  class DAO_ThongTinHoaDon
    {
        private static DAO_ThongTinHoaDon instance;

        public static DAO_ThongTinHoaDon Instance
        {
            get { if (instance == null) instance = new DAO_ThongTinHoaDon(); return DAO_ThongTinHoaDon.instance; }
            private set { DAO_ThongTinHoaDon.instance = value; }
        }
        private DAO_ThongTinHoaDon() { }
        public void xoaidthongtinhoadon(int id)
        {
            Dataprovider.Instance.ExecuteQuery("DELETE from dbo.BillInfo where idFood = " + id);
        }
        public List<DTO_ThongTinHoaDon> GetListBillInFo(int id) // id cua bill 
        {
            List<DTO_ThongTinHoaDon> ListBillinfo = new List<DTO_ThongTinHoaDon>();
            DataTable data = Dataprovider.Instance.ExecuteQuery("select * from dbo.BillInfo where idBill = " + id);
            foreach (DataRow item in data.Rows)
            {
                DTO_ThongTinHoaDon info = new DTO_ThongTinHoaDon(item);
                ListBillinfo.Add(info);
            }
            return ListBillinfo;
        }
        public void InsertBillInFo(int idBill, int idFood, int count) // insert billinfo
        {
            Dataprovider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
    }
}
