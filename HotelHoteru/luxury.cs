﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class luxury : Form
    {
        public luxury()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            business luxury = new business();
            luxury.Show();
            this.Hide();
        }
        public void openForm()
        {
            Application.Run(new booking());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(openForm); thread.Start();
        }

        private void luxury_Load(object sender, EventArgs e)
        {

        }
    }
}
