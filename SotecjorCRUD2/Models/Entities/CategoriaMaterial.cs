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
        public string Nombre { get; set; }
    }
}
