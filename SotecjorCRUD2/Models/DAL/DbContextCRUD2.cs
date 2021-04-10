using Microsoft.EntityFrameworkCore;
using SotecjorCRUD2.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SotecjorCRUD2.Models.DAL
{
    public class DbContextCRUD2: DbContext
    {
        public DbContextCRUD2(DbContextOptions<DbContextCRUD2> options)
            :base(options)
        {

        }





        public DbSet<Material> Materiales { get; set; }
        public DbSet<CategoriaMaterial> categoriaMateriales { get; set; }
        public DbSet<MaterialDetalle> MaterialDetalles { get; set; }



    }
}
