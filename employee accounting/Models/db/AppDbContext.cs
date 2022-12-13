using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace employee_accounting.Models.db;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Database=Workers;Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkersData>(entity =>
        {
            entity.ToTable("Workers_Data");

            entity.Property(e => e.Id).HasDefaultValueSql();
            entity.Property(e => e.DismissalDate).HasColumnType("date");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.EmploymentDate).HasColumnType("date");
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.SubDivision)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }
    public DbSet<WorkersData> WorkersData { get; set; }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
