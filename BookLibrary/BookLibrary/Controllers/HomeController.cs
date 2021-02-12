using BookLibrary.Models;
using BookLibrary.Repository;
using BookLibrary.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewBookAlertConfig _newBookAlertconfiguration;
        private readonly NewBookAlertConfig _thirdPartyBookconfiguration;
        private readonly IMessageRepository _messageRepository;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;

        public HomeController(IOptionsSnapshot<NewBookAlertConfig> newBookAlertconfiguration,
            IMessageRepository messageRepository,
            IUserService userService,
            IEmailService emailService)
        {
            _newBookAlertconfiguration = newBookAlertconfiguration.Get("InternalBook");
            _thirdPartyBookconfiguration = newBookAlertconfiguration.Get("ThirdPartyBook");
            _messageRepository = messageRepository;
            _userService = userService;
            _emailService = emailService;
        }
        public async Task<ViewResult> Index()
        {
            //UserEmailOptions options = new UserEmailOptions
            //{ 
            //    ToEmails = new List<string>() { "test@gmail.com"},
            //    PlaceHolders = new List<KeyValuePair<string, string>>()
            //    { 
            //        new KeyValuePair<string, string>("{{UserName}}", "Sandeep")                
            //    }

            //};
            //await _emailService.SendTestEmail(options);

            //var userId = _userService.GetUserId();
            //var isLoggedIn = _userService.IsAuthencated();
            //bool isDisplay = _newBookAlertconfiguration.DisplayNewBookAlert;
            //bool isDisplay1 = _thirdPartyBookconfiguration.DisplayNewBookAlert;
            //var newBook = configuration.GetSection("NewBookAlert");
            //var result = newBook.GetValue<bool>("DisplayNewBookAlert");
            //var bookName = newBook.GetValue<string>("BookName");
            //var result = configuration["AppName"];
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
