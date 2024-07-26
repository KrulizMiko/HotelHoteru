using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelHoteru
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подробности про данное мероприятие 1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Светлый просторный зал станет лучшей площадкой для вашего семинара или деловой встречи");
            MessageBox.Show("О ЗАЛЕ\r\nУдобная мебель создает для участников мероприятия все условия для комфортного расположения. Интерьер выполнен в нейтральных светлых тонах. Естественное и искусственное освещение. Центральное кондиционирование. Современное оборудование");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Подойдет для деловых встреч, семинаров, мастер-классов, презентаций, переговоров");
            MessageBox.Show("О ЗАЛЕ\r\nУдобная мебель создает для участников мероприятия все условия для комфортного расположения. Интерьер выполнен в нейтральных пастельных тонах. Хорошее освещение. Центральное кондиционирование. Современное оборудование. Зал предполагает несколько вариантов рассадки");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Реализуйте любые идеи на выставочной площадке");
            MessageBox.Show("О ЗАЛЕ\r\nВыставочная площадка, площадью 412 кв.м, прекрасно подойдет для проведения крпуномасштабного мероприятия: будь-то концерт или бизнес-презентация.\r\n\r\n Расчитан на 200 человек. ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проведите деловую встречу с комфортом");
            MessageBox.Show("О ЗАЛЕ\r\nЗал подходит для деловых встреч различного характера. Удобная мебель с комфортом разместит до 40 участников встречи, возможны различные варианты рассадки. Теплые тона интерьера не отвлекают, создают уютную атмосферу, а хорошее освещение позволяет сконцентрироваться на деталях");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проведите мероприятие в просторном зале");
            MessageBox.Show("О ЗАЛЕ\r\nОптимальный конференц зал на 200 человек в Москве для успешного и престижного мероприятия: стильный дизайн интерьера, отличное освещение, современное оборудование, удобная мебель, хорошая звукоизоляция, центральное кондиционирование");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проведите мероприятие любого формата и масштаба");
            MessageBox.Show("О ЗАЛЕ\r\nВ нашем отеле вы найдете просторный зал для реализации любых ваших идей! А наша команда будет рада помочь вам с организацией. Расчитан на 100 человек.");
        }

        private void Events_Load(object sender, EventArgs e)
        {

        }
    }
}
