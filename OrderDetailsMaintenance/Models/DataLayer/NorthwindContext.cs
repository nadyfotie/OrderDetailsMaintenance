using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace OrderDetailsMaintenance.Models.DataLayer;

public partial class NorthwindContext : DbContext
{
    // Nady Fotie 
    public NorthwindContext()
    {
    }
    // Nady Fotie 
    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {
    }
    // Nady Fotie 
    public virtual DbSet<Customer> Customers { get; set; }
    // Nady Fotie 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
    // Nady Fotie 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }
    // Nady Fotie 
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
