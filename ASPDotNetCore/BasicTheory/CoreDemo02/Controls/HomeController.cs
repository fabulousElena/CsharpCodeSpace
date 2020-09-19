using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo02.Services;

namespace CoreDemo02.Controls
{
    public class HomeController
    {
        private readonly IMessageService _messageService;
        public HomeController(IMessageService messageService)
        {
            _messageService = messageService;
        }
    }
}
