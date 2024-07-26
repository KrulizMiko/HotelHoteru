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
    public partial class Thanks : Form
    {
        public Thanks()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void openForm()
        {
            Application.Run(new Home());
        }
        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
            var thread = new Thread(openForm);
            thread.Start();
        }
    }
}
