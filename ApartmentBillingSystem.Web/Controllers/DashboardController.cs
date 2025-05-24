using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApartmentBillingSystem.Web.Models;
using ApartmentBillingSystem.Application.Services.Interfaces;
using System.Security.Claims;
using ApartmentBillingSystem.Application.ViewModels;
using Microsoft.AspNetCore.Identity;
using ApartmentBillingSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApartmentBillingSystem.Web.Controllers;

public class DashboardController : Controller
{

    private readonly IUserService _userService;
    private readonly UserManager<ApplicationUser> _userManager;

    public DashboardController(IUserService userService, UserManager<ApplicationUser> userManager)
    {
        _userService = userService;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var userId = _userManager.GetUserId(User);
      
        var viewModel = await _userService.GetUserDashboardViewInfoAsync(int.Parse(userId));
        return View(viewModel);
    }

    

}
