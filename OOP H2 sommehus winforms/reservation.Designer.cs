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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(616, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 223);
            this.dataGridView1.TabIndex = 31;
            // 
            // button_opret
            // 
            this.button_opret.Location = new System.Drawing.Point(267, 362);
            this.button_opret.Name = "button_opret";
            this.button_opret.Size = new System.Drawing.Size(75, 23);
            this.button_opret.TabIndex = 30;
            this.button_opret.Text = "Opret";
            this.button_opret.UseVisualStyleBackColor = true;
            // 
            // txt_kontaktinformation
            // 
            this.txt_kontaktinformation.Location = new System.Drawing.Point(161, 155);
            this.txt_kontaktinformation.Name = "txt_kontaktinformation";
            this.txt_kontaktinformation.Size = new System.Drawing.Size(122, 20);
            this.txt_kontaktinformation.TabIndex = 29;
            // 
            // txt_navn
            // 
            this.txt_navn.Location = new System.Drawing.Point(63, 112);
            this.txt_navn.Name = "txt_navn";
            this.txt_navn.Size = new System.Drawing.Size(122, 20);
            this.txt_navn.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kontaktinformation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Navn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Reseveret huse";
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_opret);
            this.Controls.Add(this.txt_kontaktinformation);
            this.Controls.Add(this.txt_navn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "reservation";
            this.Text = "reservation";
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
    }
}