using System.Collections.Generic;
using System.IO;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace g2cloud.Web.Infrastructure.GestFact.DAL
{
    #region Entities

    public partial class WTCON 
    {
        public ICollection<WCONTENT> WCONTENT { get; set; }
    }

    public partial class WSECTION 
    {
        public ICollection<WCONTENT> WCONTENT { get; set; }
        public ICollection<WDATA> WDATA { get; set; }
    }

    public partial class WCONTENT 
    {
        public WTCON WTCON { get; set; }
        public WSECTION WSECTION { get; set; }
    }

    public partial class WDATA 
    {
        public WSITE WSITE { get; set; }
        public WPAGE WPAGE { get; set; }
        public WSECTION WSECTION { get; set; }
    }

    public partial class WPAGE 
    {
        public WSITE WSITE { get; set; }
        public ICollection<WDATA> WDATA { get; set; }
    }

    public partial class WSITE 
    {
        public ICollection<WDATA> WDATA { get; set; }
        public ICollection<WPAGE> WPAGE { get; set; }
    }

    #endregion

    #region Context

    public partial class GestFactContext
    {
        public GestFactContext() 
        {
        }

        public GestFactContext(string connectionString) : base(GetOptions(connectionString)) { }

        private static DbContextOptions GetOptions(string connectionString) 
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("GestFactConnectionString"), o => o.UseCompatibilityLevel(120));
            }
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<WTCON>(entity =>
            {
                entity.HasMany(e => e.WCONTENT).WithOne(e => e.WTCON).HasForeignKey(e => e.COD_WTC);
            });

            modelBuilder.Entity<WSECTION>(entity =>
            {
                entity.HasMany(e => e.WCONTENT).WithOne(e => e.WSECTION).HasForeignKey(e => e.COD_WSE);

                entity.HasMany(e => e.WDATA).WithOne(e => e.WSECTION).HasForeignKey(e => e.COD_WSE);
            });

            modelBuilder.Entity<WCONTENT>(entity =>
            {
                entity.HasOne(e => e.WTCON).WithMany(e => e.WCONTENT).HasForeignKey(e => e.COD_WTC);

                entity.HasOne(e => e.WSECTION).WithMany(e => e.WCONTENT).HasForeignKey(e => e.COD_WSE);
            });

            modelBuilder.Entity<WDATA>(entity =>
            {
                entity.HasOne(e => e.WSITE).WithMany(e => e.WDATA).HasForeignKey(e => e.COD_WSI);

                entity.HasOne(e => e.WPAGE).WithMany(e => e.WDATA).HasForeignKey(e => e.COD_WPA);

                entity.HasOne(e => e.WSECTION).WithMany(e => e.WDATA).HasForeignKey(e => e.COD_WSE);
            });

            modelBuilder.Entity<WPAGE>(entity =>
            {
                entity.HasOne(e => e.WSITE).WithMany(e => e.WPAGE).HasForeignKey(e => e.COD_WSI);

                entity.HasMany(e => e.WDATA).WithOne(e => e.WPAGE).HasForeignKey(e => e.COD_WPA);
            });

            modelBuilder.Entity<WSITE>(entity =>
            {
                entity.HasMany(e => e.WDATA).WithOne(r => r.WSITE).HasForeignKey(r => r.COD_WSI);

                entity.HasMany(e => e.WPAGE).WithOne(r => r.WSITE).HasForeignKey(r => r.COD_WSI);
            });
        }

    }

    #endregion
}   