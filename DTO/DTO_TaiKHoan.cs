using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKHoan
    {
        public DTO_TaiKHoan(string username, string displayname, string password, int type)
        {
            this.UserName = username;
            this.DisPlayName = displayname;
            this.PassWord = password;
            this.Type = type;
        }
        public DTO_TaiKHoan(DataRow row)
        {
            this.UserName = row["UserName"].ToString(); 
            this.DisPlayName = row["DisPlayName"].ToString();
            this.PassWord = row["PassWord"].ToString();
            this.Type = (int)row["Type"];
        }
       
        private string userName;
        private string disPlayName;
        private string passWord;
        private int type;

        public int Type { get => type; set => type = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string DisPlayName { get => disPlayName; set => disPlayName = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
