using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
   public class ThongTinHoaDon_BUS
    {
        public static void InsertBillInfo(int id, int idFood, int count)
        {
            DAO_ThongTinHoaDon.Instance.InsertBillInFo(id , idFood, count);
        }
    }
}
