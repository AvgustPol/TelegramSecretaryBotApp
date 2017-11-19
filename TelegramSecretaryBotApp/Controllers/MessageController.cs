using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using TelegramSecretaryBotApp.Models;

namespace TelegramSecretaryBotApp.Controllers
{
    public class MessageController : ApiController
    {
        //TODO - понять, что это и как работает
        //явное указание маршрута
        [Route(@"api/message/update")]
        //Update - api type, в котором содержится информация для бота
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();

            foreach (var command in commands)
            {
                if(command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    break;
                }
            }

            return Ok();
        }
    }
}
