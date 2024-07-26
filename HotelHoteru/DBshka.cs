using HotelHoteru;
using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBase
{
    class Program 
    {
        public partial class Registration : Form
        {
            public Registration()
            {
                InitializeComponent();
            }

            public void InitializeComponent()
            {
                throw new NotImplementedException();
            }

            private void Registration_Load(object sender, EventArgs e)
            {
                SqliteConnection cont;
                SqliteCommand command;
                SqlDataAdapter adap;
                DataTable Tab; //Присвоение переменных

                string databaseName = "Data Source=Db_For_Client.db;";
                cont = new SqliteConnection(databaseName);
                cont.Open(); //Соединение с бд

                //Создание таблицы в дб
                string NewTable = "CREAT TABLE IF NOT EXISTS Client(Name PRIMARY KEY, surname TEXT, email TEXT) ";
                command = cont.CreateCommand();
                command.CommandText = NewTable; 
                command.ExecuteNonQuery();
               
            } // основа формы в бд

            private void for_SQLite_click(object sender, EventArgs e)
            {
                string Name = Text;
                string surname = Text;
                string emile = Text; //переменные данные об клиенте

                

                string newClient = $"INSERT INTO Clients (name, email) VALUES ('{Name}', '{surname}', '{emile}')";
               //добавления клиентов в дб


                MessageBox.Show("Вы успешно зарегестрировались! Приятного отдыха!");
            }




        }
    }
}