using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
using System.Data;
using Util;
using Util.DbConn;
using System.Runtime.InteropServices;

namespace ExlAddin
{
    class Write2Exl
    {
        object misValue = System.Reflection.Missing.Value;
        private Excel.Application xlApp;
        //Excel.Workbook xlWorkBook;
        private Excel.Workbook xlWorkBookTar;
        //Excel.Worksheet shtINinput;
        private Excel.Worksheet xlWorkSht;
        private DataTable dt_exl = new DataTable();
        private string Excel03ConString = Util.DbConn.ExlRead.Excel03ConString;
        private string Excel07ConString = Util.DbConn.ExlRead.Excel07ConString;
        private string wrtFilePath = Util.TaskInfo.TaskSetting.OutputFilePath;

        //public Write2Exl()
        //{ 
        //}

        public void WriteInExl(List<string> workList)
        {
            xlApp = new Excel.Application(); // open Excel App
            xlWorkBookTar = xlApp.Application.Workbooks.Open(wrtFilePath); // open Workbook

            //wrtBySht("InstrumentClassData");
            foreach (string item in workList)
            {
                wrtBySht(item);
            }
            xlWorkBookTar.SaveAs(wrtFilePath, misValue, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
            xlWorkBookTar.Close();
            xlApp.Quit();
            finProg();
        }


        //private void wrtBySht(List<string> workList)
        private void wrtBySht(string shtName)
        {

            xlWorkSht = xlWorkBookTar.Worksheets.get_Item(shtName);
            xlWorkSht.Activate();

            string idx = Util.TaskInfo.TaskSetting.insertPtInstData; // start point index
            Excel.Range rng = xlWorkSht.get_Range(idx, idx);

            DataTable dt;
            if (shtName == "InstrumentClassData")
                dt = Util.DbConn.SqlTsk.GetTable("procGetInstData");
            else
                dt = Util.DbConn.SqlTsk.GetTable("procGetSymData " + shtName);


            int j = 1;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                for (i = 0; i < dt.Columns.Count; i++)
                {
                    rng[j + 1, i + 1].Value = row[i].ToString();

                }
                j++;
                if (j > dt.Rows.Count)
                {
                    break;
                }
            }
            rng[j + 1, 1].Value = "end";

        }

        void finProg() // for clear Excel applicatin completely
        {
            if (xlWorkSht != null)
            {
                Marshal.FinalReleaseComObject(xlWorkSht);
            }
            if (xlWorkBookTar != null)
            {
                Marshal.FinalReleaseComObject(xlWorkBookTar);
            }
            if (xlApp != null)
            {
                Marshal.FinalReleaseComObject(xlApp);
            }
        }





    }
}
