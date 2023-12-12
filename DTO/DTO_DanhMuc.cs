﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class DTO_DanhMuc
    {
        public DTO_DanhMuc(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public DTO_DanhMuc(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
