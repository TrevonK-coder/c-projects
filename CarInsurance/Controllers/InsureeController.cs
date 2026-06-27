using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private readonly InsuranceDbContext _context;

        public InsureeController(InsuranceDbContext context)
        {
            _context = context;
        }

        // GET: Insuree
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // GET: Insuree/Admin
        // Custom action for site administrators to view all quotes issued,
        // displaying first name, last name, email address, and monthly quote
        public async Task<IActionResult> Admin()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // GET: Insuree/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insuree/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Calculate the quote value based on the business rules before saving
                insuree.Quote = CalculateQuote(insuree);

                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Recalculate the quote value based on the updated business rules before saving
                    insuree.Quote = CalculateQuote(insuree);

                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(int id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }

        // Core business logic to calculate the monthly insurance quote
        public static decimal CalculateQuote(Insuree insuree)
        {
            // Start with a base of $50 / month
            decimal quote = 50m;

            // Calculate precise age based on date of birth
            int age = DateTime.Today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            // Age brackets
            if (age <= 18)
            {
                quote += 100m; // If the user is 18 or under, add $100
            }
            else if (age >= 19 && age <= 25)
            {
                quote += 50m;  // If the user is from 19 to 25, add $50
            }
            else
            {
                quote += 25m;  // If the user is 26 or older, add $25
            }

            // Car Year rules
            if (insuree.CarYear < 2000)
            {
                quote += 25m;  // If the car's year is before 2000, add $25
            }
            else if (insuree.CarYear > 2015)
            {
                quote += 25m;  // If the car's year is after 2015, add $25
            }

            // Car Make & Model rules
            if (insuree.CarMake != null && insuree.CarMake.Equals("Porsche", StringComparison.OrdinalIgnoreCase))
            {
                quote += 25m;  // If the car's Make is a Porsche, add $25
                if (insuree.CarModel != null && insuree.CarModel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
                {
                    quote += 25m;  // If Model is a 911 Carrera, add an additional $25 (total $50 for Make/Model)
                }
            }

            // Speeding tickets rule: Add $10 for every speeding ticket
            quote += insuree.SpeedingTickets * 10m;

            // DUI rule: If ever had a DUI, add 25% to the total
            if (insuree.DUI)
            {
                quote += quote * 0.25m;
            }

            // Coverage type: If user wants full coverage, add 50% to the total
            if (insuree.CoverageType != null && insuree.CoverageType.Equals("Full", StringComparison.OrdinalIgnoreCase))
            {
                quote += quote * 0.50m;
            }

            return quote;
        }
    }
}
