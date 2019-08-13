using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Infra.Data.Context
{
    public class StoreContext : DbContext
    {
        //public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source=Data\\Store.db");


        }


        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Produto>()
                .HasKey(i => new { i.Id });

            mb.Entity<Produto>().Property(p => p.Id)
                .ValueGeneratedOnAdd();

            mb.Entity<Image>()
               .HasKey(i => new { i.Id });

            mb.Entity<Image>().Property(p => p.Id)
                .ValueGeneratedOnAdd();

            mb.Entity<Image>()
                .HasOne(p => p.Produto)
                .WithMany(bn => bn.Images);
        }




    }
}
