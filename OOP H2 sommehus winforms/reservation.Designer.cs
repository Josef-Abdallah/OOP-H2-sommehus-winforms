namespace OOP_H2_sommehus_winforms
{
    partial class reservation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_opret = new System.Windows.Forms.Button();
            this.txt_kontaktinformation = new System.Windows.Forms.TextBox();
            this.txt_navn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.SommerhusId = new System.Windows.Forms.Label();
            this.SommerhusId_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 381);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 413);
            this.dataGridView1.TabIndex = 31;
            // 
            // button_opret
            // 
            this.button_opret.Location = new System.Drawing.Point(18, 288);
            this.button_opret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_opret.Name = "button_opret";
            this.button_opret.Size = new System.Drawing.Size(112, 35);
            this.button_opret.TabIndex = 30;
            this.button_opret.Text = "Opret";
            this.button_opret.UseVisualStyleBackColor = true;
            this.button_opret.Click += new System.EventHandler(this.button_opret_Click);
            // 
            // txt_kontaktinformation
            // 
            this.txt_kontaktinformation.Location = new System.Drawing.Point(233, 164);
            this.txt_kontaktinformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_kontaktinformation.Name = "txt_kontaktinformation";
            this.txt_kontaktinformation.Size = new System.Drawing.Size(181, 26);
            this.txt_kontaktinformation.TabIndex = 29;
            // 
            // txt_navn
            // 
            this.txt_navn.Location = new System.Drawing.Point(89, 129);
            this.txt_navn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_navn.Name = "txt_navn";
            this.txt_navn.Size = new System.Drawing.Size(181, 26);
            this.txt_navn.TabIndex = 28;
            this.txt_navn.TextChanged += new System.EventHandler(this.txt_navn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kontaktinformation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Navn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 47);
            this.label4.TabIndex = 25;
            this.label4.Text = "Reseveret huse";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(189, 232);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 26);
            this.fromDate.TabIndex = 32;
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(419, 232);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 26);
            this.ToDate.TabIndex = 33;
            // 
            // SommerhusId
            // 
            this.SommerhusId.AutoSize = true;
            this.SommerhusId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SommerhusId.Location = new System.Drawing.Point(13, 189);
            this.SommerhusId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SommerhusId.Name = "SommerhusId";
            this.SommerhusId.Size = new System.Drawing.Size(169, 29);
            this.SommerhusId.TabIndex = 34;
            this.SommerhusId.Text = "Sommerhus Id";
            // 
            // SommerhusId_combobox
            // 
            this.SommerhusId_combobox.FormattingEnabled = true;
            this.SommerhusId_combobox.Location = new System.Drawing.Point(189, 189);
            this.SommerhusId_combobox.Name = "SommerhusId_combobox";
            this.SommerhusId_combobox.Size = new System.Drawing.Size(157, 28);
            this.SommerhusId_combobox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "fra og til dato";
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2134, 982);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SommerhusId_combobox);
            this.Controls.Add(this.SommerhusId);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_opret);
            this.Controls.Add(this.txt_kontaktinformation);
            this.Controls.Add(this.txt_navn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "reservation";
            this.Text = "reservation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_opret;
        private System.Windows.Forms.TextBox txt_kontaktinformation;
        private System.Windows.Forms.TextBox txt_navn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label SommerhusId;
        private System.Windows.Forms.ComboBox SommerhusId_combobox;
        private System.Windows.Forms.Label label1;
    }
}