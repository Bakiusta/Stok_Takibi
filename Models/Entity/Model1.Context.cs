﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcstok1.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mvcstokEntities : DbContext
    {
        public mvcstokEntities()
            : base("name=mvcstokEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<kategoriler> kategoriler { get; set; }
        public virtual DbSet<musteriler> musteriler { get; set; }
        public virtual DbSet<urunler> urunler { get; set; }
        public virtual DbSet<satis> satis { get; set; }
    }
}
