using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SotecjorCRUD2.Models.Entities
{
    public class CategoriaMaterial
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        public virtual List<MaterialDetalle> MaterialDetalles { get; set; }
    }
}
