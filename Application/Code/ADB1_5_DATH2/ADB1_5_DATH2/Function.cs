using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADB1_5_DATH2
{
    class Function
    {
        public static SqlConnection con;
        public static void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.ADB1_5_DATH2;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                MessageBox.Show("Kết nối thành công!");
            }
            else
            {
                MessageBox.Show("Kết nối không thành công!");
            }
        }
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }
        public static DataTable GenDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            return table;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);

            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.DataSource = table;
        }

        //public static string CoverDataTime(string date)
        //{
        //    string[] elements = date.Split('/');
        //    string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
        //    return dt;
        //}

        //public static string CoverDataTimeMonth(string date)
        //{
        //    string[] elements = date.Split('/');
        //    return elements[0];
        //}

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
        public static string CreateKey(string tiento)
        {
            string key = tiento;

            return key;
        }


        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }
    }
}
