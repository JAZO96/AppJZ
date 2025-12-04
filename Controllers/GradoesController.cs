using AppJZ.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppJZ.Models;

namespace WebApplication1.Controllers
{
    public class GradoesController : Controller
    {
        private readonly AulalinkContext _context;

        public GradoesController(AulalinkContext context)
        {
            _context = context;
        }

        // GET: Gradoes1
        public async Task<IActionResult> Index()
        {
            var aulalinkContext = _context.Grados.Include(g => g.Docente);
            return View(await aulalinkContext.ToListAsync());
        }

        // GET: Gradoes1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grado = await _context.Grados
                .Include(g => g.Docente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grado == null)
            {
                return NotFound();
            }

            return View(grado);
        }

        // GET: Gradoes1/Create
        public IActionResult Create()
        {
            ViewData["DocenteId"] = new SelectList(_context.Set<Docente>(), "Id", "Id");
            return View();
        }

        // POST: Gradoes1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nombre,Creditos,Nivel,Estado,DocenteId")] Grado grado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DocenteId"] = new SelectList(_context.Set<Docente>(), "Id", "Id", grado.DocenteId);
            return View(grado);
        }

        // GET: Gradoes1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grado = await _context.Grados.FindAsync(id);
            if (grado == null)
            {
                return NotFound();
            }
            ViewData["DocenteId"] = new SelectList(_context.Set<Docente>(), "Id", "Id", grado.DocenteId);
            return View(grado);
        }

        // POST: Gradoes1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nombre,Creditos,Nivel,Estado,DocenteId")] Grado grado)
        {
            if (id != grado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradoExists(grado.Id))
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
            ViewData["DocenteId"] = new SelectList(_context.Set<Docente>(), "Id", "Id", grado.DocenteId);
            return View(grado);
        }

        // GET: Gradoes1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grado = await _context.Grados
                .Include(g => g.Docente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grado == null)
            {
                return NotFound();
            }

            return View(grado);
        }

        // POST: Gradoes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grado = await _context.Grados.FindAsync(id);
            if (grado != null)
            {
                _context.Grados.Remove(grado);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GradoExists(int id)
        {
            return _context.Grados.Any(e => e.Id == id);
        }
    }
}
