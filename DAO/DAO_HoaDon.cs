using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
   public class DAO_HoaDon
    {
        private static DAO_HoaDon instance;

        public static DAO_HoaDon Instance
        {
            get { if (instance == null) instance = new DAO_HoaDon(); return DAO_HoaDon.instance; }
            private set { DAO_HoaDon.instance = value; }
        }
        private DAO_HoaDon() { }

        //trả ra id 
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = Dataprovider.Instance.ExecuteQuery("select * from Bill where idTable = " + id + " and status = 0");
            if (data.Rows.Count > 0)
            {
                DTO_HoaDon bill = new DTO_HoaDon(data.Rows[0]);
                return bill.ID;
            }
            return -1; // nghia la id = -1 k có cái nòa á
        }
        public void InsertBill(int id)
        {
            Dataprovider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return Dataprovider.Instance.ExecuteQuery("exec USP_GetListByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public int GetMAxIdBill()
        {
            try
            {
                return (int)Dataprovider.Instance.ExecuteScalar("select MAX(id) from Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void checkout(int id, int discount,float totalPrice)
        {
            string query = "update dbo.Bill set status = 1 ," + "discount=" + discount + ", " + "totalPrice=" + totalPrice + " where id = " + id;
            Dataprovider.Instance.ExecuteNonQuery(query);
        }
        public void deletebill(int id)
        {
            Dataprovider.Instance.ExecuteNonQuery("exec USP_DeleteBillNull @idTable", new object[] { id });

        }
    }
}
