using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace extForms
{
    public partial class SelectForm : Form
    {
        private string _shtName;
        public string shtName
        {
            get { return _shtName; }
            set { _shtName = value; }
        }


        public SelectForm()
        {
            InitializeComponent();
        }
        public SelectForm(string title)
        {
            InitializeComponent();
            this.Text = title;
            this.button1.Text = "Apply";
        }


        public void ShowShtList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                listBox1.Items.Add(row["TABLE_NAME"].ToString());
            }
        }

        public void GetShtName()
        {

            shtName = listBox1.SelectedItem.ToString();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GetShtName();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (shtName == "" || shtName == null)
            {
                MessageBox.Show("Please select accurate sheet name.");
                e.Cancel = true;
            }
            
        }

    
    }
}
