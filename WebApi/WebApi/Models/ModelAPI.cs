using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace WebApi.Models
{
    public partial class ModelAPI : DbContext
    {
        public ModelAPI()
            : base("name=ModelAPI")
     
        {
           

        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
 

    }


  
}
