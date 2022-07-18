using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication3.Models
{
    public partial class User4Context : DbContext
    {

        public User4Context(DbContextOptions<User4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Costomer5> Costomer5s { get; set; }
        public virtual DbSet<Country5> Country5s { get; set; }
        public virtual DbSet<State2> State2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-75N8VC2; database=User4; trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Costomer5>(entity =>
            {
                entity.ToTable("Costomer5");

                entity.Property(e => e.ConformPass)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Costomer5s)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Costomer5__Count__286302EC");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Costomer5s)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__Costomer5__State__29572725");
            });

            modelBuilder.Entity<Country5>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__Country5__10D1609FE254D620");

                entity.ToTable("Country5");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State2>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK__State2__C3BA3B5A2FA5D0DB");

                entity.ToTable("State2");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
