using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApartmentBillingSystem.Application.Services.Interfaces;
using ApartmentBillingSystem.Application.ViewModels;
using ApartmentBillingSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApartmentBillingSystem.Web.Controllers
{
    [Route("[controller]")]
    public class BillController : Controller
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        public IActionResult Create()
        {
            // Daire listesi gibi veriler ViewBag ile gönderilebilir
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BillCreateViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var bill = new Bill
            {
                ApartmentId = model.ApartmentId,
                BillType = model.BillType,
                Amount = model.Amount,
            };

            await _billService.AddAsync(bill);
            return RedirectToAction("Index");
        }

    }
}