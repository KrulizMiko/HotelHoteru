using Telegram.Bot;
using System.IO;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using System.Data.SQLite;
using Telegram.Bot.Polling;
using System.Diagnostics.CodeAnalysis;
using System.Data.Entity;
using System.Data.SqlClient;
using Telegram.Bot.Exceptions;
using static System.Formats.Asn1.AsnWriter;
using System.Runtime.CompilerServices;
using System.Net.Http;
using System.Net.WebSockets;

namespace TelegramBot
{
    class Program
    {
        private static ITelegramBotClient bot;
        private static TelegramBotClient boti;
        private static ReceiverOptions receiverOptions;

        /*
                [ReplyMenuHandler("Пошел нахуй")]
                public static async Task TestMethod(ITelegramBotClient bot, Update upd)
                {
                    string msg = "Ахуел чтоли";
                    await PRTelegramBot.Halpers.Message.Send(bot, upd, msg);
                }
         * 
         * 
          private readonly TelegramBotClientOptions _options;
          private readonly HttpClient _httpClient;
          public TelegramBotClient(TelegramBotClientOptions options, HttpClient? httpClient = default)
          {
              if (httpClient == null)
              {
                  throw new ArgumentNullException(nameof(httpClient));
              }
              _options = options;

              if (httpClient == null)
              {
                  try
                  {
                      _httpClient = new HttpClient();
                  }
                  catch (Exception ex)
                  {
                      throw new InvalidOperationException("Не удалось создать HttpClient.", ex);
                  }
              }
              else
              {
                  _httpClient = httpClient;
              }
              return;//каво блять тебе надо вернуть
          }

          /*
           * public static TelegramBotClient(TelegramBotClientOptions options, HttpClient? httpClient = default)
          {
              _options = options ?? throw new ArgumentNullException(nameof(options));
              _httpClient = httpClient ?? new HttpClient();
          } //для фикса системной ошибки исключения

           */

        static async Task Main()
        {
            using var cts = new CancellationTokenSource();
            bot = new TelegramBotClient("6937445762:AAEFcWQadZh-52YthmLre3aBFNXS9Kv6i00");

            bot.StartReceiving(UpdateHandler, ErrorHandler, receiverOptions, cts.Token);//стартуем


            var me = bot.GetMeAsync().Result;
            Console.WriteLine($"Айдишка бота:{me.Id}. Имя бота:{me.FirstName}");


            Console.ReadLine();


            Task.Delay(-1);

            //че за ху
        }



        private static Task ErrorHandler(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apier
                => $"Ошибка ключа API:\n{apier.ErrorCode}\n{apier.Message}",
                _ => exception.ToString()
            };
            Exception ex = new Exception(ErrorMessage);
            Console.WriteLine(ex.ToString);

            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }

