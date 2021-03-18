using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SotecjorCRUD2.Models.Entities
{
    public class Material
    {
        public int MaterialId { get; set; }
        [Required(ErrorMessage ="El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El codigo del material es requerido")]
        public int CodigoMaterial { get; set; }
        [Required(ErrorMessage = "La categoria del material es requerida")]
        public int CategoriaMaterial { get; set; }
       
        public int Cantidad { get; set; }
    }
}
