using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SotecjorCRUD2.Models.DAL;
using SotecjorCRUD2.Models.Entities;

namespace SotecjorCRUD2.Controllers
{
    public class CategoriaMaterialesController : Controller
    {
        private readonly DbContextCRUD2 _context;

        public CategoriaMaterialesController(DbContextCRUD2 context)
        {
            _context = context;
        }

        // GET: CategoriaMateriales
        public async Task<IActionResult> Index()
        {
            return View(await _context.categoriaMateriales.ToListAsync());
        }

        // GET: CategoriaMateriales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaMaterial = await _context.categoriaMateriales
                .FirstOrDefaultAsync(m => m.CategoriaId == id);
            if (categoriaMaterial == null)
            {
                return NotFound();
            }

            return View(categoriaMaterial);
        }

        // GET: CategoriaMateriales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriaMateriales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoriaId,Nombre")] CategoriaMaterial categoriaMaterial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoriaMaterial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaMaterial);
        }

        // GET: CategoriaMateriales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaMaterial = await _context.categoriaMateriales.FindAsync(id);
            if (categoriaMaterial == null)
            {
                return NotFound();
            }
            return View(categoriaMaterial);
        }

        // POST: CategoriaMateriales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoriaId,Nombre")] CategoriaMaterial categoriaMaterial)
        {
            if (id != categoriaMaterial.CategoriaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoriaMaterial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaMaterialExists(categoriaMaterial.CategoriaId))
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
            return View(categoriaMaterial);
        }

        // GET: CategoriaMateriales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaMaterial = await _context.categoriaMateriales
                .FirstOrDefaultAsync(m => m.CategoriaId == id);
            if (categoriaMaterial == null)
            {
                return NotFound();
            }

            return View(categoriaMaterial);
        }

        // POST: CategoriaMateriales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriaMaterial = await _context.categoriaMateriales.FindAsync(id);
            _context.categoriaMateriales.Remove(categoriaMaterial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaMaterialExists(int id)
        {
            return _context.categoriaMateriales.Any(e => e.CategoriaId == id);
        }
    }
}
