// <copyright file="RaceHubMotorsContext.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Context;

using Microsoft.EntityFrameworkCore;
using RaceHub.Motors.API.DAL.Entity;

/// <summary>
/// This class defines the necessary database context.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="RaceHubMotorsContext"/> class.
/// </remarks>
/// <param name="options">The database context options.</param>
public partial class RaceHubMotorsContext(DbContextOptions<RaceHubMotorsContext> options)
    : DbContext(options)
{
    /// <summary>
    /// Gets or sets the drivetrains.
    /// </summary>
    public virtual DbSet<Drivetrain> Drivetrains { get; set; }

    /// <summary>
    /// Gets or sets the necessary engines.
    /// </summary>
    public virtual DbSet<Engine> Engines { get; set; }

    /// <summary>
    /// Gets or sets the vehicle colors.
    /// </summary>
    public virtual DbSet<VehicleColor> VehicleColors { get; set; }

    /// <summary>
    /// Gets or sets the manufacturers.
    /// </summary>
    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    /// <summary>
    /// Gets or sets the vehicles.
    /// </summary>
    public virtual DbSet<Vehicle> Vehicles { get; set; }

    /// <summary>
    /// Gets or sets the vehicle types.
    /// </summary>
    public virtual DbSet<VehicleType> VehicleTypes { get; set; }

    /// <summary>
    /// Gets or sets the users.
    /// </summary>
    public virtual DbSet<User> Users { get; set; }

    /// <summary>
    /// This method will bind the columns to the dotnet classes.
    /// </summary>
    /// <param name="modelBuilder">The model building middleware.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Drivetrain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Drivetra__3214EC0788606B2D");

            entity.ToTable("Drivetrain", "Cfg");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastUpd).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastUpdApp)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(app_name())");
            entity.Property(e => e.LastUpdBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
        });

        modelBuilder.Entity<Engine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Engine__3214EC07D8E6028E");

            entity.ToTable("Engine", "Cfg");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.Description)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastUpd).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastUpdApp)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(app_name())");
            entity.Property(e => e.LastUpdBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
        });

        modelBuilder.Entity<VehicleColor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VehicleC__3214EC074CA9A7E0");

            entity.ToTable("VehicleColor", "Cfg");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastUpd).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastUpdApp)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(app_name())");
            entity.Property(e => e.LastUpdBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Manufact__3214EC073E4EC42C");

            entity.ToTable("Manufacturer", "Manufacturer");

            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.LastUpd).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Name).IsRequired().HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Country).IsRequired().HasMaxLength(30).IsUnicode(false);
            entity.Property(e => e.CountryCode).IsRequired().HasMaxLength(10).IsUnicode(false);
            entity.Property(e => e.Region).IsRequired().HasMaxLength(10).IsUnicode(false);
            entity.Property(e => e.LastUpdBy).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.LastUpdApp).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(app_name())");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vehicle__3214EC0759A04D38");

            entity.ToTable("Vehicle", "Vehicle");

            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.LastUpd).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastUpdBy).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.LastUpdApp).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(app_name())");
            entity.Property(e => e.VehImage).IsRequired().IsUnicode(false);
            entity.Property(e => e.TypeCode).IsRequired().IsUnicode(false);
            entity.Property(e => e.VehYear).IsRequired();
        });

        modelBuilder.Entity<VehicleType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VehicleT__3214EC073EBFD425");

            entity.ToTable("VehicleType", "Vehicle");

            entity.Property(e => e.TypeCode).IsRequired().HasMaxLength(5).IsUnicode(false);
            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.Description).IsRequired().HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.LastUpd).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastUpdApp).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(app_name())");
            entity.Property(e => e.LastUpdBy).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(suser_sname())");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserType__3214EC07D99B68E5");

            entity.ToTable("UserType", "dbo");

            entity.Property(e => e.Description).IsRequired().HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(50).IsUnicode().HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.LastUpd).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastUpdApp).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(app_name())");
            entity.Property(e => e.LastUpdBy).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(suser_sname())");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC0768247E46");

            entity.ToTable("User", "dbo");

            entity.Property(e => e.FirstName).IsRequired().HasMaxLength(20).IsUnicode(false);
            entity.Property(e => e.LastName).IsRequired().HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.EmailAddress).IsRequired().HasMaxLength(20).IsUnicode(false);
            entity.Property(e => e.Password).IsRequired().HasMaxLength(20).IsUnicode(false);
            entity.Property(e => e.TypeId).IsRequired();
            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.LastUpd).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastUpdApp).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(app_name())");
            entity.Property(e => e.LastUpdBy).IsRequired().HasMaxLength(50).IsUnicode(false).HasDefaultValueSql("(suser_sname())");
        });

        this.OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}