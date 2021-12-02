using System;
using System.Collections.Generic;
using System.Text;
using CalisanBilgi.Data.DbModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CalisanBilgi.Data.DataContext
{
   public class CalisanBilgiContext: IdentityDbContext
    {
        public CalisanBilgiContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Employe> Employes { get; set; }
    }
}
