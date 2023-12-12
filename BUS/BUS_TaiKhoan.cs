using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_TaiKhoan
    {
        public static List<DTO_TaiKHoan> laydstaikhoan()
        {
            return DAO_TaiKhoan.LaydsTaiKhoan();
        }
        public static bool themtaikhoan(string UserName, string DisplayName, string PassWord, int Type)
        {
            return DAO_TaiKhoan.Instance.ThemTaiKhoan(UserName,DisplayName,PassWord,Type);
        }
        public static bool suataikhoan(string UserName, string DisplayName, string PassWord)
        {
            return DAO_TaiKhoan.Instance.SuaTaiKhoan(UserName, DisplayName, PassWord);
        }
        public static bool xoataikhoan( string username)
        {
            return DAO_TaiKhoan.Instance.XoaTaiKhoan(username);
        }
    }
}
