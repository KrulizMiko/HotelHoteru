using System;
using System.Threading;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void openForm()
        {
            Application.Run(new Contact());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(openForm);
            thread.Start();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void info_Load(object sender, EventArgs e)
        {

        }
    }
}
