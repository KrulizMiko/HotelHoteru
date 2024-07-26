using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelHoteru
{
    public partial class PLUSclient : Form
    {
        public PLUSclient()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region Добавить клиента в базу данных
            string connection = "Data Source=DBshka.db;";
            SQLiteConnection DB = new SQLiteConnection(connection);
            DB.Open();
            var Nam = Name.Text;
            var surnam = Surname.Text;
            var vur = Vurname2.Text;
            var mal = mail.Text;  //переменные данные об клиенте (данные из полей)
            var pass = password.Text;    //Значение переменных
            var con = Country.Text; 

            SQLiteCommand command = new SQLiteCommand("INSERT INTO Usersa(Name, surname, Vurname2, Mail, Password, Country, admin) " +
                "VALUES (@Name, @surname, @Vurname2, @Mail, @Password, @Country, @admin) ", DB);
            command.Parameters.AddWithValue("@Name", Nam);
            command.Parameters.AddWithValue("@surname", surnam);
            command.Parameters.AddWithValue("@Vurname2", vur);
            command.Parameters.AddWithValue("@Mail", mal);         //Заполняет поля: из поля tMail.Text в таблицу Usersa в колонку Mail
            command.Parameters.AddWithValue("@Password", pass);
            command.Parameters.AddWithValue("@Country", con);
            command.Parameters.AddWithValue("@admin", 0);//цифра ноль это обычный клиент, у него не будет доступа к администрации
            command.ExecuteNonQuery();
            //регистрация данных клиента
            DB.Close();
            #endregion

            MessageBox.Show("Вы успешно добавили клиента! ");
            this.Close();

        }
    }
}
