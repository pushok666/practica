using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using telega_bot.Models.Commands;

namespace telega_bot.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<ClasCommand> commandsList;

        public static IReadOnlyList<ClasCommand> clasCommands { get => commandsList.AsReadOnly(); }
        public static async Task<TelegramBotClient> Get()
        {
            if (client!=null)
            {
                return client;
            }

            commandsList = new List<ClasCommand>();
            commandsList.Add(new HelloCommand());

            //TODO  add more commands

            client = new TelegramBotClient(AppSettings.Key);
            await client.SetWebhookAsync("");

            return client;
        }
    }
}
