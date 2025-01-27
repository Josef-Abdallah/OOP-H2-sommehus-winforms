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
            this.txt_sæson = new System.Windows.Forms.TextBox();
            this.txt_inspektør = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Rinspektør = new System.Windows.Forms.TextBox();
            this.txt_Rsæson = new System.Windows.Forms.TextBox();
            this.txt_Rpris = new System.Windows.Forms.TextBox();
            this.button_Redigere = new System.Windows.Forms.Button();
            this.txt_Rområde = new System.Windows.Forms.TextBox();
            this.txt_Rnavn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Sinspektør = new System.Windows.Forms.TextBox();
            this.txt_Ssæson = new System.Windows.Forms.TextBox();
            this.txt_Spris = new System.Windows.Forms.TextBox();
            this.button_Slet = new System.Windows.Forms.Button();
            this.txt_Sområde = new System.Windows.Forms.TextBox();
            this.txt_Snavn = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SommerHus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(834, 648);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(795, 228);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_opret
            // 
            this.button_opret.Location = new System.Drawing.Point(237, 485);
            this.button_opret.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_opret.Name = "button_opret";
            this.button_opret.Size = new System.Drawing.Size(100, 28);
            this.button_opret.TabIndex = 11;
            this.button_opret.Text = "Opret";
            this.button_opret.UseVisualStyleBackColor = true;
            this.button_opret.Click += new System.EventHandler(this.button_opret_Click);
            // 
            // txt_område
            // 
            this.txt_område.Location = new System.Drawing.Point(175, 230);
            this.txt_område.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_område.Name = "txt_område";
            this.txt_område.Size = new System.Drawing.Size(161, 22);
            this.txt_område.TabIndex = 10;
            // 
            // txt_navn
            // 
            this.txt_navn.Location = new System.Drawing.Point(175, 177);
            this.txt_navn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_navn.Name = "txt_navn";
            this.txt_navn.Size = new System.Drawing.Size(161, 22);
            this.txt_navn.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Område";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Navn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opret hus";
            // 
            // txt_pris
            // 
            this.txt_pris.Location = new System.Drawing.Point(175, 294);
            this.txt_pris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pris.Name = "txt_pris";
            this.txt_pris.Size = new System.Drawing.Size(161, 22);
            this.txt_pris.TabIndex = 12;
            // 
            // txt_sæson
            // 
            this.txt_sæson.Location = new System.Drawing.Point(175, 353);
            this.txt_sæson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sæson.Name = "txt_sæson";
            this.txt_sæson.Size = new System.Drawing.Size(161, 22);
            this.txt_sæson.TabIndex = 13;
            // 
            // txt_inspektør
            // 
            this.txt_inspektør.Location = new System.Drawing.Point(175, 421);
            this.txt_inspektør.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_inspektør.Name = "txt_inspektør";
            this.txt_inspektør.Size = new System.Drawing.Size(161, 22);
            this.txt_inspektør.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pris";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sæson";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 419);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Inspektør";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 459);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Inspektør";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 394);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Sæson";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(481, 335);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "Pris";
            // 
            // txt_Rinspektør
            // 
            this.txt_Rinspektør.Location = new System.Drawing.Point(640, 462);
            this.txt_Rinspektør.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Rinspektør.Name = "txt_Rinspektør";
            this.txt_Rinspektør.Size = new System.Drawing.Size(161, 22);
            this.txt_Rinspektør.TabIndex = 38;
            // 
            // txt_Rsæson
            // 
            this.txt_Rsæson.Location = new System.Drawing.Point(640, 394);
            this.txt_Rsæson.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Rsæson.Name = "txt_Rsæson";
            this.txt_Rsæson.Size = new System.Drawing.Size(161, 22);
            this.txt_Rsæson.TabIndex = 37;
            // 
            // txt_Rpris
            // 
            this.txt_Rpris.Location = new System.Drawing.Point(640, 335);
            this.txt_Rpris.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Rpris.Name = "txt_Rpris";
            this.txt_Rpris.Size = new System.Drawing.Size(161, 22);
            this.txt_Rpris.TabIndex = 36;
            // 
            // button_Redigere
            // 
            this.button_Redigere.Location = new System.Drawing.Point(702, 526);
            this.button_Redigere.Margin = new System.Windows.Forms.Padding(4);
            this.button_Redigere.Name = "button_Redigere";
            this.button_Redigere.Size = new System.Drawing.Size(100, 28);
            this.button_Redigere.TabIndex = 35;
            this.button_Redigere.Text = "Redigere";
            this.button_Redigere.UseVisualStyleBackColor = true;
            this.button_Redigere.Click += new System.EventHandler(this.button_Redigere_Click);
            // 
            // txt_Rområde
            // 
            this.txt_Rområde.Location = new System.Drawing.Point(640, 271);
            this.txt_Rområde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Rområde.Name = "txt_Rområde";
            this.txt_Rområde.Size = new System.Drawing.Size(161, 22);
            this.txt_Rområde.TabIndex = 34;
            // 
            // txt_Rnavn
            // 
            this.txt_Rnavn.Location = new System.Drawing.Point(640, 218);
            this.txt_Rnavn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Rnavn.Name = "txt_Rnavn";
            this.txt_Rnavn.Size = new System.Drawing.Size(161, 22);
            this.txt_Rnavn.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(485, 271);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Område";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(485, 218);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Navn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(483, 120);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 39);
            this.label13.TabIndex = 30;
            this.label13.Text = "Redigere Hus";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(891, 459);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 25);
            this.label14.TabIndex = 53;
            this.label14.Text = "Inspektør";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(891, 394);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 25);
            this.label15.TabIndex = 52;
            this.label15.Text = "Sæson";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(887, 335);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 25);
            this.label16.TabIndex = 51;
            this.label16.Text = "Pris";
            // 
            // txt_Sinspektør
            // 
            this.txt_Sinspektør.Location = new System.Drawing.Point(1046, 462);
            this.txt_Sinspektør.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Sinspektør.Name = "txt_Sinspektør";
            this.txt_Sinspektør.Size = new System.Drawing.Size(161, 22);
            this.txt_Sinspektør.TabIndex = 50;
            // 
            // txt_Ssæson
            // 
            this.txt_Ssæson.Location = new System.Drawing.Point(1046, 394);
            this.txt_Ssæson.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ssæson.Name = "txt_Ssæson";
            this.txt_Ssæson.Size = new System.Drawing.Size(161, 22);
            this.txt_Ssæson.TabIndex = 49;
            // 
            // txt_Spris
            // 
            this.txt_Spris.Location = new System.Drawing.Point(1046, 335);
            this.txt_Spris.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Spris.Name = "txt_Spris";
            this.txt_Spris.Size = new System.Drawing.Size(161, 22);
            this.txt_Spris.TabIndex = 48;
            // 
            // button_Slet
            // 
            this.button_Slet.Location = new System.Drawing.Point(1108, 526);
            this.button_Slet.Margin = new System.Windows.Forms.Padding(4);
            this.button_Slet.Name = "button_Slet";
            this.button_Slet.Size = new System.Drawing.Size(100, 28);
            this.button_Slet.TabIndex = 47;
            this.button_Slet.Text = "Slet";
            this.button_Slet.UseVisualStyleBackColor = true;
            // 
            // txt_Sområde
            // 
            this.txt_Sområde.Location = new System.Drawing.Point(1046, 271);
            this.txt_Sområde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Sområde.Name = "txt_Sområde";
            this.txt_Sområde.Size = new System.Drawing.Size(161, 22);
            this.txt_Sområde.TabIndex = 46;
            // 
            // txt_Snavn
            // 
            this.txt_Snavn.Location = new System.Drawing.Point(1046, 218);
            this.txt_Snavn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Snavn.Name = "txt_Snavn";
            this.txt_Snavn.Size = new System.Drawing.Size(161, 22);
            this.txt_Snavn.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(891, 271);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = "Område";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(891, 218);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 25);
            this.label18.TabIndex = 43;
            this.label18.Text = "Navn";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(889, 120);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(183, 49);
            this.label19.TabIndex = 42;
            this.label19.Text = "Slet Hus";
            // 
            // Sommerhus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 897);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_Sinspektør);
            this.Controls.Add(this.txt_Ssæson);
            this.Controls.Add(this.txt_Spris);
            this.Controls.Add(this.button_Slet);
            this.Controls.Add(this.txt_Sområde);
            this.Controls.Add(this.txt_Snavn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Rinspektør);
            this.Controls.Add(this.txt_Rsæson);
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
            this.Controls.Add(this.txt_sæson);
            this.Controls.Add(this.txt_pris);
            this.Controls.Add(this.button_opret);
            this.Controls.Add(this.txt_område);
            this.Controls.Add(this.txt_navn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sommerhus";
            this.Text = "Sommerhus";
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
        private System.Windows.Forms.TextBox txt_sæson;
        private System.Windows.Forms.TextBox txt_inspektør;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Rinspektør;
        private System.Windows.Forms.TextBox txt_Rsæson;
        private System.Windows.Forms.TextBox txt_Rpris;
        private System.Windows.Forms.Button button_Redigere;
        private System.Windows.Forms.TextBox txt_Rområde;
        private System.Windows.Forms.TextBox txt_Rnavn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Sinspektør;
        private System.Windows.Forms.TextBox txt_Ssæson;
        private System.Windows.Forms.TextBox txt_Spris;
        private System.Windows.Forms.Button button_Slet;
        private System.Windows.Forms.TextBox txt_Sområde;
        private System.Windows.Forms.TextBox txt_Snavn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}