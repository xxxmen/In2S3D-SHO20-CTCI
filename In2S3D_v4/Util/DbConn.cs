using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace Util.DbConn
{
    /*
    static class dbTask
    {

    }
    */
    static class SqlTsk
    {
        //private static string sqlConnStr = @"Server=I1528\MSSQLSERVER2008;database=InstrumentS3D;User Id=sa;Password=ctciinst;";
        //private static string _SqlConnStr = @"Server=INC413\SQLEXPRESS;database=InstrumentS3D;Integrated Security=SSPI;";
        private static string _SqlConnStr = @"Server=INC413\SQLEXPRESS;database=InstrumentS3D2;Integrated Security=SSPI;";


        /* constructor
        sqlTsk() 
        {
            sqlConnStr = @"Server=I1528\MSSQLSERVER2008;database=InstrumentS3D;User Id=sa;Password=ctciinst;";
        }
        */
        public static string SqlConnStr
        {
            get { return _SqlConnStr; }
            set { _SqlConnStr = value; }
        }

        public static void Upload(this System.Data.DataTable dt, string tableName)
        {

            string query = "SELECT * from " + tableName;


            using (SqlConnection conn = new SqlConnection(SqlConnStr))
            {
                using (SqlDataAdapter oda = new SqlDataAdapter())
                {
                    using (SqlCommandBuilder bu = new SqlCommandBuilder())
                    {
                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
                        {
                            oda.SelectCommand = new SqlCommand(query, conn);
                            bulkcopy.DestinationTableName = "dbo." + tableName;
                            DataTable dtsql = new DataTable();
                            oda.Fill(dtsql);
                            List<DataRow> lst_temp = dt.AsEnumerable().ToList();
                            foreach (DataRow row in lst_temp)
                            {
                                dtsql.ImportRow(row);
                            }
                            conn.Open();

                            bulkcopy.WriteToServer(dtsql);
                            conn.Close();
                        }
                    }
                }
            }

        }

        public static void Upload2(this System.Data.DataTable dt, string tableName)
        {

            string query = "SELECT * from " + tableName;
            string delQuery = "delete from " + tableName;



            using (SqlConnection conn = new SqlConnection(SqlConnStr))
            {
                using (SqlDataAdapter oda = new SqlDataAdapter())
                {
                    using (SqlCommandBuilder bu = new SqlCommandBuilder())
                    {
                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
                        {
                            var cmd2 = conn.CreateCommand();
                            cmd2.CommandText = delQuery;


                            oda.SelectCommand = new SqlCommand(query, conn);
                            bulkcopy.DestinationTableName = "dbo." + tableName;
                            DataTable dtsql = new DataTable();
                            oda.Fill(dtsql);
                            List<DataRow> lst_temp = dt.AsEnumerable().ToList();
                            foreach (DataRow row in lst_temp)
                            {
                                dtsql.ImportRow(row);
                            }
                            conn.Open();
                            var result = cmd2.ExecuteNonQuery();
                            bulkcopy.WriteToServer(dtsql);
                            conn.Close();
                        }
                    }
                }
            }

        }

        public static void Upload3(this System.Data.DataTable dt, string tableName)
        {

            string query = "SELECT * from " + tableName;
            string delQuery = "delete from " + tableName;



            using (SqlConnection conn = new SqlConnection(SqlConnStr))
            {
                using (SqlDataAdapter oda = new SqlDataAdapter())
                {
                    using (SqlCommandBuilder bu = new SqlCommandBuilder())
                    {
                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
                        {
                            var cmd2 = conn.CreateCommand();
                            cmd2.CommandText = delQuery;
                            conn.Open();
                            var result = cmd2.ExecuteNonQuery();
                            conn.Close();

                            oda.SelectCommand = new SqlCommand(query, conn);
                            bulkcopy.DestinationTableName = "dbo." + tableName;
                            DataTable dtsql = new DataTable();
                            oda.Fill(dtsql);
                            List<DataRow> lst_temp = dt.AsEnumerable().ToList();
                            foreach (DataRow row in lst_temp)
                            {
                                dtsql.ImportRow(row);
                            }
                            conn.Open();
                            bulkcopy.WriteToServer(dtsql);
                            conn.Close();
                        }
                    }
                }
            }

        }

        public static DataTable delNull(this System.Data.DataTable dt)
        {
            foreach (DataRow item in dt.Rows)
            {
                if (item[0] == DBNull.Value) item.Delete();
            }
            return dt;
        }

        public static DataTable GetTable(string procName)
        {
            string procQuery = "exec " + procName;
            DataTable dtsql = new DataTable();
            using (SqlConnection conn = new SqlConnection(SqlConnStr))
            {
                using (SqlCommand command = new SqlCommand(procQuery, conn))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dtsql);
                    }
                }
            }

            return dtsql;
        }

        public static void RunProc(string procName)
        {
            string procQuery = "exec " + procName;
            
            using (SqlConnection conn = new SqlConnection(SqlConnStr))
            {
                using (SqlCommand command = new SqlCommand(procQuery, conn))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        var cmd2 = conn.CreateCommand();
                        cmd2.CommandText = procQuery;
                        conn.Open();
                        var result = cmd2.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }

         
        }

    }

    class ExlRead
    {
        private static string _Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private static string _Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        public static string Excel03ConString
        {
            get { return _Excel03ConString; }
            set { _Excel03ConString = value; }
        }
        public static string Excel07ConString
        {
            get { return _Excel07ConString; }
            set { _Excel07ConString = value; }
        }


    }
}