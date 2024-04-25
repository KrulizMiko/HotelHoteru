using System;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HotelHoteru
{
    public partial class Registration : Form
    {
         
        public Registration()
        {
            InitializeComponent();
        }
        public void openForm7()
        {
            Application.Run(new Home());
        }
        public void openForm()
        {
            Application.Run(new Home());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(openForm);
            thread.Start();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
            tPassword.PasswordChar = '*';// при вводе, символы скрыты
        }

        private void Registration_Load(object sender, EventArgs e)
        {
           
        }    

        private void tMail_TextChanged(object sender, EventArgs e)
        {


        }

        private void tConfirmation_TextChanged(object sender, EventArgs e)
        {
            tConfirmation.PasswordChar = '*';// при вводе, символы скрыты
        }

        private void for_SQLite_Click_1(object sender, EventArgs e)
        {
            #region запись клиентов в базу данных
            //БАЗА ДАННЫХ В DB BROWSER FOR SQLITE
            string connection = "Data Source=DBshka.db;";
            SQLiteConnection DB = new SQLiteConnection(connection);
            DB.Open();
            var Nam = tName.Text;
            var surnam = tSurname.Text;
            var Vurname2 = tSurname2.Text;
            var Mail = tMail.Text;  //переменные данные об клиенте (данные из полей)
            var Password = tPassword.Text;
            var Country = tCountry.Text;    //Значение переменных
            
            SQLiteCommand command = new SQLiteCommand("INSERT INTO Usersa(Name, surname, Vurname2, Mail, Password, Country, admin ) " +
                "VALUES (@Name, @surname, @Vurname2, @Mail, @Password, @Country, @admin)", DB);
            command.Parameters.AddWithValue("@Name", tName.Text);
            command.Parameters.AddWithValue("@surname", tSurname.Text);
            command.Parameters.AddWithValue("@Vurname2", tSurname2.Text);
            command.Parameters.AddWithValue("@Mail", tMail.Text);         //Заполняет поля: из поля tMail.Text в таблицу Usersa в колонку Mail
            command.Parameters.AddWithValue("@Password", tPassword.Text);
            command.Parameters.AddWithValue("@Country", tCountry.Text);
            command.Parameters.AddWithValue("@admin", 0);//для колонки Администраторов
            command.ExecuteNonQuery();
            //регистрация данных клиента
            DB.Close();
            //БАЗА ДАННЫХ В DB BROWSER FOR SQLITE
            #endregion

            MessageBox.Show("Вы успешно зарегестрировались! Приятных покупок!");
            this.Close();
            var thread = new Thread(openForm7);
            thread.Start();
        }
    }
}
