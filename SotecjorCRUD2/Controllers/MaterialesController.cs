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
    public class MaterialesController : Controller
    {
        private readonly IMaterialBusiness _materialBusiness;

        public MaterialesController(IMaterialBusiness materialBusiness)
        {
            _materialBusiness = materialBusiness;
        }
        
        // GET: Materiales
        public async Task<IActionResult> Index()
        {

            return View(await _materialBusiness.ObtenerListaMateriales());

        }
        
        // GET: Materiales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var material = await _materialBusiness.ObtenerMaterialPorId(id.Value);
            if (material == null)
            {
                return NotFound();
            }

            return View(material);
        }
        
        // GET: Materiales/Create
        public async Task<IActionResult> Create()
        {
            ViewData["listaCategorias"] = new SelectList(await _materialBusiness.ObtenerListaCategorias(), "CategoriaId", "Nombre");
            return View();
        }
        
        // POST: Materiales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaterialId,Nombre,CodigoMaterial,CategoriaId,Cantidad")] Material material)
        {
            



            if (ModelState.IsValid)
            {
                var materialTemp = await _materialBusiness.ObtenerMaterialPorCod(material.CodigoMaterial);

                if (materialTemp == null)
                {
                    await _materialBusiness.GuardarMaterial(material);
                    return RedirectToAction(nameof(Index));
                }
            }


            if (material.CategoriaId == 0)
                ViewData["errorCat"] = "Seleccione una categoria";


            ViewData["errorCog"] = "Se encuentra registrado un material con este codigo";


            ViewData["listaCategorias"] = new SelectList(await _materialBusiness.ObtenerListaCategorias(), "CategoriaId", "Nombre");

            return View(material);
        }
        
        // GET: Materiales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var material = await _materialBusiness.ObtenerMaterialPorId(id.Value);
            if (material == null)
            {
                return NotFound();
            }
            return View(material);
        }
        
        // POST: Materiales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaterialId,Nombre,CodigoMaterial,CategoriaId,Cantidad")] Material material)
        {
            if (id != material.MaterialId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _materialBusiness.EditarMaterial(material);
                return RedirectToAction(nameof(Index));
            }
            return View(material);
        }
        
        // GET: Materiales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var material = await _materialBusiness.ObtenerMaterialPorId(id.Value);
            if (material == null)
            {
                return NotFound();
            }

            await _materialBusiness.EliminarMaterial(material);
            return RedirectToAction(nameof(Index));

            //return View(material);
        }
    }
}
