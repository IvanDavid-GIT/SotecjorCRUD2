using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SotecjorCRUD2.Models.Abstract;
using SotecjorCRUD2.Models.DAL;
using SotecjorCRUD2.Models.Entities;
using SotecjorCRUD2.ViewModels;

namespace SotecjorCRUD2.Controllers
{
    public class CategoriaMaterialesController : Controller
    {
        private readonly ICategoriaMaterialBusiness _categoriaMaterialBusiness;

        public CategoriaMaterialesController(ICategoriaMaterialBusiness categoriaMaterialBusiness)
        {
            _categoriaMaterialBusiness = categoriaMaterialBusiness;
        }

        // GET: CategoriaMateriales
        public async Task<IActionResult> Indice()
        {
            return View(await _categoriaMaterialBusiness.ObtenerListaCatMateriales());
        }

        // GET: CategoriaMateriales/Details/5
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaMaterial = await _categoriaMaterialBusiness.ObtenerCatMaterialPorIdNumero(id.Value);
            if (categoriaMaterial == null)
            {
                return NotFound();
            }

            return View(categoriaMaterial);
        }

        // GET: CategoriaMateriales/Create
        public IActionResult Crear()
        {
            return View();
        }

        // POST: CategoriaMateriales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([Bind("CategoriaId,Nombre")] CategoriaMaterial categoriaMaterial)
        {
            if (ModelState.IsValid)
            {
                var materialTemp = await _categoriaMaterialBusiness.ObtenerCatMaterialPorId(categoriaMaterial.Nombre);

                if (materialTemp == null)
                {
                    await _categoriaMaterialBusiness.GuardarCategoria(categoriaMaterial);
                    return RedirectToAction(nameof(Indice));
                }
            }
            return View(categoriaMaterial);
        }

        // GET: CategoriaMateriales/Edit/5
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaMaterial = await _categoriaMaterialBusiness.ObtenerCatMaterialPorIdNumero(id.Value);
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
        public async Task<IActionResult> Editar(int id, [Bind("CategoriaId,Nombre")] CategoriaMaterial categoriaMaterial)
        {
            if (id != categoriaMaterial.CategoriaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _categoriaMaterialBusiness.EditarMaterial(categoriaMaterial);
                return RedirectToAction(nameof(Indice));
            }
            return View(categoriaMaterial);
        }

        // GET: CategoriaMateriales/Delete/5
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaMaterial = await _categoriaMaterialBusiness.ObtenerCatMaterialPorIdNumero(id.Value);
            if (categoriaMaterial == null)
            {
                return NotFound();
            }

            await _categoriaMaterialBusiness.EliminarMaterial(categoriaMaterial);
            return RedirectToAction(nameof(Indice));
            //return View(categoriaMaterial);
        }

        
    }
}
