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
        [Required]
        public string Nombre { get; set; }
        [Required]
        [DisplayName("Código")]
        public int CodigoMaterial { get; set; }        
        public int Cantidad { get; set; }
        public virtual List<MaterialDetalle> MaterialDetalles { get; set; }
    }
}
