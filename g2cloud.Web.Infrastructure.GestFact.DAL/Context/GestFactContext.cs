using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace g2cloud.Web.Infrastructure.GestFact.DAL;

public partial class GestFactContext : DbContext
{
    public GestFactContext(DbContextOptions<GestFactContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WCONTENT> WCONTENT { get; set; }

    public virtual DbSet<WDATA> WDATA { get; set; }

    public virtual DbSet<WPAGE> WPAGE { get; set; }

    public virtual DbSet<WSECTION> WSECTION { get; set; }

    public virtual DbSet<WSITE> WSITE { get; set; }

    public virtual DbSet<WTCON> WTCON { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<WCONTENT>(entity =>
        {
            entity.HasKey(e => e.COD_WCO).HasName("PK__WCONTENT__287EF2CA807A1329");

            entity.HasIndex(e => e.COD_WCO, "WCO_1").IsUnique();

            entity.HasIndex(e => e.COD_WSE, "WCO_2");

            entity.HasIndex(e => e.COD_WTC, "WCO_3");

            entity.Property(e => e.COD_WCO)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.COD_LIN)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.COD_PER)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.COD_WSE)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.COD_WTC)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.WCO_CLA).HasMaxLength(15);
            entity.Property(e => e.WCO_CON).HasColumnType("image");
            entity.Property(e => e.WCO_CON2).HasColumnType("image");
            entity.Property(e => e.WCO_CON3).HasColumnType("image");
            entity.Property(e => e.WCO_CON4).HasColumnType("image");
            entity.Property(e => e.WCO_CON5).HasColumnType("image");
            entity.Property(e => e.WCO_CONTW).HasMaxLength(6);
            entity.Property(e => e.WCO_CONTW2).HasMaxLength(6);
            entity.Property(e => e.WCO_CONTW3).HasMaxLength(6);
            entity.Property(e => e.WCO_CONTW4).HasMaxLength(6);
            entity.Property(e => e.WCO_CONTW5).HasMaxLength(6);
            entity.Property(e => e.WCO_CSS).HasMaxLength(64);
            entity.Property(e => e.WCO_EST).HasMaxLength(15);
            entity.Property(e => e.WCO_EXT).HasMaxLength(4);
            entity.Property(e => e.WCO_EXT2).HasMaxLength(4);
            entity.Property(e => e.WCO_EXT3).HasMaxLength(4);
            entity.Property(e => e.WCO_EXT4).HasMaxLength(4);
            entity.Property(e => e.WCO_EXT5).HasMaxLength(4);
            entity.Property(e => e.WCO_FAL).HasColumnType("datetime");
            entity.Property(e => e.WCO_FIC).HasMaxLength(64);
            entity.Property(e => e.WCO_FIC2).HasMaxLength(64);
            entity.Property(e => e.WCO_FIC3).HasMaxLength(64);
            entity.Property(e => e.WCO_FIC4).HasMaxLength(64);
            entity.Property(e => e.WCO_FIC5).HasMaxLength(64);
            entity.Property(e => e.WCO_FUE).HasColumnType("datetime");
            entity.Property(e => e.WCO_LCK).HasMaxLength(20);
            entity.Property(e => e.WCO_OBS).HasMaxLength(256);
            entity.Property(e => e.WCO_ORI).HasMaxLength(64);
            entity.Property(e => e.WCO_ORI2).HasMaxLength(64);
            entity.Property(e => e.WCO_ORI3).HasMaxLength(64);
            entity.Property(e => e.WCO_ORI4).HasMaxLength(64);
            entity.Property(e => e.WCO_ORI5).HasMaxLength(64);
            entity.Property(e => e.WCO_PIE).HasMaxLength(64);
            entity.Property(e => e.WCO_PUB).HasMaxLength(24);
            entity.Property(e => e.WCO_RED).HasMaxLength(255);
            entity.Property(e => e.WCO_REG).HasMaxLength(30);
            entity.Property(e => e.WCO_SUB).HasMaxLength(64);
            entity.Property(e => e.WCO_TAG).HasMaxLength(50);
            entity.Property(e => e.WCO_TIT).HasMaxLength(64);
            entity.Property(e => e.WCO_UPD).HasColumnType("datetime");
            entity.Property(e => e.WCO_VTI)
                .HasMaxLength(2)
                .IsFixedLength();
        });

        modelBuilder.Entity<WDATA>(entity =>
        {
            entity.HasKey(e => e.COD_WDA).HasName("PK__WDATA__287E0AF783EDF878");

            entity.HasIndex(e => e.COD_WDA, "WDA_1").IsUnique();

            entity.HasIndex(e => e.COD_WSI, "WDA_2");

            entity.HasIndex(e => e.COD_WPA, "WDA_3");

            entity.HasIndex(e => e.COD_WSE, "WDA_4");

            entity.Property(e => e.COD_WDA)
                .HasMaxLength(9)
                .IsFixedLength();
            entity.Property(e => e.COD_WPA)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.COD_WSE)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.COD_WSI)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.WDA_EST).HasMaxLength(15);
            entity.Property(e => e.WDA_FAL).HasColumnType("datetime");
            entity.Property(e => e.WDA_FUE).HasColumnType("datetime");
            entity.Property(e => e.WDA_LCK).HasMaxLength(20);
            entity.Property(e => e.WDA_OBS).HasMaxLength(80);
            entity.Property(e => e.WDA_REG).HasMaxLength(30);
            entity.Property(e => e.WDA_TAG).HasMaxLength(50);
            entity.Property(e => e.WDA_UPD).HasColumnType("datetime");
        });

        modelBuilder.Entity<WPAGE>(entity =>
        {
            entity.HasKey(e => e.COD_WPA).HasName("PK__WPAGE__287E654035283FC9");

            entity.HasIndex(e => e.COD_WPA, "WPA_1").IsUnique();

            entity.HasIndex(e => e.COD_WSI, "WPA_2");

            entity.Property(e => e.COD_WPA)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.COD_WSI)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.WPA_BOTVER).HasMaxLength(2);
            entity.Property(e => e.WPA_CLA).HasMaxLength(15);
            entity.Property(e => e.WPA_EST).HasMaxLength(15);
            entity.Property(e => e.WPA_FAL).HasColumnType("datetime");
            entity.Property(e => e.WPA_FUE).HasColumnType("datetime");
            entity.Property(e => e.WPA_IDAPP).HasMaxLength(64);
            entity.Property(e => e.WPA_LCK).HasMaxLength(20);
            entity.Property(e => e.WPA_NOD).HasMaxLength(3);
            entity.Property(e => e.WPA_NOM).HasMaxLength(64);
            entity.Property(e => e.WPA_OBS).HasMaxLength(256);
            entity.Property(e => e.WPA_REG).HasMaxLength(30);
            entity.Property(e => e.WPA_RUT).HasMaxLength(64);
            entity.Property(e => e.WPA_TAG).HasMaxLength(50);
            entity.Property(e => e.WPA_TIP).HasMaxLength(15);
            entity.Property(e => e.WPA_TOPVER).HasMaxLength(2);
            entity.Property(e => e.WPA_UPD).HasColumnType("datetime");
        });

        modelBuilder.Entity<WSECTION>(entity =>
        {
            entity.HasKey(e => e.COD_WSE).HasName("PK__WSECTION__287D8CFC0FA610B6");

            entity.HasIndex(e => e.COD_WSE, "WSE_1").IsUnique();

            entity.Property(e => e.COD_WSE)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.COD_WSI)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.WSE_CSS).HasMaxLength(64);
            entity.Property(e => e.WSE_EST).HasMaxLength(15);
            entity.Property(e => e.WSE_FAL).HasColumnType("datetime");
            entity.Property(e => e.WSE_FUE).HasColumnType("datetime");
            entity.Property(e => e.WSE_LCK).HasMaxLength(20);
            entity.Property(e => e.WSE_NOM).HasMaxLength(64);
            entity.Property(e => e.WSE_OBS).HasMaxLength(256);
            entity.Property(e => e.WSE_REG).HasMaxLength(30);
            entity.Property(e => e.WSE_TAG).HasMaxLength(50);
            entity.Property(e => e.WSE_UPD).HasColumnType("datetime");
        });

        modelBuilder.Entity<WSITE>(entity =>
        {
            entity.HasKey(e => e.COD_WSI).HasName("PK__WSITE__287D8CF8BE421B3B");

            entity.HasIndex(e => e.COD_WSI, "WSI_1").IsUnique();

            entity.Property(e => e.COD_WSI)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.WSI_ALI).HasMaxLength(128);
            entity.Property(e => e.WSI_EST).HasMaxLength(15);
            entity.Property(e => e.WSI_FAL).HasColumnType("datetime");
            entity.Property(e => e.WSI_FUE).HasColumnType("datetime");
            entity.Property(e => e.WSI_LCK).HasMaxLength(20);
            entity.Property(e => e.WSI_NOM).HasMaxLength(50);
            entity.Property(e => e.WSI_OBS).HasMaxLength(256);
            entity.Property(e => e.WSI_PRO).HasMaxLength(8);
            entity.Property(e => e.WSI_PUE).HasMaxLength(4);
            entity.Property(e => e.WSI_PUEDEF).HasMaxLength(2);
            entity.Property(e => e.WSI_REG).HasMaxLength(30);
            entity.Property(e => e.WSI_TAG).HasMaxLength(50);
            entity.Property(e => e.WSI_UPD).HasColumnType("datetime");
            entity.Property(e => e.WSI_URL).HasMaxLength(32);
        });

        modelBuilder.Entity<WTCON>(entity =>
        {
            entity.HasKey(e => e.COD_WTC).HasName("PK__WTCON__287D84C1B87F3019");

            entity.HasIndex(e => e.COD_WTC, "WTC_1").IsUnique();

            entity.Property(e => e.COD_WTC)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.WTC_CLA).HasMaxLength(15);
            entity.Property(e => e.WTC_EST).HasMaxLength(15);
            entity.Property(e => e.WTC_FAL).HasColumnType("datetime");
            entity.Property(e => e.WTC_FUE).HasColumnType("datetime");
            entity.Property(e => e.WTC_LCK).HasMaxLength(20);
            entity.Property(e => e.WTC_NOM).HasMaxLength(64);
            entity.Property(e => e.WTC_REG).HasMaxLength(30);
            entity.Property(e => e.WTC_TAG).HasMaxLength(50);
            entity.Property(e => e.WTC_UPD).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
