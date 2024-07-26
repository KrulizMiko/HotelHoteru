using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace HotelHoteru
{
  internal class TG_Bot
    {
        static TelegramBotClient bot = new TelegramBotClient("6937445762:AAEFcWQadZh-52YthmLre3aBFNXS9Kv6i00");
        public delegate void ThreadStart();

        [Obsolete]
        static void BOTСom()//не работает 
          //не компелируется параллельно этот файлик БОТА

        {
            bot = new TelegramBotClient("6937445762:AAEFcWQadZh-52YthmLre3aBFNXS9Kv6i00");
            bot.OnMessage += Bot_OnMessageReceived;
            bot.StartReceiving();

            var me = bot.GetMeAsync().Result;
            Console.WriteLine($"bot id: {me.Id}. Bot name: {me.FirstName}"); //консоль выводит данные бота из телеграмма
            Console.ReadKey();

        }

        private static async void Bot_OnMessageReceived(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            var keyboard = new ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                    new[]
                    {
                        new KeyboardButton("люкс"),
                        new KeyboardButton("стандарт") //это кнопачки в боте
                    },
                },
                ResizeKeyboard = true
            };
            switch (message.Text)
            {
                case "/start":
                    await bot.SendTextMessageAsync(message.From.Id, "Здравствуй,дорогой наш клиент! Вас приветствует бот отеля Hotel Hoteru!", replyMarkup: keyboard);
                    break;
            }


        }
    }
}
