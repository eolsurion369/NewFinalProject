using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NW_Central_Library.Models
{
    public partial class LibProjectContext : DbContext
    {
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AdultMember> AdultMember { get; set; }
        public virtual DbSet<AdultMemberAddress> AdultMemberAddress { get; set; }
        public virtual DbSet<CheckOut> CheckOut { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<JuvenileMember> JuvenileMember { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<MediaCopy> MediaCopy { get; set; }
        public virtual DbSet<MediaFormat> MediaFormat { get; set; }
        public virtual DbSet<MediaType> MediaType { get; set; }
        public virtual DbSet<MediaTypeGenre> MediaTypeGenre { get; set; }

        public LibProjectContext(DbContextOptions<LibProjectContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddrLn1)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.AddrLn2)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdultMember>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MidInit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdultMemberAddress>(entity =>
            {
                entity.HasKey(e => new { e.MemberId, e.AddressId });

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.AdultMemberAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberAddress_Address");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.AdultMemberAddress)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberAddress_AdultMember");
            });

            modelBuilder.Entity<CheckOut>(entity =>
            {
                entity.HasKey(e => new { e.AdultId, e.MediaCopyId });

                entity.Property(e => e.AdultId).HasColumnName("AdultID");

                entity.Property(e => e.MediaCopyId).HasColumnName("MediaCopyID");

                entity.Property(e => e.CheckedInDate).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.JuvenileId).HasColumnName("JuvenileID");

                entity.HasOne(d => d.Adult)
                    .WithMany(p => p.CheckOut)
                    .HasForeignKey(d => d.AdultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdultCheckOut_AdultMember");

                entity.HasOne(d => d.MediaCopy)
                    .WithMany(p => p.CheckOut)
                    .HasForeignKey(d => d.MediaCopyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdultCheckOut_MediaCopy");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Genre1)
                    .IsRequired()
                    .HasColumnName("Genre")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JuvenileMember>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.AdultId });

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdultId).HasColumnName("AdultID");

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MidInit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Adult)
                    .WithMany(p => p.JuvenileMember)
                    .HasForeignKey(d => d.AdultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JuvenileMember_AdultMember");
            });

            modelBuilder.Entity<Media>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.GenreNavigation)
                    .WithMany(p => p.Media)
                    .HasForeignKey(d => d.Genre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Media_Genre");
            });

            modelBuilder.Entity<MediaCopy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MediaFormatId)
                    .IsRequired()
                    .HasColumnName("MediaFormatID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MediaId).HasColumnName("MediaID");

                entity.Property(e => e.MediaTypeId)
                    .IsRequired()
                    .HasColumnName("MediaTypeID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.MediaFormat)
                    .WithMany(p => p.MediaCopy)
                    .HasForeignKey(d => d.MediaFormatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MediaCopy_MeidaFormat");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.MediaCopy)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MediaCopy_Media");

                entity.HasOne(d => d.MediaType)
                    .WithMany(p => p.MediaCopy)
                    .HasForeignKey(d => d.MediaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MediaCopy_MediaType");
            });

            modelBuilder.Entity<MediaFormat>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Format)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MediaType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MediaTypeGenre>(entity =>
            {
                entity.HasKey(e => new { e.MediaTypeId, e.GenreId });

                entity.Property(e => e.MediaTypeId)
                    .HasColumnName("MediaTypeID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GenreId)
                    .HasColumnName("GenreID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.MediaTypeGenre)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeGenre_Genre");

                entity.HasOne(d => d.MediaType)
                    .WithMany(p => p.MediaTypeGenre)
                    .HasForeignKey(d => d.MediaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeGenre_MediaType");
            });
        }
    }
}
