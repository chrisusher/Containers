﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5RealWorld.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DemoDBEntities : DbContext
    {
        public DemoDBEntities()
            : base("name=DemoDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LOOKUPRole> LOOKUPRoles { get; set; }
        public virtual DbSet<SYSUser> SYSUsers { get; set; }
        public virtual DbSet<SYSUserProfile> SYSUserProfiles { get; set; }
        public virtual DbSet<SYSUserRole> SYSUserRoles { get; set; }

        public System.Data.Entity.DbSet<MVC5RealWorld.Models.ViewModel.UserSignUpView> UserSignUpViews { get; set; }

        public System.Data.Entity.DbSet<MVC5RealWorld.Models.ViewModel.UserLoginView> UserLoginViews { get; set; }

        public System.Data.Entity.DbSet<MVC5RealWorld.Models.ViewModel.UserProfileView> UserProfileViews { get; set; }
    }
}
