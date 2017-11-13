﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionVenta
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class shoppingwebEntities : DbContext
    {
        public shoppingwebEntities()
            : base("name=shoppingwebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<carrito> carrito { get; set; }
        public virtual DbSet<categorias> categorias { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<detalleorden> detalleorden { get; set; }
        public virtual DbSet<estado_orden> estado_orden { get; set; }
        public virtual DbSet<marca> marca { get; set; }
        public virtual DbSet<orden> orden { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<rol> rol { get; set; }
    
        public virtual ObjectResult<sp_ListCategorias_Result> sp_ListCategorias()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListCategorias_Result>("sp_ListCategorias");
        }
    
        public virtual ObjectResult<sp_login_Result> sp_login(string user, string pass)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_login_Result>("sp_login", userParameter, passParameter);
        }
    
        public virtual ObjectResult<sp_Productos_Result> sp_Productos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Productos_Result>("sp_Productos");
        }
    
        public virtual ObjectResult<sp_SelectProduct_Result> sp_SelectProduct(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SelectProduct_Result>("sp_SelectProduct", idParameter);
        }
    
        public virtual ObjectResult<byte[]> sp_traerfoto(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("sp_traerfoto", idParameter);
        }
    }
}