using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class Menu_DTO
    {
        public Menu_DTO(int  idfood, string foodName, int count, float price, float totalPrice = 0)
        {
            this.Idfood = idfood;
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu_DTO(DataRow row) // lay list menu show len thong qua hàm
        {
            this.Idfood = (int)row["id"];
            this.FoodName = row["Name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString()); //totalPrice lấy ben query ten dac 
        }
        private int idfood;
        private string foodName;

        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public int Idfood { get => idfood; set => idfood = value; }
    }
}
