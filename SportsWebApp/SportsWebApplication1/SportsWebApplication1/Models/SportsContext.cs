using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SportsWebApplication1.Models
{
    public partial class SportsContext : DbContext
    {
        public SportsContext()
        {
        }

        public SportsContext(DbContextOptions<SportsContext> options)
            : base(options)
        {
        }

        public static object Current { get; internal set; }
        public virtual DbSet<SportsTable> SportsTable { get; set; }
        public object Response { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Sports;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SportsTable>(entity =>
            {
                entity.ToTable("sports_table");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaxMembers).HasColumnName("max_members");

                entity.Property(e => e.SportsName)
                    .HasColumnName("sports_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SportsType)
                    .HasColumnName("sports_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
