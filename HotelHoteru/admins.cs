using DocumentFormat.OpenXml.Office.Word;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class openForm99 : Form
    {
        public openForm99()
        {
            InitializeComponent();
        }

        private void admins_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView1();
        }

        private void LoadDataIntoDataGridView1()
        {
            // обновление в базе данных
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=DBshka.db");
                SQLiteConnection DB = new SQLiteConnection(connection);
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("SELECT * FROM Usersa", DB);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ооооой, ошибочка" + ex.Message);
            }

        }
        public void plusik()
        {
            Application.Run(new PLUSclient());
        }
        public void openHome ()
        {
            Application.Run(new Home());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread = new Thread(openHome);
            thread.Start();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=DBshka.db");
                SQLiteConnection DB = new SQLiteConnection(connection);
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("SELECT * FROM Usersa", DB);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка обновления!!!" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //переход на форму добавить 
            Thread thread = new Thread(plusik);
            thread.Start();
        }
        public void deli()
        {
            Application.Run(new delete_client());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(deli);
            thread.Start(); 
        }

        public void sele()
        {
            Application.Run(new adminSelection());   
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(sele);
            thread.Start(); 
        }
    }
}
