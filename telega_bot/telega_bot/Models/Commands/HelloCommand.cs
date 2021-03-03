using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace telega_bot.Models.Commands
{
    public class HelloCommand : ClasCommand
    {
        public override string Name => "hello";

        public async override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO Bot logic -

            await client.SendTextMessageAsync(chatId,"Hello", replyToMessageId: messageId);
        }
    }
}
