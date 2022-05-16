using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyCocktails.DbModels
{
    public partial class COCKTAILSContext : DbContext
    {
        public COCKTAILSContext()
        {
        }

        public COCKTAILSContext(DbContextOptions<COCKTAILSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cocktail> Cocktail { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserCocktail> UserCocktail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=G1\\SQLEXPRESS;Database=COCKTAILS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cocktail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient1)
                    .HasColumnName("ingredient1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient10)
                    .HasColumnName("ingredient10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient11)
                    .HasColumnName("ingredient11")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient12)
                    .HasColumnName("ingredient12")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient13)
                    .HasColumnName("ingredient13")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient14)
                    .HasColumnName("ingredient14")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient15)
                    .HasColumnName("ingredient15")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient2)
                    .HasColumnName("ingredient2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient3)
                    .HasColumnName("ingredient3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient4)
                    .HasColumnName("ingredient4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient5)
                    .HasColumnName("ingredient5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient6)
                    .HasColumnName("ingredient6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient7)
                    .HasColumnName("ingredient7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient8)
                    .HasColumnName("ingredient8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredient9)
                    .HasColumnName("ingredient9")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Instructions)
                    .HasColumnName("instructions")
                    .IsUnicode(false);

                entity.Property(e => e.Measure1)
                    .HasColumnName("measure1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure10)
                    .HasColumnName("measure10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure11)
                    .HasColumnName("measure11")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure12)
                    .HasColumnName("measure12")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure13)
                    .HasColumnName("measure13")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure14)
                    .HasColumnName("measure14")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure15)
                    .HasColumnName("measure15")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure2)
                    .HasColumnName("measure2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure3)
                    .HasColumnName("measure3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure4)
                    .HasColumnName("measure4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure5)
                    .HasColumnName("measure5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure6)
                    .HasColumnName("measure6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure7)
                    .HasColumnName("measure7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure8)
                    .HasColumnName("measure8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Measure9)
                    .HasColumnName("measure9")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserCocktail>(entity =>
            {
                entity.HasKey(e => new { e.IdUser, e.IdCocktail });

                entity.ToTable("User_Cocktail");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdCocktail).HasColumnName("id_cocktail");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCocktailNavigation)
                    .WithMany(p => p.UserCocktail)
                    .HasForeignKey(d => d.IdCocktail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Cocktail_Cocktail");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserCocktail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Cocktail_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
