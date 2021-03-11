using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var viewModel = new MyViewModel();
            return View("MyView", viewModel);
        }
    }
}
