using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class Главная : Form
    {
        public номера1 Номера { get; private set; }

        public Главная()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e, номера1 Номера)
        {
        

         
        }

        private void переход2_Click(object sender, EventArgs e)
        {
            Акции Главная = new Акции();
            Главная.Show();
            this.Hide();
        }



        private void переход_Click(object sender, EventArgs e)
        {
            номера1 Главная = new номера1();        
            Главная.Show();
            this.Hide();
        }

       
    }
}
