using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using telega_bot.Models;

namespace telega_bot.Controllers
{
    [Route("api/message")]
    [ApiController]
    public class MessageController : ApiC
    {
    }
    
}
