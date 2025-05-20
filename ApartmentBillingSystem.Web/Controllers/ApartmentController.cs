using ApartmentBillingSystem.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Web.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly IApartmentService _apartmentService;

        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        public async Task<IActionResult> Index()
        {
            var apartments = await _apartmentService.GetAllAsync();
            return View(apartments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Apartment apartment)
        {
            if (!ModelState.IsValid)
                return View(apartment);

            await _apartmentService.AddAsync(apartment);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var apartment = await _apartmentService.GetByIdAsync(id);
            if (apartment == null)
                return NotFound();

            return View(apartment);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Apartment apartment)
        {
            if (!ModelState.IsValid)
                return View(apartment);

            await _apartmentService.UpdateAsync(apartment);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var apartment = await _apartmentService.GetByIdAsync(id);
            if (apartment == null)
                return NotFound();

            return View(apartment);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _apartmentService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
