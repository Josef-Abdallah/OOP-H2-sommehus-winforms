﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_H2_sommehus_winforms
{
    public partial class startside : Form
    {
        public startside()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sommerhusejere(object sender, EventArgs e)
        {
           
        }
        private void sommerhus(object sender, EventArgs e)
        {
            startside ss = new startside();
            ss.Hide();
            Sommerhus sommerhus = new Sommerhus();
            sommerhus.Show();
        }

        private void reservation(object sender, EventArgs e)
        {

        }

    }
}
