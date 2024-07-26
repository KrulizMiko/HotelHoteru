using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using Microsoft.Data.Sqlite;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace HotelHoteru
  
{
    internal class DataBase_for_Regist
    {
        static class BaseData
        {
            public static
            string connection = @"data Sourse=для отеля.db;";
        }
        SqliteConnection DB = new SqliteConnection(BaseData.connection);
        private void button1_Click(object sender, EventArgs e)
        {
            DB.Open();
            SqliteCommand command = new SqliteCommand($"INSERT INTO Registraton(Фамилия, Имя, Отчество, Эл.почта, Пароль, Страна, Пол) " +
                $" VALUES (tName, tNameSurname, tNameSurname2, tMail, tPasssword, tCountry, tFloor  )", DB);
            command.Parametere =   ; 
            //абро пидорасс ебаный понял понял да 
           // будешь делать дб в туалет с антошай пон да пон



        }

    }
}
