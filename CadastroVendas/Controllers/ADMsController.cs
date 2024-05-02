using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadastroVendas.Data;
using CadastroVendas.Models;

namespace CadastroVendas.Controllers
{
    public class ADMsController : Controller
    {
        private readonly CadastroVendasContext _context;

        public ADMsController(CadastroVendasContext context)
        {
            _context = context;
        }

        // GET: ADMs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ADM.ToListAsync());
        }

        // GET: ADMs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aDM = await _context.ADM
                .FirstOrDefaultAsync(m => m.ADMId == id);
            if (aDM == null)
            {
                return NotFound();
            }

            return View(aDM);
        }

        // GET: ADMs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ADMs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ADMId,ADMName")] ADM aDM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aDM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aDM);
        }

        // GET: ADMs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aDM = await _context.ADM.FindAsync(id);
            if (aDM == null)
            {
                return NotFound();
            }
            return View(aDM);
        }

        // POST: ADMs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ADMId,ADMName")] ADM aDM)
        {
            if (id != aDM.ADMId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aDM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ADMExists(aDM.ADMId))
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
            return View(aDM);
        }

        // GET: ADMs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aDM = await _context.ADM
                .FirstOrDefaultAsync(m => m.ADMId == id);
            if (aDM == null)
            {
                return NotFound();
            }

            return View(aDM);
        }

        // POST: ADMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aDM = await _context.ADM.FindAsync(id);
            if (aDM != null)
            {
                _context.ADM.Remove(aDM);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ADMExists(int id)
        {
            return _context.ADM.Any(e => e.ADMId == id);
        }
    }
}
