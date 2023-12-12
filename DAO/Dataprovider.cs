using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class Dataprovider
    {


        private static Dataprovider instance;

        internal static Dataprovider Instance
        {
            get { if (instance == null) instance = new Dataprovider(); return Dataprovider.instance; }
            private set { Dataprovider.instance = value; } // cho private ln de bao mat hơn
        }
        private Dataprovider() { }
        private string connetionSTR = @"Data Source=.\PHUOC;Initial Catalog=QuanLyQuanAn;Integrated Security=True";
        
        public DataTable ExecuteQuery(String query, object[] parameter = null)//parameter chu yeu la theo n proc 
        {
            DataTable data = new DataTable();

            using (SqlConnection connetion = new SqlConnection(connetionSTR))
            {
                connetion.Open();
                SqlCommand command = new SqlCommand(query, connetion);
                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connetion.Close();
            }
            return data;

        }
        public int ExecuteNonQuery(String query, object[] parameter = null)//tra ve so dong thanh cong int
        {
            int data = 0; //cho o dòng thanh công

            using (SqlConnection connetion = new SqlConnection(connetionSTR))
            {
                connetion.Open();
                SqlCommand command = new SqlCommand(query, connetion);
                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();

                connetion.Close();
            }
            return data;

        }
        public object ExecuteScalar(String query, object[] parameter = null)//trả về object trả ve cai cot dau tien cua ba ket qua
        {
            object data = 0;

            using (SqlConnection connetion = new SqlConnection(connetionSTR))
            {
                connetion.Open();
                SqlCommand command = new SqlCommand(query, connetion);
                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connetion.Close();
            }
            return data;

        }
        

        
        


    }
}
