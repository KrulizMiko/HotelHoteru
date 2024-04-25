using System;
using System.Threading;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class business : Form
    {
        public business()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Standart1 business = new Standart1();
            business.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            luxury business = new luxury();
            business.Show();
            this.Hide();
        }

        private void business_Load(object sender, EventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
