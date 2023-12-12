using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
   public class BUS_Menu
    {
        public static List<Menu_DTO> GetListMenuByTable(int id)
        {
            return DAO_Menu.Instance.GetListMenuByTable(id);
        }
    }
}
