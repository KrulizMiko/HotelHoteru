using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
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

        public void openForm2 ()
        {
            Application.Run (new ForgotYourPasswod());   
        }

        public void openForm9 ()
        {
            Application.Run (new openForm99());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(openForm2);
            thread.Start(); 
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';// при вводе, символы скрыты
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            
        }

        private void mail_TextChanged(object sender, EventArgs e)
        {
              
        }
        public void openForm3()
        {
            Application.Run(new Registration());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(openForm3);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Аутентификация клиента(данные берутся из таблицы DB Browser)
            string connection = "Data Source=DBshka.db;";
            SQLiteConnection DB = new SQLiteConnection(connection);
            DB.Open();
            string query = "SELECT admin " +
                "FROM Usersa " +
                "WHERE Mail = @Mail " +
                "AND Password = @Password";
            SQLiteCommand cmd = new SQLiteCommand(query, DB);           
                string Mail = mail.Text;
                string Password = password.Text;// присвоение переменные 
                
            cmd.Parameters.AddWithValue("@Mail", Mail);
            cmd.Parameters.AddWithValue("@Password", Password);

            // для администрации
            object Admin = cmd.ExecuteScalar();
            int roleValue = Convert.ToInt32(Admin);

            if (string.IsNullOrEmpty(mail.Text))
            { MessageBox.Show("Пожалуйста, укажите ваш адрес электронной почты!"); }

            if (string.IsNullOrEmpty(password.Text))
            { MessageBox.Show("Пожалуйста, укажите пароль!"); }
            else //если в поле mail ничего не написано
            if (Admin != null) //сравнение данных из бд с полями-это условие
                //При значении 0 , клиент входит как обычный зарегестрированный
                if (roleValue == 1)
                {

                    MessageBox.Show("Вас назначили Администратором! Переносим вас в базу данных отеля.");
                    this.Close();
                    var thread = new Thread(openForm9);
                    thread.Start(); 
                }//ДЛЯ АДМИНИСТРАТОРОВ(в бд отмечены с колконки admin с полем 1)
                else 
                { 
                    MessageBox.Show("Вы успешно вошли в аккаунт!");

                    this.Close();
                    var thread = new Thread(openForm);
                    thread.Start();
                } 
            else 
            {
                MessageBox.Show("Указанная почта или пароль неверный! Попробуйте снова");
            }
            
            
            DB.Close();
            #endregion
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
