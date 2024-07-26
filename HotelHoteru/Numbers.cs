using System;
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
    public partial class Numbers : Form
    {
        public Numbers()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            var thread = new Thread(openForm);
            thread.Start();
        }
        public void openForm()
        {
            Application.Run(new Standart1());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home номера1 = new Home();
            номера1.Show();
            this.Hide();//переписать


        }

        private void номера_Load(object sender, EventArgs e)
        {

        }
    }
}
