using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AmableQuishpePromBurgers.Models;

namespace AmableQuishpePromBurgers.Controllers
{
    public class BurgesController : Controller
    {
        private readonly PromBurgersContext _context;

        public BurgesController(PromBurgersContext context)
        {
            _context = context;
        }

        // GET: Burges
        public async Task<IActionResult> Index()
        {
            return View(await _context.Burges.ToListAsync());
        }

        // GET: Burges/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burges = await _context.Burges
                .FirstOrDefaultAsync(m => m.BurgesId == id);
            if (burges == null)
            {
                return NotFound();
            }

            return View(burges);
        }

        // GET: Burges/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Burges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BurgesId,Name,WithCheese,Price")] Burges burges)
        {
            if (ModelState.IsValid)
            {
                _context.Add(burges);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(burges);
        }

        // GET: Burges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burges = await _context.Burges.FindAsync(id);
            if (burges == null)
            {
                return NotFound();
            }
            return View(burges);
        }

        // POST: Burges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BurgesId,Name,WithCheese,Price")] Burges burges)
        {
            if (id != burges.BurgesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(burges);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BurgesExists(burges.BurgesId))
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
            return View(burges);
        }

        // GET: Burges/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burges = await _context.Burges
                .FirstOrDefaultAsync(m => m.BurgesId == id);
            if (burges == null)
            {
                return NotFound();
            }

            return View(burges);
        }

        // POST: Burges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var burges = await _context.Burges.FindAsync(id);
            if (burges != null)
            {
                _context.Burges.Remove(burges);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BurgesExists(int id)
        {
            return _context.Burges.Any(e => e.BurgesId == id);
        }
    }
}
