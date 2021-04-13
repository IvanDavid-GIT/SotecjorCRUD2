using Microsoft.EntityFrameworkCore;
using SotecjorCRUD2.Models.Abstract;
using SotecjorCRUD2.Models.DAL;
using SotecjorCRUD2.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SotecjorCRUD2.Models.Business
{
    public class CategoriaMaterialBusiness: ICategoriaMaterialBusiness
    {
        private readonly DbContextCRUD2 _context;
        public CategoriaMaterialBusiness(DbContextCRUD2 context)
        {
            _context = context;
        }


        public async Task<IEnumerable<CategoriaMaterial>> ObtenerListaCatMateriales()
        {
            return await _context.categoriaMateriales.ToListAsync();
        }

        public async Task<CategoriaMaterial> ObtenerCatMaterialPorId(string nom)
        {
            return await _context.categoriaMateriales.FirstOrDefaultAsync(m => m.Nombre == nom);
        }

        public async Task<CategoriaMaterial> ObtenerCatMaterialPorIdNumero(int id)
        {
            return await _context.categoriaMateriales.FirstOrDefaultAsync(m => m.CategoriaId == id);
        }
        public async Task Crear(CategoriaMaterial categoriaMaterial)
        {
             _context.Add(categoriaMaterial);
               await _context.SaveChangesAsync();
        }

        public async Task EditarMaterial(CategoriaMaterial categoriaMaterial)
        {
            try
            {
                _context.Update(categoriaMaterial);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task EliminarMaterial(CategoriaMaterial categoriaMaterial)
        {
            try
            {
                _context.Remove(categoriaMaterial);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
