using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_ThucAn
    {
        public static List<DTO_ThucAn> laythucan()
        {
            return DAO_ThucAn.Instance.LayThucAn();
        }
        public static List<DTO_ThucAn> laynuocuong()
        {
            return DAO_ThucAn.Instance.LayNuocUong();
        }
        public static bool themMonAn(string tenmonan, int iddanhmuc, float gia)
        {
            return DAO_ThucAn.Instance.ThemMonAn(tenmonan, iddanhmuc, gia);
        }
        public static bool suaMonAn(int idfood, string tenmonan, int iddanhmuc, float gia)
        {
            return DAO_ThucAn.Instance.SuaMonAn(idfood, tenmonan, iddanhmuc, gia);
        }
        public static bool xoaMonAn(int id)
        {
            return DAO_ThucAn.Instance.XoaMonAn(id);
        }
        public static List<DTO_ThucAn> DSmonAntuDM(int id)
        {
            return DAO_ThucAn.Instance.LaydsthucAntuDm(id);
        }
        public static List<DTO_ThucAn> ingiamon(int name)
        {
            return DAO_ThucAn.Instance.Ingia(name);
        }
        public static List<DTO_ThucAn> Timmonan(string name)
        {
            return DAO_ThucAn.timkiemmonan(name);
        }
        public static List<DTO_ThucAn> Timthucuong(string name)
        {
            return DAO_ThucAn.timkiemthucuong(name);
        }
    }
}
