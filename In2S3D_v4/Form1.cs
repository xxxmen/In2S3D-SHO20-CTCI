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
            txtInputFilePath.Text = @"D:\Programa\In2S3D_c\INinput.xlsx"; // for test
            btnFileBrws1.Text = "Select";
            openFileDialog1.InitialDirectory = @"D:\Programa\In2S3D_c";
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

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Util.TaskInfo.TaskSetting.InputFilePath);


            ExlAddin.Read2Dt dt = new ExlAddin.Read2Dt();
            dt.FilePrepare();
            dtForm = dt.Exl2Dt();
            dataGridView1.DataSource = dtForm;

            SymClass.GCVN test = new SymClass.GCVN("GCVN");
            dtForm.Upload("UploadIndex");

            //MessageBox.Show(test.symType);
            Console.WriteLine(dataGridView1.Left.ToString());
        }

       

    

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //dataGridView1.Width = this.Size.Width - 50;
            //dataGridView1.Height = this.Size.Height  - dataGridView1.Location.Y - 50;
        }

        private void Testbutton_Click(object sender, EventArgs e)
        {
            TestlistBox1.Items.Add(System.DateTime.Now.ToString("yyyy-MM-dd"));
            
        }

       
    }
}
