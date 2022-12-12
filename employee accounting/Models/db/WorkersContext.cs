using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace employee_accounting.Models.db;

public partial class WorkersContext : DbContext
{
    public WorkersContext()
    {
    }

    public WorkersContext(DbContextOptions<WorkersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WorkersDatum> WorkersData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Database=Workers;Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkersDatum>(entity =>
        {
            entity.ToTable("Workers_Data");

            entity.Property(e => e.Id).ValueGeneratedNever();
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

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
