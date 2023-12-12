using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_BanAn
    {
        private static BUS_BanAn instance;
        public static BUS_BanAn Instance
        {
            get { if (instance == null) instance = new BUS_BanAn(); return BUS_BanAn.instance; }
            private set { BUS_BanAn.instance = value; }
        }
        public static List<DTO_BanAn> laydsBanAn()
        {
            return DAO_BanAn.LaydsBanAn();
        }
        public static bool thembanan(string name, string status)
        {
            return DAO_BanAn.Instance.ThemBanAn(name, status);
        }
        public static bool suabanan(int id, string name, string status)
        {
            return DAO_BanAn.Instance.SuaBanAn(id,name, status);
        }
        public static bool xoabanan(int id)
        {
            return DAO_BanAn.Instance.XoaBanAn(id);
        }
        public static List<DTO_BanAn> laydsBanCoNguoi()
        {
            return DAO_BanAn.HienBanCoNguoi();
        }
        public static List<DTO_BanAn> laydsBanTrong()
        {
            return DAO_BanAn.HienBanTrong();
        }
        public static List<DTO_BanAn> SeachBanAn(string name)
        {
            return DAO_BanAn.SeachBanAn(name);
        }
    }
}
