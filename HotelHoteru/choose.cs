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
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }

        public void openForm()
        {
            Application.Run(new Home());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(openForm); thread.Start();
        }
    }
}
