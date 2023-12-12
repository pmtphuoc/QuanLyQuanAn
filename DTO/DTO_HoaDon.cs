using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
  public  class DTO_HoaDon
    {
        private int discount;
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }


        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Discount { get => discount; set => discount = value; }

        public DTO_HoaDon(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount = 0)
        {
            this.ID = id;
            this.Status = status;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Discount = discount;
        }
        public DTO_HoaDon(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            var dateChekOutTemp = row["DateCheckOut"];
            if (dateChekOutTemp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)dateChekOutTemp;
            }
            this.Status = (int)row["status"];
            if (row["discount"].ToString() == "")

                this.Discount = (int)row["discount"];
        }

    }
}
