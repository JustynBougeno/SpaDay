using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class SpaController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/spa")]
        public IActionResult Menu(string skintype, string manipedi)
        {
            Client newClient = new Client(skintype, manipedi);
            newClient.SetFacials(newClient.SkinType);
            ViewBag.client = newClient;
            return View();
        }
    }
}
