using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class adminSelection : Form
    {
        public adminSelection()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string client = adm.Text;

            SQLiteConnection connection = new SQLiteConnection("Data Source=DBshka.db;");
            SQLiteConnection DB = new SQLiteConnection(connection);
            DB.Open();
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Usersa SET admin = 1 WHERE id_client = @id_client", DB);

            
                // Добавление параметра в команду
                cmd.Parameters.AddWithValue("@id_client", client);

                // Выполнение команды
                cmd.ExecuteNonQuery();

             MessageBox.Show("Вы успешно назначили администратора отеля! Поздравьте его с новой должностью");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string client = delAdmin.Text;

            SQLiteConnection connection = new SQLiteConnection("Data Source=DBshka.db;");
            SQLiteConnection DB = new SQLiteConnection(connection);
            DB.Open();
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Usersa SET admin = 0 WHERE id_client = @id_client", DB);


            // Добавление параметра в команду
            cmd.Parameters.AddWithValue("@id_client", client);

            // Выполнение команды
            cmd.ExecuteNonQuery();

            MessageBox.Show("Вы успешно отозвали сотрудника от должности! Оповестите его, что он больше не является администратором :(");
            this.Close();
        }
    }
}
