using System;
using System.Windows.Forms;
using System.Threading;
using System.Data.SQLite;

namespace HotelHoteru
{
    public partial class booking : Form
    {
        public void hom()
        {
            Application.Run(new Home());
        }
        public booking()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tPassword_TextChanged(object sender, EventArgs e)
        {
          this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tMail_TextChanged(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            #region запись бронирования
         
            string connection = "Data Source=DBshka.db;";
            SQLiteConnection DB = new SQLiteConnection(connection);
            
            var name = bName.Text;
            var surna = bSur.Text;
            var vur = bVurname2.Text;
            var mail = bMail.Text;
            var num = bNum.Text;
            var booking = numBook.Text;//выбор номера в комбо
                                       //присвоение переменных
            DB.Open();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO Booking(Name, Surname, Vurname2, Mail, Number_phone, booking) " +
                "VALUES (@Name, @surname, @Vurname2, @Mail, @Number_phone, @booki)", DB);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@surname", surna);
            command.Parameters.AddWithValue("@Vurname2", vur);
            command.Parameters.AddWithValue("@Mail", mail);         
            command.Parameters.AddWithValue("@Number_phone", num);
            command.Parameters.AddWithValue("@booki", booking);
            command.ExecuteNonQuery();
            //регистрация данных клиента
            DB.Close();
            #endregion
            //добавить отправку на почту клиенту об его бронирования

            MessageBox.Show("Вы успешно зарбронировались! Ждем вас в нашем клубе!");
            this.Close();
            Thread thread = new Thread(hom);
            thread.Start();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
                   
        }

        private void booking_Load(object sender, EventArgs e)
        {

        }
    }
}
