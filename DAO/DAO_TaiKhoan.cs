using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Security.Cryptography;

namespace DAO
{
    public class DAO_TaiKhoan
    {
        private static DAO_TaiKhoan instance;

        public static DAO_TaiKhoan Instance
        {
            get { if (instance == null) instance = new DAO_TaiKhoan(); return DAO_TaiKhoan.instance; }
            private set { DAO_TaiKhoan.instance = value; }
        }
        private DAO_TaiKhoan() { }
        public static List<DTO_TaiKHoan> LaydsTaiKhoan()
        {
            List<DTO_TaiKHoan> tablelist = new List<DTO_TaiKHoan>();
            DataTable data = Dataprovider.Instance.ExecuteQuery("select* from dbo.Account");
            foreach (DataRow item in data.Rows)
            {
                DTO_TaiKHoan table = new DTO_TaiKHoan(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public static DTO_TaiKHoan GetType(int id)
        {
            DTO_TaiKHoan dm = null;
            string query = "select * from Account Where Type =" + id;
            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                dm = new DTO_TaiKHoan(item);
                return dm;
            }
            return dm;
        }
        public bool ThemTaiKhoan(string UserName, string DisplayName, string PassWord, int Type)
        {
            string query = string.Format("INSERT INTO Account (UserName,DisplayName,PassWord,Type)VALUES(N'{0}',N'{1}',N'{2}','{3}')", UserName, DisplayName, PassWord, Type);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        public bool SuaTaiKhoan(string UserName, string DisplayName, string PassWord)
        {
            string query = string.Format("UPDATE Account SET DisplayName =N'{1}', PassWord =N'{2}' WHERE UserName =N'{0}'", UserName, DisplayName, PassWord);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        public bool XoaTaiKhoan(string username)
        {
            string query = string.Format("DELETE from Account WHERE UserName = N'{0}'", username);
            int ketqua = Dataprovider.Instance.ExecuteNonQuery(query);
            return ketqua > 0;
        }
        string hash = "f0xle@rn";
        public bool danghap(string username, string password)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                     password = Convert.ToBase64String(results, 0, results.Length);

                }
            }

                    string query = "SELECT *  FROM dbo.Account where UserName = N'" + username + "' and PassWord = N'" + password + "' ";
            DataTable xetdangnhap = Dataprovider.Instance.ExecuteQuery(query);
            return xetdangnhap.Rows.Count > 0;
        }

        public DTO_TaiKHoan laythongtinTK(string username)
        {
            DataTable data = Dataprovider.Instance.ExecuteQuery("select * from Account where UserName = '" + username + "'");
            foreach (DataRow item in data.Rows)
            {
                return new DTO_TaiKHoan(item);
            }
            return null;
        }

    }
}
