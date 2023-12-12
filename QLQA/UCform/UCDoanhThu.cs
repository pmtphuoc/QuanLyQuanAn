using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using DAO;
namespace QLQA.UCform
{
    public partial class UCDoanhThu : UserControl
    {
        public UCDoanhThu()
        {
            InitializeComponent();
            LoadDateTimepickerBill();
            LoadlistBillByDate(dateTimePickercheckIn.Value, dateTimePickercheckOut.Value);
        }
        void LoadDateTimepickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePickercheckIn.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickercheckOut.Value = dateTimePickercheckIn.Value.AddMonths(1).AddDays(-1);
        }
        private void panelEx1_Click(object sender, EventArgs e)
        {       }
        void LoadlistBillByDate(DateTime checIn, DateTime checOut)
        {
           
        }

        private DataSet hienthidata(SqlParameter[] sqlParameter)
        {
            string chuoi = @"Data Source=.\PHUOC;Initial Catalog=QuanLyQuanAn;Integrated Security=True";
            SqlConnection sql = new SqlConnection(chuoi);
            sql.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetListByDate", sql);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            { throw ex; }
            finally {sql.Close(); }


        }

        private void hienthi(DateTime checkin, DateTime checkout)
        {
            SqlParameter[] parameter = new SqlParameter[2];
            dateTimePickercheckIn.Value = checkin;
            dateTimePickercheckOut.Value = checkout;
            parameter[0] = new SqlParameter("@checkIn", dateTimePickercheckIn.Value);
            parameter[1] = new SqlParameter("@checkOut", dateTimePickercheckOut.Value);


            ReportDataSource rps = new ReportDataSource("DataSet1", hienthidata(parameter).Tables[0]);
            this.reportdoanhthu.LocalReport.DataSources.Clear();
            this.reportdoanhthu.LocalReport.DataSources.Add(rps);
            this.reportdoanhthu.LocalReport.Refresh();
            this.reportdoanhthu.RefreshReport();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            hienthi(dateTimePickercheckIn.Value, dateTimePickercheckOut.Value);
        }
    }
}
