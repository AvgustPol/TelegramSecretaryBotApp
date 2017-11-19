using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using TelegramSecretaryBotApp.Models.Commands;

namespace TelegramSecretaryBotApp.Models
{
    //класс служит для первичной инициализации бота и его команд
    //class for first inicialization of bot and his commands
    public static class Bot
    {
        private static TelegramBotClient client { get; set; } 
        private static List<Command> commandsList;

        public static IReadOnlyList<Command> Commands { get => commandsList.AsReadOnly(); }

        public static async Task<TelegramBotClient> Get()
        {
            //if inicialized
            if(client != null)
            {
                return client;
            }
            #region Initializing commands
            commandsList = new List<Command>();
            commandsList.Add(new HelloCommand());
            #endregion

            

            //иначе создаем новый экземпляр с арi ключем
            client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await client.SetWebhookAsync(hook);

            return client;
        }

    }
}