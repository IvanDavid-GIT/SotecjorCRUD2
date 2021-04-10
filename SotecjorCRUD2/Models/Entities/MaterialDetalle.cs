using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SotecjorCRUD2.Models.Entities
{
    public class MaterialDetalle
    {
        [Key]
        public int MaterialDetalleId { get; set; }
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        public int CategoriaId { get; set; }
        public virtual CategoriaMaterial Categoria { get; set; }

    }
}
