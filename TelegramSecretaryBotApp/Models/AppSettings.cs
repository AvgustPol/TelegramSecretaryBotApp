using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramSecretaryBotApp.Models
{
    public static class AppSettings
    {
        //ulr to my bot
        //конечная ссылка на бота
        public static string Url { get; set; } = "http://helpertelegrambot.azurewebsites.net/{0}";

        public static string Name { get; set; } = "Secretary_helper_bot";

        //api key of bot
        public static string Key { get; set; } = "505680090:AAHNUpIr5MEf1wiyRH2Y-ue8tpZT2YJpSWY";
    }
}