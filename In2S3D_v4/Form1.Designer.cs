namespace In2S3D_v4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFileBrws1 = new System.Windows.Forms.Button();
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.labInputFilePath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.saveListView = new System.Windows.Forms.ListView();
            this.SaveName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpload = new System.Windows.Forms.Button();
            this.Testbutton = new System.Windows.Forms.Button();
            this.listBoxSymbol = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFileBrws1
            // 
            this.btnFileBrws1.Location = new System.Drawing.Point(524, 21);
            this.btnFileBrws1.Name = "btnFileBrws1";
            this.btnFileBrws1.Size = new System.Drawing.Size(75, 23);
            this.btnFileBrws1.TabIndex = 24;
            this.btnFileBrws1.Text = "btnFileBrws1";
            this.btnFileBrws1.UseVisualStyleBackColor = true;
            this.btnFileBrws1.Click += new System.EventHandler(this.btnFileBrws1_Click);
            // 
            // txtInputFilePath
            // 
            this.txtInputFilePath.Location = new System.Drawing.Point(118, 24);
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.Size = new System.Drawing.Size(391, 20);
            this.txtInputFilePath.TabIndex = 23;
            this.txtInputFilePath.Text = "txtInputFilePath";
            this.txtInputFilePath.TextChanged += new System.EventHandler(this.InputFilePathChanged);
            // 
            // labInputFilePath
            // 
            this.labInputFilePath.AutoSize = true;
            this.labInputFilePath.Location = new System.Drawing.Point(18, 26);
            this.labInputFilePath.Name = "labInputFilePath";
            this.labInputFilePath.Size = new System.Drawing.Size(83, 13);
            this.labInputFilePath.TabIndex = 22;
            this.labInputFilePath.Text = "labInputFilePath";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xlsx";
            this.openFileDialog1.Filter = "Excel xlsx|*.xlsx";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(605, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 27;
            this.btnLoad.Text = "btnLoad";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(510, 395);
            this.dataGridView1.TabIndex = 26;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btnClear);
            this.MainPanel.Controls.Add(this.btnExport);
            this.MainPanel.Controls.Add(this.saveListView);
            this.MainPanel.Controls.Add(this.btnUpload);
            this.MainPanel.Controls.Add(this.Testbutton);
            this.MainPanel.Controls.Add(this.listBoxSymbol);
            this.MainPanel.Controls.Add(this.tabControl1);
            this.MainPanel.Controls.Add(this.btnLoad);
            this.MainPanel.Controls.Add(this.labInputFilePath);
            this.MainPanel.Controls.Add(this.btnFileBrws1);
            this.MainPanel.Controls.Add(this.txtInputFilePath);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(814, 538);
            this.MainPanel.TabIndex = 28;
            // 
            // saveListView
            // 
            this.saveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SaveName,
            this.Rev,
            this.UpdateDate,
            this.UpdateTime});
            this.saveListView.Location = new System.Drawing.Point(551, 362);
            this.saveListView.Name = "saveListView";
            this.saveListView.Size = new System.Drawing.Size(260, 149);
            this.saveListView.TabIndex = 32;
            this.saveListView.UseCompatibleStateImageBehavior = false;
            this.saveListView.View = System.Windows.Forms.View.Details;
            // 
            // SaveName
            // 
            this.SaveName.Tag = "";
            this.SaveName.Text = "Name";
            this.SaveName.Width = 79;
            // 
            // Rev
            // 
            this.Rev.Text = "Rev";
            this.Rev.Width = 43;
            // 
            // UpdateDate
            // 
            this.UpdateDate.Text = "Date";
            // 
            // UpdateTime
            // 
            this.UpdateTime.Text = "Time";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(605, 50);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 31;
            this.btnUpload.Text = "btnUpload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Testbutton
            // 
            this.Testbutton.Location = new System.Drawing.Point(589, 316);
            this.Testbutton.Name = "Testbutton";
            this.Testbutton.Size = new System.Drawing.Size(75, 23);
            this.Testbutton.TabIndex = 30;
            this.Testbutton.Text = "button2";
            this.Testbutton.UseVisualStyleBackColor = true;
            this.Testbutton.Click += new System.EventHandler(this.Testbutton_Click);
            // 
            // listBoxSymbol
            // 
            this.listBoxSymbol.FormattingEnabled = true;
            this.listBoxSymbol.Location = new System.Drawing.Point(589, 110);
            this.listBoxSymbol.Name = "listBoxSymbol";
            this.listBoxSymbol.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSymbol.Size = new System.Drawing.Size(173, 186);
            this.listBoxSymbol.TabIndex = 29;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 427);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(516, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(516, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(710, 21);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 33;
            this.btnExport.Text = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(710, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(814, 538);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFileBrws1;
        private System.Windows.Forms.TextBox txtInputFilePath;
        private System.Windows.Forms.Label labInputFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Testbutton;
        private System.Windows.Forms.ListBox listBoxSymbol;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ListView saveListView;
        private System.Windows.Forms.ColumnHeader SaveName;
        private System.Windows.Forms.ColumnHeader Rev;
        private System.Windows.Forms.ColumnHeader UpdateDate;
        private System.Windows.Forms.ColumnHeader UpdateTime;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClear;

    }
}

