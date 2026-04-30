using System;
using System.Collections.Generic;
using System.Text;
using HandsOnEntityMVC.Entity;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEntityMVC.Database{

    public class AppDbContext : DbContext{

        public DbSet<Account> Accounts{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=127.0.0.1,1433;" +
                "Initial Catalog=EfCoreDb;" +
                "User ID=sa;" +
                "Password=REDDY@0328;" +
                "TrustServerCertificate=True");
        }




    }



}