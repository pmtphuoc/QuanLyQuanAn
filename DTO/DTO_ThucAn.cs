using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThucAn
    {
        public DTO_ThucAn(int iD, string tenMonAn, int idDanhMuc, float gia)
        {
            this.ID = iD;
            this.Name = tenMonAn;
            this.IdCategory = idDanhMuc;
            this.Price = gia;
        }
        public DTO_ThucAn(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IdCategory = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        private int iD;

      
        private string name;


        private int idCategory;

       
        private float price;

        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }
        public int ID { get => iD; set => iD = value; }
    }

}
