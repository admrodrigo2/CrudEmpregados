using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ext.Net.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MojeeIO;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class EmpregadosController : Controller
    {
        private readonly EmpregadosContext _context;

        public EmpregadosController(EmpregadosContext context)
        {
            _context = context;
        }

        // GET: Empregados
        public async Task<IActionResult> Index()
        {
              return View(await _context.Empregados.ToListAsync());
        }

        // GET: Empregados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Empregados == null)
            {
                return NotFound();
            }

            var empregados = await _context.Empregados
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empregados == null)
            {
                return NotFound();
            }

            return View(empregados);
        }

        // GET: Empregados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empregados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Endereco,Telefone,Cargo")] Empregados empregados)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empregados);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empregados);
        }

        // GET: Empregados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Empregados == null)
            {
                return NotFound();
            }

            var empregados = await _context.Empregados.FindAsync(id);
            if (empregados == null)
            {
                return NotFound();
            }
            return View(empregados);
        }

        // POST: Empregados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Endereco,Telefone,Cargo")] Empregados empregados)
        {
            if (id != empregados.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empregados);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpregadosExists(empregados.Id))
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
            return View(empregados);
        }

        // GET: Empregados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Empregados == null)
            {
                return NotFound();
            }

            var empregados = await _context.Empregados
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empregados == null)
            {
                return NotFound();
            }

            return View(empregados);
        }

        // POST: Empregados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Empregados == null)
            {
                return Problem("Entity set 'EmpregadosContext.Empregados'  is null.");
            }
            var empregados = await _context.Empregados.FindAsync(id);
            if (empregados != null)
            {
                _context.Empregados.Remove(empregados);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpregadosExists(int id)
        {
          return _context.Empregados.Any(e => e.Id == id);
        }
    }
}
