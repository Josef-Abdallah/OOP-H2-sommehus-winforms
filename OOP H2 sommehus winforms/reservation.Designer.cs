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
            this.StartsideBut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_RsommerhusId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ToDateR = new System.Windows.Forms.DateTimePicker();
            this.fromDateR = new System.Windows.Forms.DateTimePicker();
            this.txt_Rtlf = new System.Windows.Forms.TextBox();
            this.txt_Rnavn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Redigere = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Snavn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_FindReservedHouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(770, 268);
            this.dataGridView1.TabIndex = 31;
            // 
            // button_opret
            // 
            this.button_opret.Location = new System.Drawing.Point(12, 187);
            this.button_opret.Name = "button_opret";
            this.button_opret.Size = new System.Drawing.Size(75, 23);
            this.button_opret.TabIndex = 30;
            this.button_opret.Text = "Opret";
            this.button_opret.UseVisualStyleBackColor = true;
            this.button_opret.Click += new System.EventHandler(this.button_opret_Click);
            // 
            // txt_kontaktinformation
            // 
            this.txt_kontaktinformation.Location = new System.Drawing.Point(59, 104);
            this.txt_kontaktinformation.Name = "txt_kontaktinformation";
            this.txt_kontaktinformation.Size = new System.Drawing.Size(122, 20);
            this.txt_kontaktinformation.TabIndex = 29;
            // 
            // txt_navn
            // 
            this.txt_navn.Location = new System.Drawing.Point(59, 84);
            this.txt_navn.Name = "txt_navn";
            this.txt_navn.Size = new System.Drawing.Size(122, 20);
            this.txt_navn.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "tlfnr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Navn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Reseveret huse";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(126, 151);
            this.fromDate.Margin = new System.Windows.Forms.Padding(2);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(135, 20);
            this.fromDate.TabIndex = 32;
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(279, 151);
            this.ToDate.Margin = new System.Windows.Forms.Padding(2);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(135, 20);
            this.ToDate.TabIndex = 33;
            // 
            // SommerhusId
            // 
            this.SommerhusId.AutoSize = true;
            this.SommerhusId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SommerhusId.Location = new System.Drawing.Point(9, 123);
            this.SommerhusId.Name = "SommerhusId";
            this.SommerhusId.Size = new System.Drawing.Size(113, 20);
            this.SommerhusId.TabIndex = 34;
            this.SommerhusId.Text = "Sommerhus Id";
            // 
            // SommerhusId_combobox
            // 
            this.SommerhusId_combobox.FormattingEnabled = true;
            this.SommerhusId_combobox.Location = new System.Drawing.Point(126, 123);
            this.SommerhusId_combobox.Margin = new System.Windows.Forms.Padding(2);
            this.SommerhusId_combobox.Name = "SommerhusId_combobox";
            this.SommerhusId_combobox.Size = new System.Drawing.Size(106, 21);
            this.SommerhusId_combobox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "fra og til dato";
            // 
            // StartsideBut
            // 
            this.StartsideBut.Location = new System.Drawing.Point(913, 477);
            this.StartsideBut.Name = "StartsideBut";
            this.StartsideBut.Size = new System.Drawing.Size(90, 39);
            this.StartsideBut.TabIndex = 49;
            this.StartsideBut.Text = "Tilbage";
            this.StartsideBut.UseVisualStyleBackColor = true;
            this.StartsideBut.Click += new System.EventHandler(this.StartsideBut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "fra og til dato";
            // 
            // comboBox_RsommerhusId
            // 
            this.comboBox_RsommerhusId.FormattingEnabled = true;
            this.comboBox_RsommerhusId.Location = new System.Drawing.Point(611, 123);
            this.comboBox_RsommerhusId.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_RsommerhusId.Name = "comboBox_RsommerhusId";
            this.comboBox_RsommerhusId.Size = new System.Drawing.Size(106, 21);
            this.comboBox_RsommerhusId.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Sommerhus Id";
            // 
            // ToDateR
            // 
            this.ToDateR.Location = new System.Drawing.Point(764, 151);
            this.ToDateR.Margin = new System.Windows.Forms.Padding(2);
            this.ToDateR.Name = "ToDateR";
            this.ToDateR.Size = new System.Drawing.Size(135, 20);
            this.ToDateR.TabIndex = 56;
            // 
            // fromDateR
            // 
            this.fromDateR.Location = new System.Drawing.Point(611, 151);
            this.fromDateR.Margin = new System.Windows.Forms.Padding(2);
            this.fromDateR.Name = "fromDateR";
            this.fromDateR.Size = new System.Drawing.Size(135, 20);
            this.fromDateR.TabIndex = 55;
            // 
            // txt_Rtlf
            // 
            this.txt_Rtlf.Location = new System.Drawing.Point(544, 104);
            this.txt_Rtlf.Name = "txt_Rtlf";
            this.txt_Rtlf.Size = new System.Drawing.Size(122, 20);
            this.txt_Rtlf.TabIndex = 54;
            // 
            // txt_Rnavn
            // 
            this.txt_Rnavn.Location = new System.Drawing.Point(544, 84);
            this.txt_Rnavn.Name = "txt_Rnavn";
            this.txt_Rnavn.Size = new System.Drawing.Size(122, 20);
            this.txt_Rnavn.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "tlfnr.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Navn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 31);
            this.label9.TabIndex = 50;
            this.label9.Text = "Rediger huse";
            // 
            // button_Redigere
            // 
            this.button_Redigere.Location = new System.Drawing.Point(654, 187);
            this.button_Redigere.Name = "button_Redigere";
            this.button_Redigere.Size = new System.Drawing.Size(75, 23);
            this.button_Redigere.TabIndex = 60;
            this.button_Redigere.Text = "Redigere";
            this.button_Redigere.UseVisualStyleBackColor = true;
            this.button_Redigere.Click += new System.EventHandler(this.button_Redigere_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1091, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 31);
            this.label10.TabIndex = 61;
            this.label10.Text = "Delete huse";
            // 
            // txt_Snavn
            // 
            this.txt_Snavn.Location = new System.Drawing.Point(1118, 86);
            this.txt_Snavn.Name = "txt_Snavn";
            this.txt_Snavn.Size = new System.Drawing.Size(122, 20);
            this.txt_Snavn.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1068, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 62;
            this.label11.Text = "Navn";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(1118, 152);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 64;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_FindReservedHouse
            // 
            this.button_FindReservedHouse.Location = new System.Drawing.Point(591, 55);
            this.button_FindReservedHouse.Name = "button_FindReservedHouse";
            this.button_FindReservedHouse.Size = new System.Drawing.Size(75, 23);
            this.button_FindReservedHouse.TabIndex = 65;
            this.button_FindReservedHouse.Text = "Find reseveret hus";
            this.button_FindReservedHouse.UseVisualStyleBackColor = true;
            this.button_FindReservedHouse.Click += new System.EventHandler(this.button_FindReservedHouse_Click);
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 638);
            this.Controls.Add(this.button_FindReservedHouse);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.txt_Snavn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_Redigere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_RsommerhusId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ToDateR);
            this.Controls.Add(this.fromDateR);
            this.Controls.Add(this.txt_Rtlf);
            this.Controls.Add(this.txt_Rnavn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StartsideBut);
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
            this.Name = "reservation";
            this.Text = " ";
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
        private System.Windows.Forms.Button StartsideBut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_RsommerhusId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ToDateR;
        private System.Windows.Forms.DateTimePicker fromDateR;
        private System.Windows.Forms.TextBox txt_Rtlf;
        private System.Windows.Forms.TextBox txt_Rnavn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Redigere;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Snavn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_FindReservedHouse;
    }
}