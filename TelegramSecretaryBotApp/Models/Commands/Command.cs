using Telegram.Bot.Types;
using Telegram.Bot;


namespace TelegramSecretaryBotApp.Models.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }

        /// <summary>
        /// Execute command
        /// </summary>
        /// <param name="message">сообщение с командой</param>
        /// <param name="client">клиент для возможности отправить ответ обратно</param>
        public abstract void Execute(Message message, TelegramBotClient client);

        //сопоставляет комманду, введенную пользователем с текущей командой.
        public bool Contains(string command)
        {
            return command.Contains(this.Name) && command.Contains(AppSettings.Name);
        }
    }
}
