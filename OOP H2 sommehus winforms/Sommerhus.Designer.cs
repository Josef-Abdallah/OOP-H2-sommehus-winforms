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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_opret = new System.Windows.Forms.Button();
            this.txt_område = new System.Windows.Forms.TextBox();
            this.txt_navn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pris = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.ByNavn_OpretHus = new System.Windows.Forms.TextBox();
            this.Bynavn_opret_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VejNavn_OpretHus = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Inspektør_combobox_opretHus = new System.Windows.Forms.ComboBox();
            this.inspektør_redigerhus_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // button_opret
            // 
            this.button_opret.Location = new System.Drawing.Point(267, 407);
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
            this.txt_område.Location = new System.Drawing.Point(198, 277);
            this.txt_område.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_område.Name = "txt_område";
            this.txt_område.Size = new System.Drawing.Size(181, 26);
            this.txt_område.TabIndex = 10;
            // 
            // txt_navn
            // 
            this.txt_navn.Location = new System.Drawing.Point(198, 176);
            this.txt_navn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_navn.Name = "txt_navn";
            this.txt_navn.Size = new System.Drawing.Size(181, 26);
            this.txt_navn.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 274);
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
            this.label2.Location = new System.Drawing.Point(22, 172);
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
            this.txt_pris.Location = new System.Drawing.Point(198, 307);
            this.txt_pris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pris.Name = "txt_pris";
            this.txt_pris.Size = new System.Drawing.Size(181, 26);
            this.txt_pris.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pris";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 332);
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
            this.label8.Location = new System.Drawing.Point(541, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Inspektør";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(541, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 29);
            this.label10.TabIndex = 39;
            this.label10.Text = "Pris";
            // 
            // txt_Rpris
            // 
            this.txt_Rpris.Location = new System.Drawing.Point(719, 240);
            this.txt_Rpris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Rpris.Name = "txt_Rpris";
            this.txt_Rpris.Size = new System.Drawing.Size(181, 26);
            this.txt_Rpris.TabIndex = 36;
            // 
            // button_Redigere
            // 
            this.button_Redigere.Location = new System.Drawing.Point(788, 370);
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
            this.txt_Rområde.Location = new System.Drawing.Point(721, 211);
            this.txt_Rområde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Rområde.Name = "txt_Rområde";
            this.txt_Rområde.Size = new System.Drawing.Size(181, 26);
            this.txt_Rområde.TabIndex = 34;
            // 
            // txt_Rnavn
            // 
            this.txt_Rnavn.Location = new System.Drawing.Point(719, 177);
            this.txt_Rnavn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Rnavn.Name = "txt_Rnavn";
            this.txt_Rnavn.Size = new System.Drawing.Size(181, 26);
            this.txt_Rnavn.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(541, 207);
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
            this.label12.Location = new System.Drawing.Point(541, 173);
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
            this.label13.Location = new System.Drawing.Point(543, 98);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(274, 47);
            this.label13.TabIndex = 30;
            this.label13.Text = "Redigere Hus";
            // 
            // button_Slet
            // 
            this.button_Slet.Location = new System.Drawing.Point(1226, 151);
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
            this.txt_Snavn.Location = new System.Drawing.Point(1037, 155);
            this.txt_Snavn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Snavn.Name = "txt_Snavn";
            this.txt_Snavn.Size = new System.Drawing.Size(181, 26);
            this.txt_Snavn.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(961, 152);
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
            this.label19.Location = new System.Drawing.Point(958, 98);
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
            this.button1.Location = new System.Drawing.Point(791, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 49;
            this.button1.Text = "Find Hus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_CheckName_Click);
            // 
            // ByNavn_OpretHus
            // 
            this.ByNavn_OpretHus.Location = new System.Drawing.Point(198, 212);
            this.ByNavn_OpretHus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ByNavn_OpretHus.Name = "ByNavn_OpretHus";
            this.ByNavn_OpretHus.Size = new System.Drawing.Size(181, 26);
            this.ByNavn_OpretHus.TabIndex = 52;
            // 
            // Bynavn_opret_label
            // 
            this.Bynavn_opret_label.AutoSize = true;
            this.Bynavn_opret_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bynavn_opret_label.Location = new System.Drawing.Point(22, 208);
            this.Bynavn_opret_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bynavn_opret_label.Name = "Bynavn_opret_label";
            this.Bynavn_opret_label.Size = new System.Drawing.Size(95, 29);
            this.Bynavn_opret_label.TabIndex = 53;
            this.Bynavn_opret_label.Text = "ByNavn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "VejNavn";
            // 
            // VejNavn_OpretHus
            // 
            this.VejNavn_OpretHus.Location = new System.Drawing.Point(198, 248);
            this.VejNavn_OpretHus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VejNavn_OpretHus.Name = "VejNavn_OpretHus";
            this.VejNavn_OpretHus.Size = new System.Drawing.Size(181, 26);
            this.VejNavn_OpretHus.TabIndex = 55;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(198, 377);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(181, 28);
            this.comboBox2.TabIndex = 57;
            // 
            // Inspektør_combobox_opretHus
            // 
            this.Inspektør_combobox_opretHus.FormattingEnabled = true;
            this.Inspektør_combobox_opretHus.Location = new System.Drawing.Point(198, 343);
            this.Inspektør_combobox_opretHus.Name = "Inspektør_combobox_opretHus";
            this.Inspektør_combobox_opretHus.Size = new System.Drawing.Size(181, 28);
            this.Inspektør_combobox_opretHus.TabIndex = 58;
            // 
            // inspektør_redigerhus_combobox
            // 
            this.inspektør_redigerhus_combobox.FormattingEnabled = true;
            this.inspektør_redigerhus_combobox.Location = new System.Drawing.Point(719, 274);
            this.inspektør_redigerhus_combobox.Name = "inspektør_redigerhus_combobox";
            this.inspektør_redigerhus_combobox.Size = new System.Drawing.Size(181, 28);
            this.inspektør_redigerhus_combobox.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 29);
            this.label6.TabIndex = 60;
            this.label6.Text = "Ejere";
            // 
            // Sommerhus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2163, 1106);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inspektør_redigerhus_combobox);
            this.Controls.Add(this.Inspektør_combobox_opretHus);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.VejNavn_OpretHus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bynavn_opret_label);
            this.Controls.Add(this.ByNavn_OpretHus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartsideBut);
            this.Controls.Add(this.button_Slet);
            this.Controls.Add(this.txt_Snavn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Rpris);
            this.Controls.Add(this.button_Redigere);
            this.Controls.Add(this.txt_Rområde);
            this.Controls.Add(this.txt_Rnavn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pris);
            this.Controls.Add(this.button_opret);
            this.Controls.Add(this.txt_område);
            this.Controls.Add(this.txt_navn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sommerhus";
            this.Text = "Sommerhus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_opret;
        private System.Windows.Forms.TextBox txt_område;
        private System.Windows.Forms.TextBox txt_navn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.TextBox ByNavn_OpretHus;
        private System.Windows.Forms.Label Bynavn_opret_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VejNavn_OpretHus;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox Inspektør_combobox_opretHus;
        private System.Windows.Forms.ComboBox inspektør_redigerhus_combobox;
        private System.Windows.Forms.Label label6;
    }
}