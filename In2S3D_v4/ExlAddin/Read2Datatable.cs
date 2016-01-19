using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;// test

namespace ExlAddin
{
    class Read2Dt
    {
        private string Excel03ConString;
        private string Excel07ConString;
        private DataTable dt = new DataTable();

        private string _filePath;
        public string filePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private string _ShtName;
        public string ShtName
        {
            get { return _ShtName; }
            set { _ShtName = value; }
        }

        private string _connStr;
        public string connStr
        {
            get { return _connStr; }
            set { _connStr = value; }
        }



        //Constructor
        public Read2Dt()
        {
            Excel03ConString = Util.DbConn.ExlRead.Excel03ConString;
            Excel07ConString = Util.DbConn.ExlRead.Excel07ConString;
            filePath = Util.TaskInfo.TaskSetting.InputFilePath;
            ShtName = connStr = string.Empty;
            connStr = string.Empty;
        }

        public void FilePrepare()
        {
            SelectFile();

        }

        public void SelectFile() 
        {
            string extension = Path.GetExtension(filePath);
            string header = "YES";

            switch (extension)
            {

                case ".xls": //Excel 97-03
                    connStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    connStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(connStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    //shtName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    //MessageBox.Show(shtName);
                    ShtName = setShtName(dtExcelSchema);
                    //sheetName = "index";

                    con.Close();
                }
            }

        }

        private string setShtName(DataTable dt)
        {
            //set sheet name
            extForms.SelectForm ShtNameForm = new extForms.SelectForm();
            ShtNameForm.ShowShtList(dt);
            ShtNameForm.ShowDialog();
            ShtName = ShtNameForm.shtName;
            return ShtName;
        }

        //Excel to Datatable
        public DataTable Exl2Dt()
        {
            
            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(connStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        //DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + ShtName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);//bug
                        con.Close();
                    }
                }
            }
            return this.dt;


        }




    }
}
