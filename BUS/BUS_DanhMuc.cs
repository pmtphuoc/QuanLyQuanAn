using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
   public class DanhMuc_BUS
    {
        public static List<DTO_DanhMuc> GetListDanhMuc()
        {
            return DAO_DanhMuc.Instance.GetListDanhMuc();
        }
       public static bool themDanhMuc(string tendanhmuc)
        {
            return DAO_DanhMuc.Instance.ThemDanhMuc(tendanhmuc);
        }
        public static bool suaDanhMuc(int id, string tendanhmuc)
        {
            return DAO_DanhMuc.Instance.SuaDanhMuc(id,tendanhmuc);
        }
        public static bool xoaDanhMuc(int id)
        {
            return DAO_DanhMuc.Instance.XoaDanhMuc(id);
        }
        public static List<DTO_DanhMuc> seach(string name)
        {
            return DAO_DanhMuc.Instance.Seach(name);
        }
    }
}
