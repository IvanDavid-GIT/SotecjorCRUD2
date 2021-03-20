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
    
    public class MaterialBusiness: IMaterialBusiness
    {
        private readonly DbContextCRUD2 _context;
        public MaterialBusiness(DbContextCRUD2 context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Material>> ObtenerListaMateriales() 
        {
            return await _context.Materiales.Include("Categoria").ToListAsync();
        }

        public async Task<Material> ObtenerMaterialPorId(int id) 
        {
            return await _context.Materiales.FirstOrDefaultAsync(m => m.MaterialId == id);
        }

        public async Task<Material> ObtenerMaterialPorCod(int Cod)
        {
            return await _context.Materiales.FirstOrDefaultAsync(m => m.CodigoMaterial == Cod);
        }

        public async Task<IEnumerable<CategoriaMaterial>> ObtenerListaCategorias()
        {
            return await _context.categoriaMateriales.ToListAsync();
        }

        public async Task GuardarMaterial(Material material) 
        {
            try
            {
                _context.Add(material);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task EditarMaterial(Material material)
        {
            try
            {
                _context.Update(material);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task EliminarMaterial(Material material)
        {
            try
            {
                _context.Remove(material);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
        }







    }
}
