using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace employee_accounting.Models.db;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Database=Workers;Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SubDivision>(entity =>
        {
            entity.ToTable("SubDivision");

            entity.Property(e => e.SubDivisionName)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.HeadEmployee).WithMany(p => p.SubDivisions)
                .HasForeignKey(d => d.HeadEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubDivision_WorkersData");
        });

        modelBuilder.Entity<WorkersData>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Workers_Data_1");

            entity.Property(e => e.DismissalDate).HasColumnType("date");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.EmploymentDate).HasColumnType("date");
            entity.Property(e => e.IdSubDivision).HasColumnName("Id_SubDivision");
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.IdSubDivisionNavigation).WithMany(p => p.WorkersData)
                .HasForeignKey(d => d.IdSubDivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkersData_SubDivision");
        });

        OnModelCreatingPartial(modelBuilder);
    }
    public virtual DbSet<SubDivision> SubDivisions { get; set; }

    public virtual DbSet<WorkersData> WorkersData { get; set; }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
