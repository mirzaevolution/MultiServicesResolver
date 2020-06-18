using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MultiServicesResolver.Models;
using MultiServicesResolver.Services;
namespace MultiServicesResolver.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWelcomeService _usWelcomeService;
        private readonly IWelcomeService _idWelcomeService;
        public HomeController(IServiceProvider serviceProvider)
        {
            _usWelcomeService = serviceProvider.GetService<WelcomeServiceUS>();
            _idWelcomeService = serviceProvider.GetService<WelcomeServiceID>();
        }
        public IActionResult WelcomeID()
        {
            return View((object)_idWelcomeService.GetMessage());
        }
        public IActionResult WelcomeUS()
        {
            return View((object)_usWelcomeService.GetMessage());
        }

    }
}
