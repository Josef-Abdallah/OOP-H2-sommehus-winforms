namespace OOP_H2_sommehus_winforms
{
    partial class Sommerhus
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_opret = new System.Windows.Forms.Button();
            this.txt_område = new System.Windows.Forms.TextBox();
            this.txt_navn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pris = new System.Windows.Forms.TextBox();
            this.txt_inspektør = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Rinspektør = new System.Windows.Forms.TextBox();
            this.txt_Rpris = new System.Windows.Forms.TextBox();
            this.button_Redigere = new System.Windows.Forms.Button();
            this.txt_Rområde = new System.Windows.Forms.TextBox();
            this.txt_Rnavn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_Slet = new System.Windows.Forms.Button();
            this.txt_Snavn = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.StartsideBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Sæson_comboBox_rediger = new System.Windows.Forms.ComboBox();
            this.Sæson_comboBox_Opret = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1002, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SommerHus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(966, 338);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 546);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_opret
            // 
            this.button_opret.Location = new System.Drawing.Point(267, 606);
            this.button_opret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_opret.Name = "button_opret";
            this.button_opret.Size = new System.Drawing.Size(112, 35);
            this.button_opret.TabIndex = 11;
            this.button_opret.Text = "Opret";
            this.button_opret.UseVisualStyleBackColor = true;
            this.button_opret.Click += new System.EventHandler(this.OpretSommerhus_button);
            // 
            // txt_område
            // 
            this.txt_område.Location = new System.Drawing.Point(196, 288);
            this.txt_område.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_område.Name = "txt_område";
            this.txt_område.Size = new System.Drawing.Size(181, 26);
            this.txt_område.TabIndex = 10;
            // 
            // txt_navn
            // 
            this.txt_navn.Location = new System.Drawing.Point(196, 222);
            this.txt_navn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_navn.Name = "txt_navn";
            this.txt_navn.Size = new System.Drawing.Size(181, 26);
            this.txt_navn.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Område";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Navn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 47);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opret hus";
            // 
            // txt_pris
            // 
            this.txt_pris.Location = new System.Drawing.Point(196, 368);
            this.txt_pris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pris.Name = "txt_pris";
            this.txt_pris.Size = new System.Drawing.Size(181, 26);
            this.txt_pris.TabIndex = 12;
            // 
            // txt_inspektør
            // 
            this.txt_inspektør.Location = new System.Drawing.Point(196, 526);
            this.txt_inspektør.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_inspektør.Name = "txt_inspektør";
            this.txt_inspektør.Size = new System.Drawing.Size(181, 26);
            this.txt_inspektør.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 368);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pris";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 442);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sæson";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 525);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Inspektør";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(546, 574);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Inspektør";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(546, 492);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 40;
            this.label9.Text = "Sæson";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(542, 418);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 29);
            this.label10.TabIndex = 39;
            this.label10.Text = "Pris";
            // 
            // txt_Rinspektør
            // 
            this.txt_Rinspektør.Location = new System.Drawing.Point(720, 577);
            this.txt_Rinspektør.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Rinspektør.Name = "txt_Rinspektør";
            this.txt_Rinspektør.Size = new System.Drawing.Size(181, 26);
            this.txt_Rinspektør.TabIndex = 38;
            // 
            // txt_Rpris
            // 
            this.txt_Rpris.Location = new System.Drawing.Point(720, 418);
            this.txt_Rpris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Rpris.Name = "txt_Rpris";
            this.txt_Rpris.Size = new System.Drawing.Size(181, 26);
            this.txt_Rpris.TabIndex = 36;
            // 
            // button_Redigere
            // 
            this.button_Redigere.Location = new System.Drawing.Point(789, 657);
            this.button_Redigere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Redigere.Name = "button_Redigere";
            this.button_Redigere.Size = new System.Drawing.Size(112, 35);
            this.button_Redigere.TabIndex = 35;
            this.button_Redigere.Text = "Redigere";
            this.button_Redigere.UseVisualStyleBackColor = true;
            this.button_Redigere.Click += new System.EventHandler(this.RedigerSommerhus_button);
            // 
            // txt_Rområde
            // 
            this.txt_Rområde.Location = new System.Drawing.Point(720, 341);
            this.txt_Rområde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Rområde.Name = "txt_Rområde";
            this.txt_Rområde.Size = new System.Drawing.Size(181, 26);
            this.txt_Rområde.TabIndex = 34;
            // 
            // txt_Rnavn
            // 
            this.txt_Rnavn.Location = new System.Drawing.Point(720, 272);
            this.txt_Rnavn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Rnavn.Name = "txt_Rnavn";
            this.txt_Rnavn.Size = new System.Drawing.Size(181, 26);
            this.txt_Rnavn.TabIndex = 33;
            this.txt_Rnavn.TextChanged += new System.EventHandler(this.txt_Rnavn_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(546, 338);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 29);
            this.label11.TabIndex = 32;
            this.label11.Text = "Område";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(546, 272);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 29);
            this.label12.TabIndex = 31;
            this.label12.Text = "Navn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(543, 150);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(274, 47);
            this.label13.TabIndex = 30;
            this.label13.Text = "Redigere Hus";
            // 
            // button_Slet
            // 
            this.button_Slet.Location = new System.Drawing.Point(1368, 272);
            this.button_Slet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Slet.Name = "button_Slet";
            this.button_Slet.Size = new System.Drawing.Size(112, 35);
            this.button_Slet.TabIndex = 47;
            this.button_Slet.Text = "Slet";
            this.button_Slet.UseVisualStyleBackColor = true;
            this.button_Slet.Click += new System.EventHandler(this.button_Slet_Click);
            // 
            // txt_Snavn
            // 
            this.txt_Snavn.Location = new System.Drawing.Point(1176, 272);
            this.txt_Snavn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Snavn.Name = "txt_Snavn";
            this.txt_Snavn.Size = new System.Drawing.Size(181, 26);
            this.txt_Snavn.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1002, 272);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 29);
            this.label18.TabIndex = 43;
            this.label18.Text = "Navn";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1000, 150);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(176, 47);
            this.label19.TabIndex = 42;
            this.label19.Text = "Slet Hus";
            // 
            // StartsideBut
            // 
            this.StartsideBut.Location = new System.Drawing.Point(68, 986);
            this.StartsideBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartsideBut.Name = "StartsideBut";
            this.StartsideBut.Size = new System.Drawing.Size(135, 60);
            this.StartsideBut.TabIndex = 48;
            this.StartsideBut.Text = "Tilbage";
            this.StartsideBut.UseVisualStyleBackColor = true;
            this.StartsideBut.Click += new System.EventHandler(this.StartsideBut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 49;
            this.button1.Text = "Find Hus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_CheckName_Click);
            // 
            // Sæson_comboBox
            // 
            this.Sæson_comboBox_rediger.FormattingEnabled = true;
            this.Sæson_comboBox_rediger.Location = new System.Drawing.Point(721, 493);
            this.Sæson_comboBox_rediger.Name = "Sæson_comboBox";
            this.Sæson_comboBox_rediger.Size = new System.Drawing.Size(180, 28);
            this.Sæson_comboBox_rediger.TabIndex = 50;
            this.Sæson_comboBox_rediger.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.Sæson_comboBox_Opret.FormattingEnabled = true;
            this.Sæson_comboBox_Opret.Location = new System.Drawing.Point(196, 446);
            this.Sæson_comboBox_Opret.Name = "comboBox1";
            this.Sæson_comboBox_Opret.Size = new System.Drawing.Size(181, 28);
            this.Sæson_comboBox_Opret.TabIndex = 51;
            // 
            // Sommerhus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2163, 1106);
            this.Controls.Add(this.Sæson_comboBox_Opret);
            this.Controls.Add(this.Sæson_comboBox_rediger);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartsideBut);
            this.Controls.Add(this.button_Slet);
            this.Controls.Add(this.txt_Snavn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Rinspektør);
            this.Controls.Add(this.txt_Rpris);
            this.Controls.Add(this.button_Redigere);
            this.Controls.Add(this.txt_Rområde);
            this.Controls.Add(this.txt_Rnavn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_inspektør);
            this.Controls.Add(this.txt_pris);
            this.Controls.Add(this.button_opret);
            this.Controls.Add(this.txt_område);
            this.Controls.Add(this.txt_navn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sommerhus";
            this.Text = "Sommerhus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sommerhus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_opret;
        private System.Windows.Forms.TextBox txt_område;
        private System.Windows.Forms.TextBox txt_navn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pris;
        private System.Windows.Forms.TextBox txt_inspektør;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Rinspektør;
        private System.Windows.Forms.TextBox txt_Rpris;
        private System.Windows.Forms.Button button_Redigere;
        private System.Windows.Forms.TextBox txt_Rområde;
        private System.Windows.Forms.TextBox txt_Rnavn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_Slet;
        private System.Windows.Forms.TextBox txt_Snavn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button StartsideBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Sæson_comboBox_rediger;
        private System.Windows.Forms.ComboBox Sæson_comboBox_Opret;
    }
}