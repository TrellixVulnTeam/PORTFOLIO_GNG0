using MESProject.DBConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MESProject.cmdTable
{
    class MssqlCmdTable
    {
        public DataTable DBSelect() // 김완수
        {
            SqlConnection conn = DataSources.getConnection();
            SqlCommand cmd = new SqlCommand("exec proc_SelectWorkorder", conn);
            //SqlCommand cmd = new SqlCommand("exec proc_SelectWorkorder @firstDate @secondDate", conn);
            //cmd.Parameters.AddWithValue("@firstDate", firstDate);
            //cmd.Parameters.AddWithValue("@secondDate", secondDate);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            DataSources.setClose();

            return ds.Tables[0];
        }
        public void DBInsert(string employeeName, DateTime orderDate, DateTime deliveryDate, //김완수
                    string productName, int productionQuantity, string companyName, string remark)
        {
            try
            {
                SqlConnection conn = DataSources.getConnection();

                SqlCommand cmd = new SqlCommand("exec proc_InsertWorkorder @orderDate," +
                                                 "@employeeName, @deliveryDate, @productName, @productionQuantity," +
                                                 "@companyName, @remark", conn);

                cmd.Parameters.AddWithValue("@orderDate", orderDate);
                cmd.Parameters.AddWithValue("@employeeName", employeeName);
                cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
                cmd.Parameters.AddWithValue("@productName", productName);
                cmd.Parameters.AddWithValue("@productionQuantity", productionQuantity);
                cmd.Parameters.AddWithValue("@companyName", companyName);
                cmd.Parameters.AddWithValue("@remark", remark);


                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            finally {
                DataSources.setClose();
            }

        }

        public DataTable doDataTableOrder(DateTime dt1, DateTime dt2, string combotext, string text)  // 이상헌
        {
            DataSet ds = new DataSet();
            SqlConnection conn = DataSources.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("exec SelectCTL @combotext, @boxtext, @t_end, @t_start", conn);
                cmd.Parameters.AddWithValue("@combotext", combotext);
                cmd.Parameters.AddWithValue("@boxtext", text);
                cmd.Parameters.AddWithValue("@t_end", dt2);
                cmd.Parameters.AddWithValue("@t_start", dt1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                return null;
            }
            finally
            {
                DataSources.setClose();
            }
            return ds.Tables[0];
        }
        public DataTable doDataTableResult(DateTime dt1, DateTime dt2, string combotext, string text)  // 이상헌
        {
            DataSet ds = new DataSet();
            SqlConnection conn = DataSources.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("exec SelectResult @combotext, @boxtext, @t_end, @t_start", conn);
                cmd.Parameters.AddWithValue("@combotext", combotext);
                cmd.Parameters.AddWithValue("@boxtext", text);
                cmd.Parameters.AddWithValue("@t_end", dt2);
                cmd.Parameters.AddWithValue("@t_start", dt1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                return null;
            }
            finally
            {
                DataSources.setClose();
            }
            return ds.Tables[0];
        }
    }
}
