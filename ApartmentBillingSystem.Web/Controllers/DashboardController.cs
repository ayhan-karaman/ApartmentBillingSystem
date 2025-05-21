using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApartmentBillingSystem.Web.Models;
using ApartmentBillingSystem.Application.Services.Interfaces;
using System.Security.Claims;
using ApartmentBillingSystem.Application.ViewModels;

namespace ApartmentBillingSystem.Web.Controllers;

public class DashboardController : Controller
{

    private readonly IUserService _userService;

    public DashboardController(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<IActionResult> Index()
    {
        var userId = 1;
        var user = await _userService.GetUserByIdAsync(userId);
        var viewModel = new UserDashboardViewModel
        {
            FullName = user.FullName,
            Email = user.Email,
            ApartmentBlock = Convert.ToString(user.ApartmentId),
            
        };
        return View(viewModel);
    }

}
