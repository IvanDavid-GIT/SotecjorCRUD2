using SotecjorCRUD2.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SotecjorCRUD2.Models.Abstract
{
    public interface ICategoriaMaterialBusiness
    {
        Task<IEnumerable<CategoriaMaterial>> ObtenerListaCatMateriales();
        Task<CategoriaMaterial> ObtenerCatMaterialPorId(string nom);
        Task<CategoriaMaterial> ObtenerCatMaterialPorIdNumero(int id);
        Task GuardarCategoria(CategoriaMaterial categoriaMaterial);
        Task EditarMaterial(CategoriaMaterial categoriaMaterial);
        Task EliminarMaterial(CategoriaMaterial categoriaMaterial);
        

    }
}
