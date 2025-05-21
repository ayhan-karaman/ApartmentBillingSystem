using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentBillingSystem.Web.Areas.Controllers.Admin
{
    [Area("Admin")]
    public class Dashboard : Controller
    {

        public IActionResult Index() => View();
    }
}