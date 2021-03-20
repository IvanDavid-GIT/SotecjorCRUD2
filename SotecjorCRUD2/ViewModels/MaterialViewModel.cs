using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SotecjorCRUD2.ViewModels
{
    public class MaterialViewModel
    {
            public int MaterialId { get; set; }
            public string Nombre { get; set; }
            public int CodigoMaterial { get; set; }
            public string Categoria { get; set; }
            public int Cantidad { get; set; }
        
    }
}
