using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SotecjorCRUD2.Models.Entities
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        [Required(ErrorMessage ="El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El codigo del material es requerido")]
        [DisplayName("Código")]
        public int CodigoMaterial { get; set; }
        [Required(ErrorMessage = "La categoria del material es requerida")]
        [DisplayName("Categoría")]
        //[ForeignKey("CategoriaId")]
        public int CategoriaId { get; set; }
        public virtual CategoriaMaterial Categoria { get; set; }

        public int Cantidad { get; set; }
    }
}
