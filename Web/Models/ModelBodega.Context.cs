﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TantaEntities : DbContext
    {
        public TantaEntities()
            : base("name=TantaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alumno> alumnos { get; set; }
        public virtual DbSet<categoria> categorias { get; set; }
        public virtual DbSet<curso> cursos { get; set; }
        public virtual DbSet<nota> notas { get; set; }
    }
}
