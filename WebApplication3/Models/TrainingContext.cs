using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication3.Models
{
    public partial class TrainingContext : DbContext
    {
        public TrainingContext()
        {
        }

        public TrainingContext(DbContextOptions<TrainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=BATMAN\\MSSQLSMILU;Initial Catalog=Training;User ID=sa;password=sa123");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Education>(entity =>
        //    {
        //        entity.Property(e => e.Id)
        //            .HasColumnName("ID")
        //            .HasColumnType("numeric(18, 0)")
        //            .ValueGeneratedOnAdd();

        //        entity.Property(e => e.Description).HasMaxLength(250);
        //    });

        //    modelBuilder.Entity<UserDetails>(entity =>
        //    {
        //        entity.Property(e => e.Id)
        //            .HasColumnName("ID")
        //            .HasColumnType("numeric(18, 0)")
        //            .ValueGeneratedOnAdd();

        //        entity.Property(e => e.EducationId)
        //            .HasColumnName("EducationID")
        //            .HasColumnType("numeric(18, 0)");

        //        entity.Property(e => e.FirstName).HasMaxLength(100);

        //        entity.Property(e => e.Gender)
        //            .HasMaxLength(1)
        //            .IsUnicode(false)
        //            .IsFixedLength();

        //        entity.Property(e => e.LastName).HasMaxLength(50);

        //        entity.Property(e => e.LoginId)
        //            .HasColumnName("LoginID")
        //            .HasColumnType("numeric(18, 0)");

        //        entity.HasOne(d => d.Education)
        //            .WithMany(p => p.UserDetails)
        //            .HasForeignKey(d => d.EducationId)
        //            .HasConstraintName("FK_UserDetails_Education");

        //        entity.HasOne(d => d.Login)
        //            .WithMany(p => p.UserDetails)
        //            .HasForeignKey(d => d.LoginId)
        //            .HasConstraintName("FK_UserDetails_UserLogin");
        //    });

        //    modelBuilder.Entity<UserLogin>(entity =>
        //    {
        //        entity.Property(e => e.Id)
        //            .HasColumnName("ID")
        //            .HasColumnType("numeric(18, 0)")
        //            .ValueGeneratedOnAdd();

        //        entity.Property(e => e.Password)
        //            .IsRequired()
        //            .HasColumnName("password")
        //            .HasMaxLength(50);

        //        entity.Property(e => e.Username).HasMaxLength(50);
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
