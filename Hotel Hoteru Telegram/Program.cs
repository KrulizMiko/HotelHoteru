using Telegram.Bot;
using System.IO;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;

namespace TelegramBot
{
    class Program
    {
        public static async Task UpdateHandler(TelegramBotClient Up, Update Date, CancellationToken Token)
        {
            //обработчик обновления
            try
            {
                switch (Date.Type)
                {
                    case UpdateType.Message:
                        {
                            Console.WriteLine("Пришло сообщение от клиента!");
                            return;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }

        public static TelegramBotClient bot;

        [Obsolete]
        static void Main(string[] args)
        {
            bot = new TelegramBotClient("6937445762:AAEFcWQadZh-52YthmLre3aBFNXS9Kv6i00");
            bot.OnMessage += Bot_OnMessageReceived;
            bot.StartReceiving();

            var me = bot.GetMeAsync().Result;
            Console.WriteLine($"bot id: {me.Id}. Bot name: {me.FirstName}"); //консоль выводит данные бота из телеграмма
            Console.ReadKey();

           
        }

        private static async void Bot_OnMessageReceived(object sender, MessageEventArgs args)
        {
          

            var message = args.Message;



            var keyboard = new ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                    new[]
                    {
                        new KeyboardButton("хуй"),
                        new KeyboardButton("хуй1")
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
        public static Task HandleUpdateAsync(Update update, CancellationToken cancellationToken)
        {
            if (update.Type == UpdateType.Message)
            {
                Message message = update.Message; //получения сообщений 

                Console.WriteLine($"Idishka: {message.From.Id}");
                Console.WriteLine($"username: {message.From.Username}");
                Console.WriteLine($"Текст Сообщения: {message.Text}");
                Console.WriteLine(message);

            }

            return Task.CompletedTask;
        }
    }
}