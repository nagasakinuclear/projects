﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DOC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DocDBEntities : DbContext
    {
        public DocDBEntities()
            : base("name=DocDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<MainContent> MainContent { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Services> Services { get; set; }
    }
}
