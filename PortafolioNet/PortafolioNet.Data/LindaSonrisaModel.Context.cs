﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortafolioNet.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LindaSonrisaEntities : DbContext
    {
        public LindaSonrisaEntities()
            : base("name=LindaSonrisaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BOLETA_CLIENTE> BOLETA_CLIENTE { get; set; }
        public DbSet<CIUDAD> CIUDAD { get; set; }
        public DbSet<CLIENTE> CLIENTE { get; set; }
        public DbSet<COMUNA> COMUNA { get; set; }
        public DbSet<CONTACTO> CONTACTO { get; set; }
        public DbSet<DIA> DIA { get; set; }
        public DbSet<FAMILIA_PRODUCTO> FAMILIA_PRODUCTO { get; set; }
        public DbSet<FUNCIONARIO> FUNCIONARIO { get; set; }
        public DbSet<HIST_ATENCION> HIST_ATENCION { get; set; }
        public DbSet<HORA> HORA { get; set; }
        public DbSet<ORDEN_PEDIDO> ORDEN_PEDIDO { get; set; }
        public DbSet<PEDIDO_A_BODEGA> PEDIDO_A_BODEGA { get; set; }
        public DbSet<PERMISO> PERMISO { get; set; }
        public DbSet<PREGUNTA_SECRETA> PREGUNTA_SECRETA { get; set; }
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
        public DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public DbSet<RUBRO_PROVEEDOR> RUBRO_PROVEEDOR { get; set; }
        public DbSet<SERVICIO> SERVICIO { get; set; }
        public DbSet<TIPO_ESTADO_PEDIDO> TIPO_ESTADO_PEDIDO { get; set; }
        public DbSet<TIPO_FUNCIONARIO> TIPO_FUNCIONARIO { get; set; }
        public DbSet<TIPO_PRODUCTO> TIPO_PRODUCTO { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<VISITAS_WEB> VISITAS_WEB { get; set; }
        public DbSet<DETALLE_BOLETA_CLI> DETALLE_BOLETA_CLI { get; set; }
    }
}