namespace GoogleToWhatsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFetchData = new Button();
            btnSendWhatsApp = new Button();
            dataGridView1 = new DataGridView();
            btnExportToExcel = new Button();
            txtCategory = new TextBox();
            txtLocation = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFetchData
            // 
            btnFetchData.Location = new Point(25, 385);
            btnFetchData.Name = "btnFetchData";
            btnFetchData.Size = new Size(239, 44);
            btnFetchData.TabIndex = 0;
            btnFetchData.Text = "Fetch Data";
            btnFetchData.UseVisualStyleBackColor = true;
            btnFetchData.Click += btnFetchData_Click;
            // 
            // btnSendWhatsApp
            // 
            btnSendWhatsApp.Location = new Point(567, 385);
            btnSendWhatsApp.Name = "btnSendWhatsApp";
            btnSendWhatsApp.Size = new Size(240, 44);
            btnSendWhatsApp.TabIndex = 1;
            btnSendWhatsApp.Text = "Send WhatsApp";
            btnSendWhatsApp.UseVisualStyleBackColor = true;
            btnSendWhatsApp.Click += btnSendWhatsApp_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(782, 305);
            dataGridView1.TabIndex = 2;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new Point(298, 385);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(238, 44);
            btnExportToExcel.TabIndex = 3;
            btnExportToExcel.Text = "Export To Excel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(110, 13);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(697, 23);
            txtCategory.TabIndex = 4;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(110, 45);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(697, 23);
            txtLocation.TabIndex = 5;
            txtLocation.Text = "41.02437313021693, 29.15433980983167";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 6;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 53);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Location";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLocation);
            Controls.Add(txtCategory);
            Controls.Add(btnExportToExcel);
            Controls.Add(dataGridView1);
            Controls.Add(btnSendWhatsApp);
            Controls.Add(btnFetchData);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchData;
        private Button btnSendWhatsApp;
        private DataGridView dataGridView1;
        private Button btnExportToExcel;
        private TextBox txtCategory;
        private TextBox txtLocation;
        private Label label1;
        private Label label2;
    }
}