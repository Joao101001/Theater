﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using Capa_Entidad;

    public partial class TheaterEntities1 : DbContext
    {
        public TheaterEntities1()
            : base("name=TheaterEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Genero> Generoes { get; set; }
        public virtual DbSet<Loogin> Loogins { get; set; }
        public virtual DbSet<Pelicula> Peliculas { get; set; }
    
        public virtual ObjectResult<ListarPelicula_Result> ListarPelicula()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarPelicula_Result>("ListarPelicula");
        }
    }
}
