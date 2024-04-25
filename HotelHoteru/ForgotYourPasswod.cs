using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Threading;
using System.Data.SQLite;

namespace HotelHoteru
{
    public partial class ForgotYourPasswod : Form
    {
        public ForgotYourPasswod()
        {
            InitializeComponent();
        }

     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void mail_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            string text = mail.Text;

            mail.Text = text;
        }

        public void OpenForm()
        {
            Application.Run(new Home());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region запись клиентов, кто забыл пароль
            //сравнение кода из почты с полем
            //БАЗА ДАННЫХ В DB BROWSER FOR SQLITE
            string connection = "Data Source=DBshka.db;data=UPDLOCKED;";
            SQLiteConnection DB = new SQLiteConnection(connection);
            DB.Open();
            var mai = mail.Text;
            var cod = textBox1.Text;

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Client_Forgot_Password(mail, invate_code) " +
                "VALUES (@mail, @invate_code)", DB);
         
            cmd.Parameters.AddWithValue("@mail", mail.Text);
            cmd.Parameters.AddWithValue("@invate_code", textBox1.Text);
            cmd.ExecuteNonQuery();
            DB.Close();//запись по нажатию кнопки Восстановить


            MessageBox.Show("Вы успешно восстановили свой аккаунт! Приятных покупок!");
            this.Close();
            var thread = new Thread(OpenForm);
            thread.Start();
            #endregion

        }

        private void code_Click(object sender, EventArgs e)
        {
            #region отправка подтверждения кода на почту клиента, который забыл пароль
            
            string FromEmail = mail.Text;
            string toEmile = mail.Text;

            Random ranf = new Random();
            int FromMail = ranf.Next(1000);// рандомные числа в почте
            //присвоения переменных 

            string Subject = "Вы забыли пароль в нашем отеле?";
            string body = $"Здравствуйте,вам выслали код для восстанавления аккаунта в Hotel Hoteru. Ваш код подтверждения: {FromMail}";

            //решение проблемы через метод примера от Microsoft
           

            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress(FromEmail);
                mailMessage.To.Add(toEmile);
                mailMessage.Subject = Subject;
                mailMessage.Body = body;

                var SmtpClient = new SmtpClient("smtp.gmail.com", 587);


                //аунтификация для отправки кода клиенту

                SmtpClient.Credentials = new NetworkCredential("philipinnoreddi@gmail.com", "znhn wqxv cbcq zvxg");
                SmtpClient.EnableSsl = true;
                SmtpClient.Send(mailMessage);

            }
            MessageBox.Show("Ваш код отправлен!Проверте почту.");
            #endregion

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgotYourPasswod_Load(object sender, EventArgs e)
        {

        }
    }
}
