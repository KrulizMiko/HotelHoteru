using System;
using System.Threading;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class Standart1 : Form
    {
        public Standart1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numbers Standart1 = new Numbers();
            Standart1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            business Standart1 = new business();
            Standart1.Show();
            this.Hide();// переписать
        }
        public void openForm()
        {
            Application.Run(new booking());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            var thread = new Thread(openForm); 
            thread.Start();
        }

        private void Standart1_Load(object sender, EventArgs e)
        {

        }
    }
}
