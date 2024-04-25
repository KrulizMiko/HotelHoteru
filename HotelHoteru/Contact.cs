using System;
using System.Threading;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(openForm);
            thread.Start();
        }
        public void openForm()
        {
            Application.Run(new Home());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(OpenForm);
            thread.Start();
            
        }
        public void OpenForm() 
        {
            Application.Run(new info());     
            
        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }
    }
}
