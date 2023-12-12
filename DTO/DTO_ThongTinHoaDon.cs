using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_ThongTinHoaDon
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private int billID;

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }


        private int foodID;

        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }


        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public DTO_ThongTinHoaDon(int ID, int BilliD, int FoodiD, int count)
        {
            this.BillID = BilliD;
            this.Count = count;
            this.FoodID = FoodiD;
            this.ID = iD;
        }
        public DTO_ThongTinHoaDon(DataRow row)
        {
            this.ID = (int)row["id"]; //gt lay theo từng cột 
            this.BillID = (int)row["idBill"];
            this.Count = (int)row["count"];
            this.FoodID = (int)row["idFood"];
        }
    }
}
