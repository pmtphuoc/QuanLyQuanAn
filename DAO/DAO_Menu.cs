using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
  public  class DAO_Menu
    {
        private static DAO_Menu instance;

        public static DAO_Menu Instance
        {
            get { if (instance == null) instance = new DAO_Menu(); return DAO_Menu.instance; }
            private set { DAO_Menu.instance = value; }
        }
        private DAO_Menu() { }

        public List<Menu_DTO> GetListMenuByTable(int id)
        {
            List<Menu_DTO> ListMenu = new List<Menu_DTO>();
            string query = "select f.id, f.name, bi.count, f.price, f.price*bi.count AS totalPrice from Bill AS b, BillInfo AS bi, Food AS f where bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable =" + id;
            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu_DTO menu = new Menu_DTO(item);
                ListMenu.Add(menu);
            }
            return ListMenu;
        }
       

    }
}
