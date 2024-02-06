using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RKSOFTWARESOLUTIONS.Models;

public partial class AksharaContext : DbContext
{
    

    public AksharaContext()
    {
    }

    public AksharaContext(DbContextOptions<AksharaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<RegistrationForm> RegistrationForms { get; set; }

    public virtual DbSet<Rksolution> Rksolutions { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=(local); Initial Catalog=Akshara;Server=DESKTOP-54HLCQ0\\SQLEXPRESS;trusted_connection=true;trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Login>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Login");

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RegistrationForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RegistrationForm");

            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NewUserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Rksolution>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RKSolutions");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
