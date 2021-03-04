using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using telega_bot.Models;

namespace telega_bot.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "its my first telegram bot";
        }
    }
}
