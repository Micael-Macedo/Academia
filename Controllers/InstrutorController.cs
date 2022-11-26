using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Academia.Models;

namespace Academia.Controllers
{
    public class InstrutorController : Controller
    {
        private readonly ProjetoAcademiaContext _context;

        public InstrutorController(ProjetoAcademiaContext context)
        {
            _context = context;
        }

        // GET: Instrutor
        public async Task<IActionResult> Index()
        {
              return View(await _context.Instrutor.ToListAsync());
        }

        // GET: Instrutor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Instrutor == null)
            {
                return NotFound();
            }

            var instrutor = await _context.Instrutor
                .FirstOrDefaultAsync(m => m.InstrutorId == id);
            if (instrutor == null)
            {
                return NotFound();
            }

            return View(instrutor);
        }

        // GET: Instrutor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instrutor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstrutorId,Nome,Matricula")] Instrutor instrutor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instrutor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instrutor);
        }

        // GET: Instrutor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Instrutor == null)
            {
                return NotFound();
            }

            var instrutor = await _context.Instrutor.FindAsync(id);
            if (instrutor == null)
            {
                return NotFound();
            }
            return View(instrutor);
        }

        // POST: Instrutor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InstrutorId,Nome,Matricula")] Instrutor instrutor)
        {
            if (id != instrutor.InstrutorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instrutor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstrutorExists(instrutor.InstrutorId))
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
            return View(instrutor);
        }

        // GET: Instrutor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Instrutor == null)
            {
                return NotFound();
            }

            var instrutor = await _context.Instrutor
                .FirstOrDefaultAsync(m => m.InstrutorId == id);
            if (instrutor == null)
            {
                return NotFound();
            }

            return View(instrutor);
        }

        // POST: Instrutor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Instrutor == null)
            {
                return Problem("Entity set 'ProjetoAcademiaContext.Instrutor'  is null.");
            }
            var instrutor = await _context.Instrutor.FindAsync(id);
            if (instrutor != null)
            {
                _context.Instrutor.Remove(instrutor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstrutorExists(int id)
        {
          return _context.Instrutor.Any(e => e.InstrutorId == id);
        }
    }
}
