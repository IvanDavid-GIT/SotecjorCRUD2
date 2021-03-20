using SotecjorCRUD2.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SotecjorCRUD2.Models.Abstract
{
    public interface IMaterialBusiness
    {
        Task<IEnumerable<Material>> ObtenerListaMateriales();
        Task<Material> ObtenerMaterialPorId(int id);
        Task<IEnumerable<CategoriaMaterial>> ObtenerListaCategorias();
        Task<Material> ObtenerMaterialPorCod(int Cod);
        Task GuardarMaterial(Material material);
        Task EditarMaterial(Material material);
        Task EliminarMaterial(Material material);
    }
}
