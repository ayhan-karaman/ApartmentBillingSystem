using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApartmentBillingSystem.Application.Services.Interfaces;
using ApartmentBillingSystem.Application.ViewModels;
using ApartmentBillingSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace ApartmentBillingSystem.Web.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IApartmentService _apartmentService;

        public UserController(IUserService userService, IApartmentService apartmentService)
        {
            _userService = userService;
            _apartmentService = apartmentService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetAllUsersAsync();
            return View(users);
        }

    
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var apartments = await _apartmentService.GetAllApartmentsAsync();
            ViewBag.ApartmentList = new SelectList(apartments, "Id", "Number");
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (!ModelState.IsValid)
            {
                var apartments = await _apartmentService.GetAllApartmentsAsync();
                ViewBag.ApartmentList = new SelectList(apartments, "Id", "Number");
                return View(user);
            }

            await _userService.AddUserAsync(user);
            return RedirectToAction(nameof(Index));
        }
    }
}