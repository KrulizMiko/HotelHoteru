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

namespace HotelHoteru
{
    public partial class delete_client : Form
    {
        public delete_client()
        {
            InitializeComponent();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            //скрипт для удаления клиента

            SQLiteConnection connection = new SQLiteConnection("Data Source=DBshka.db;");
            SQLiteConnection DB = new SQLiteConnection(connection);
            DB.Open();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Usersa where id_client = @id_client", DB);
            cmd.Parameters.AddWithValue("@id_client", del.Text);
            int provka = cmd.ExecuteNonQuery();
            if (provka > 0)
            {
                MessageBox.Show($"Вы успешно удалили клиента под номером {del.Text}");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Клиент под номером {del.Text} не найден");
            }
            this.Close();
        }
    }
}
