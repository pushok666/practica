using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace telega_bot.Models.Commands
{
    public abstract class ClasCommand
    {
        public abstract string Name { get; }
        public abstract void Execute(Message message, TelegramBotClient client);
        public bool Contains(string command)
        {
            return command.Contains(this.Name) && command.Contains(AppSettings.Name);
        }
        
    }
}
