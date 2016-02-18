using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util.GeneralInfo;
using Util;
using Util.DbConn;

namespace In2S3D_v4
{
    public partial class Form1 : Form
    {
        public int oldWidth { get; set; }
        public int oldHeight { get; set; }
        private Size oldSize;


        public DataTable dtForm = new DataTable();
        public Form1()
        {
            InitializeComponent();
            initialDefault();

        }
        public void initialDefault()
        {
            labInputFilePath.Text = "Input File Path : ";
            txtInputFilePath.Text = @"D:\Programa\In2S3D_c\123\INinput2.xlsx"; // for test
            btnFileBrws1.Text = "Select";
            //openFileDialog1.InitialDirectory = @"D:\Programa\In2S3D_c";
            openFileDialog1.InitialDirectory = @"D:\Programa\In2S3D_c\123";
            btnLoad.Text = "Load";
            btnUpload.Text = "Upload";
            btnExport.Text = "Export";
            Util.TaskInfo.TaskSetting.insertPtInstData = "A11";
            Util.TaskInfo.TaskSetting.insertPtSymTyp = "A0";

            Util.TaskInfo.TaskSetting.OutputFilePath = @"D:\Programa\In2S3D_c\123\0-InstrumentData_Test.xlsx";

            //labOutputFilePath.Text = "Output File Path : ";
            //txtOutputFilePath.Text = @"D:\Programa\In2S3D_c\0-InstrumentData_Test.xlsx"; //for test
            //btnFileBrws2.Text = "Select";
            //btnEXE.Text = "Run";

        }

        private void btnFileBrws1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtInputFilePath.Text = openFileDialog1.FileName;
        }

        private void InputFilePathChanged(object sender, EventArgs e)
        {
            Util.TaskInfo.TaskSetting.InputFilePath = txtInputFilePath.Text;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Util.TaskInfo.TaskSetting.InputFilePath);


            ExlAddin.Read2Dt dt = new ExlAddin.Read2Dt();
            dt.FilePrepare();
            dtForm = dt.Exl2Dt();
            dataGridView1.DataSource = dtForm;



            //MessageBox.Show(test.symType);
            //Console.WriteLine(dataGridView1.Left.ToString());


            // filter SymbolType to Listbox to select
            var query = from c in dtForm.AsEnumerable()
                        group c by c.Field<string>("SymbolType");

            foreach (var item in query)
            {
                if (item.Key == null)
                    continue;
                //Console.WriteLine(item.Key);
                listBoxSymbol.Items.Add(item.Key);
            }
        }





        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //dataGridView1.Width = this.Size.Width - 50;
            //dataGridView1.Height = this.Size.Height  - dataGridView1.Location.Y - 50;
        }

        private void Testbutton_Click(object sender, EventArgs e)
        {
            string saveName;
            string saveDate = "";
            string saveTime = "";
            saveDate = System.DateTime.Now.ToString("yyyy-MM-dd");
            saveTime = System.DateTime.Now.ToString("hh:mm");

            //TestlistBox1.Items.Add(System.DateTime.Now.ToString("yyyy-MM-dd"));
            //String saveName = 
            //saveListView.Items.Add("1");
            extForms.InputBoxCsharp inputBox1 = new extForms.InputBoxCsharp();
            inputBox1.ShowDialog();

            //saveName = inputBox1.txtSaveName + "_" + saveDate + "_" + saveTime;
            saveName = inputBox1.txtSaveName;


            ListViewItem lvi = new ListViewItem();
            lvi.Text = saveName; // Name
            lvi.SubItems.Add(""); // Rev
            lvi.SubItems.Add(saveDate); // Update Date
            lvi.SubItems.Add(saveTime); // Update Time
            saveListView.Items.Add(lvi);

            DataTable dtRev = new DataTable();
            dtRev.Columns.Add("LoadNum");
            dtRev.Columns.Add("Rev");
            dtRev.Columns.Add("UpdateDate");
            dtRev.Columns.Add("UpdateTime");
            foreach (ListViewItem item in saveListView.Items)
            {

                dtRev.Rows.Add(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text);


            }

            dtRev.Upload2("RevLoad_Table");



        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            SymClass.GCVN test = new SymClass.GCVN("GCVN");


            DataTable dt2 = linqrun();
            dt2.Upload2("UploadIndex");
            //dtForm.Upload2("UploadIndex");
            SqlTsk.RunProc("procIdx2Data");




        }

        private DataTable linqrun()
        {
            DataTable dt = dtForm.Clone();
            foreach (string symTyp in listBoxSymbol.SelectedItems)
            {
                var query = from c in dtForm.AsEnumerable()
                            where c.Field<string>("SymbolType") == symTyp
                            select c;
                
                foreach (DataRow item in query)
                {

                    dt.Rows.Add(item.ItemArray);
                    
                }
            }


            return dt;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = SqlTsk.GetTable("procGetSymData 'GCVN'");
            dataGridView1.DataSource = SqlTsk.GetTable("procGetInstData");
            ExlAddin.Write2Exl exportWork = new ExlAddin.Write2Exl();
            exportWork.WriteInExl(mkExportSht());
        }

        private List<string> mkExportSht()
        { 
            List<string> lst = new List<string>();
            //foreach (string symTyp in listBoxSymbol.SelectedItems)
            //{
            //    lst.Add(symTyp);
            //}
            lst.Add("InstrumentClassData");

            foreach (string symTyp in listBoxSymbol.SelectedItems)
            {
                lst.Add(symTyp);
            }


            return lst;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SqlTsk.RunProc("procClearTable");

        }


    }
}
