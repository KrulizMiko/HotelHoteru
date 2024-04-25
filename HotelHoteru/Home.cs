using System;
using System.Threading;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class Home : Form
    {
        public Numbers Номера { get; private set; }

        public Home()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e, Numbers Номера)
        {
        

         
        }
        public void Stocks()
        {
            Application.Run(new Stock());
        }
        private void переход2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(Stocks);
            thread.Start(); 
        }

        public void Number()
        {
            Application.Run(new Numbers()); 
        }

        private void переход_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tha = new Thread(Number);
            tha.Start(); 
        }

        private void Главная_Load(object sender, EventArgs e)
        {
            
        }
        
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(openForm);
            thread.Start();
        }
        public void openForm()
        {
            Application.Run(new Contact());
        }

        public void openForm1 ()
        {
            Application.Run(new Authorization());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание! Вы вышли из аккаунта!");
           this.Close();
            var thread = new Thread(openForm1);
            thread.Start();
           
        }

        
        public void OpenForm() 
        { 
            Application.Run(new Events());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(OpenForm); thread.Start();
        }
    }
}
