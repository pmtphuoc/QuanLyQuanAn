using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
  public  class BUS_HoaDon
    {
        public static int  GetUncheckBillIDByTableID(int id)
        {
            return DAO_HoaDon.Instance.GetUncheckBillIDByTableID(id);
        }
        public static void InsertBill(int id)
        {
             DAO_HoaDon.Instance.InsertBill(id);
        }
        public static void checkout(int id, int discount,float totalPrice)
        {
            DAO_HoaDon.Instance.checkout(id,discount, totalPrice);
        }

    }
}
