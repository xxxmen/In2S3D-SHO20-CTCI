using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace In2S3D_v4.extForms
{
    public partial class InputBoxCsharp : Form
    {
        private string _txtSaveName;
        public string txtSaveName
        {
            get { return _txtSaveName; }
            set { _txtSaveName = value; }
        }

        public InputBoxCsharp()
        {
            InitializeComponent();
            initialDefault();
        }

        public void initialDefault()
        {
            this.Text = "Please set the save name.";
            label1.Text = "Please set the save name.";
            button1.Text = "OK";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtSaveName = textBox1.Text;
            this.Close();
        }
    }
}
