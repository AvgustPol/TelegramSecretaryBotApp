using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramSecretaryBotApp.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var massageId = message.MessageId;

            //Here must be logic of bots execution for more complicated methods

            //воспользуемся клиентом, что бы отправить текстовое сообщение.
            client.SendTextMessageAsync(chatId, "Hello!", replyToMessageId: massageId);
        }
    }
}