        private static async Task UpdateHandler(ITelegramBotClient client, Update update, CancellationToken token)
        {
            Console.WriteLine($"Пользователь '{update.Message.Chat.@Username}' Отправил сообщение '{update.Message.Text}' в чате '{update.Message.Chat.Id}'");
            try
            {

                #region Запись пользователя в базу данных
                try
                {
                    if (update.Message.Text != null)
                    {
                        if (update.Message.Text.ToLower() == "/start")
                        {
                            SQLiteConnection DB = new SQLiteConnection("Data Source=Clients_users.db;Mode=ReadWrite;");
                            DB.Open();

                            string query = "insert into Users(Tg_Id, Nickname, Username, Date_reg, Phone_number) values (@Id, @Nik, @User, @Date, @Num);";
                            SQLiteCommand cmd = new SQLiteCommand(query, DB);
                            cmd.Parameters.AddWithValue("@Id", update.Message.Chat.Id);
                            cmd.Parameters.AddWithValue("@Nik", update.Message.Chat.FirstName);
                            cmd.Parameters.AddWithValue("@User", update.Message.Chat.@Username);
                            cmd.Parameters.AddWithValue("Num", update.Message.Chat.Bio);
                            cmd.Parameters.AddWithValue("Date", DateTime.Now.ToString());
                            cmd.ExecuteNonQuery();

                            DB.Close();
                            Console.WriteLine($"Пользователь {update.Message.Chat.FirstName} был записан в базу данных!");
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("Произошла ошибка Базы Данных:\n" + ex.ToString()); }
                #endregion

             






                /*
                var inlineMarkup = new InlineKeyboardMarkup()
    .AddNewRow("1.1", "1.2", "1.3")
    .AddNewRow()
        .AddButton("WithCallbackData", "CallbackData")
        .AddButton(InlineKeyboardButton.WithUrl("WithUrl", "https://github.com/TelegramBots/Telegram.Bot"));
                await bot.SendTextMessageAsync(update.Message.Chat.Id, "Inline buttons:", replyMarkup: inlineMarkup);
                */


                var main = new ReplyKeyboardMarkup(new[]
                {
                new[]
                {
                    new KeyboardButton("Номера"),
                    new KeyboardButton("Контакты"),
                    new KeyboardButton("Акции"),
                },
                new[]
                {
                    new KeyboardButton("Мероприятия"),
                    new KeyboardButton("Профиль")
                },

            })
                {
                    ResizeKeyboard = true //как легко и просто
                };



                #region Кнопка Номера
                var Number = new ReplyKeyboardMarkup(new[]
                {
                    new[]
                    {
                        new KeyboardButton("Стандарт"),
                        new KeyboardButton("Бизнес"),
                        new KeyboardButton("Люкс")
                    }
                })
                {
                    ResizeKeyboard = true
                };
                var KeyboardSwitch = new ReplyKeyboardMarkup(new[]
                {
                    new[]
                    {
                        new KeyboardButton("Отмена"),
                        new KeyboardButton("Забронировать"),
                        new KeyboardButton("След.номер")
                    }
                })
                { ResizeKeyboard = true };
                #endregion

               

                /*
                var InlineSwitch = new InlineKeyboardMarkup(new[]
                {
                new[]//гоано код
                {
                    InlineKeyboardButton.WithCallbackData("exeОтмена", "callbackquerySwitch0"),
                    InlineKeyboardButton.WithCallbackData("exeЗабронировать","callbackquerySwitch1"),
                    InlineKeyboardButton.WithCallbackData("exeСлед.номер", "callbackquerySwitch2"  )
                }
            });

               
                    var inlineKeyboard = new InlineKeyboardMarkup(new[]
                               {
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData("1", "GoVKB"),
                        InlineKeyboardButton.WithCallbackData("Yandex open", "https://www.yandex.ru/"),
                    },
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData("Google open", "https://www.google.com/"),
                        InlineKeyboardButton.WithCallbackData("Bing open", "https://www.bing.com/"),
                    },
                });
                */

                var callbackQu = update.CallbackQuery;
                var chatT = callbackQu.Message.Chat;
               
               var chat = update.Message.Chat;
 



                var InlineKeyboardMarkup = new InlineKeyboardMarkup(
                    new List<InlineKeyboardButton[]>()
                    //Каждый новй массив - это доп. строки,
                    //Каждая доп,строка(кнопка) в массиве - это добавление рядв 
                {
                new InlineKeyboardButton[]
                {
                   InlineKeyboardButton.WithCallbackData("Например0", "callbackquery0"),
                   InlineKeyboardButton.WithCallbackData("Например1", "callbackquery1"),
                   InlineKeyboardButton.WithCallbackData("Например2", "callbackquery2")
                }
                });
                await bot.SendTextMessageAsync(chatT.Id,
                                    text: "Здравствуй,дорогой наш клиент! Вас приветствует бот отеля Hotel Hoteru!",
                                    replyMarkup: InlineKeyboardMarkup); 

                  

                try
                {

                    if (UpdateType.CallbackQuery != null)
                    {
                        
                        switch (callbackQu.Data) //только для обработки inline button
                        {
                          
                                
                            case "callbackquery0":
                                // В этом типе клавиатуры обязательно нужно использовать следующий метод
                                await bot.AnswerCallbackQueryAsync(callbackQu.Id);
                                // Для того, чтобы отправить телеграмму запрос, что мы нажали на кнопку

                                await bot.SendTextMessageAsync(
                                    chatT.Id,
                                    $"Вы нажали на {callbackQu.Data}");
                                return;

                            case "callbackquery1":
                                {
                                    // В этом типе клавиатуры обязательно нужно использовать следующий метод
                                    await bot.AnswerCallbackQueryAsync(callbackQu.Id);
                                    // Для того, чтобы отправить телеграмму запрос, что мы нажали на кнопку

                                    await bot.SendTextMessageAsync(
                                        chatT.Id,
                                        $"Вы нажали на {callbackQu.Data}");
                                    return;
                                }

                            case "callbackquery2":
                                {
                                    // В этом типе клавиатуры обязательно нужно использовать следующий метод
                                    await bot.AnswerCallbackQueryAsync(callbackQu.Id);
                                    // Для того, чтобы отправить телеграмму запрос, что мы нажали на кнопку

                                    await bot.SendTextMessageAsync(
                                        chatT.Id,
                                        $"Вы нажали на {callbackQu.Data}");
                                    return;
                                }

                        }
                    }
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());   
                } 
                




                switch (update.Message.Text)
                {
                  

                    case "/start":
                        await bot.SendTextMessageAsync(chatId: update.Message.Chat.Id,
                            text: "Здравствуй,дорогой наш клиент! Вас приветствует бот отеля Hotel Hoteru!",
                            replyMarkup: main); break;

                    case "Номера":
                        await bot.SendTextMessageAsync(update.Message.Chat.Id,
                            text: "В нашем отеле вы можете выбрать 3 номера\n",
                            replyMarkup: Number); break;
                    case "Контакты":
                        await bot.SendTextMessageAsync(chatId: update.Message.Chat.Id,
                            text: "Наши контакты:\nМы находимся по адресу: г.Ижевск",
                            replyMarkup: main); break;
                    case "Акции":
                        await bot.SendTextMessageAsync(chatId: update.Message.Chat.Id,
                            text: "В разделе Акции нацелена на ваше бронирование! Нам важно чтобы наши клиенты оставались в достатке",
                            replyMarkup: main); break;
                    case "Мероприятия":
                        await bot.SendTextMessageAsync(chatId: update.Message.Chat.Id,
                            text: "Чтобы ваше бронирование прошло весело, в нашем отели проходят разные мероприятия: на ваш вкус и цвет.",
                            replyMarkup: main); break;
                   
                    case "Профиль": break;
                     //сдесь чето будет по типу авторизацию и регистрации
                    //Возможно добавлю логику для проверки данных в бд
                   //вот сдесь надо придумать что небудь для авторизации(тк WinForms и Бот будут в одном проекте)
                  //бд будет одна и таже, таблицы данных будут разные
                 //возможно нужно сделать регистрацию с синхронизацией с веб приложением
                //это же один проект, с интеграцией в тг


                    case "Стандарт":
                        await bot.SendTextMessageAsync(update.Message.Chat.Id,
                            text: $"Инфо по номеру Стандарто==Опа",
                            replyMarkup: KeyboardSwitch); break;
                    case "Бизнес":
                        await bot.SendTextMessageAsync(update.Message.Chat.Id,
                        text: $"Инфо по номеру БизнесШл==sda",
                        replyMarkup: KeyboardSwitch); break;
                    case "Люкс":
                        await bot.SendTextMessageAsync(update.Message.Chat.Id,
                        text: $"Инфо по номеру Люксенько==Последний",
                        replyMarkup: KeyboardSwitch); break;
                    /*
                                case "Cancel":
                                    await bot.DeleteMessageAsync(
                                        chatId: callbackQu.Message.Chat.Id,
                                        messageId: callbackQu.Message.MessageId); break;
                                case "Book":
                                    await bot.SendTextMessageAsync(
                                        chatId: callbackQu.Message.Chat.Id,
                                        text: "Вы успешно забронировали выбранный номер!");
                                    break;
                                case "Next":
                                    await bot.SendTextMessageAsync(chatId: callbackQu.Message.Chat.Id, text: "Следующий номер:\n");
                                    break;
                     */
                    case "Отмена":
                        await bot.DeleteMessageAsync(chatId: update.Message.Chat.Id,
                        messageId: update.Message.MessageId);
                        await bot.SendTextMessageAsync(update.Message.Chat.Id,
                            text: "Отменяю бронирование...",
                            replyMarkup: main); break;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString); }




















        }






























    }
}
