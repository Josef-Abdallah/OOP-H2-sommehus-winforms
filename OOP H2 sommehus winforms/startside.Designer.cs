namespace OOP_H2_sommehus_winforms
{
    partial class startside
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
            this.sommerhusejere = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sommerhusejere
            // 
            this.sommerhusejere.Location = new System.Drawing.Point(888, 102);
            this.sommerhusejere.Margin = new System.Windows.Forms.Padding(4);
            this.sommerhusejere.Name = "sommerhusejere";
            this.sommerhusejere.Size = new System.Drawing.Size(356, 160);
            this.sommerhusejere.TabIndex = 0;
            this.sommerhusejere.Text = "sommerhusejere";
            this.sommerhusejere.UseVisualStyleBackColor = true;
            this.sommerhusejere.Click += new System.EventHandler(this.Sommerhusejere);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1252, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(356, 160);
            this.button2.TabIndex = 1;
            this.button2.Text = "sommerhus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sommerhus);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1616, 102);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(356, 160);
            this.button3.TabIndex = 2;
            this.button3.Text = "resivation af sommerhus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.reservation);
            // 
            // startside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1985, 954);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sommerhusejere);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "startside";
            this.Text = "StartSide";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sommerhusejere;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

