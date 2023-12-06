using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Model
{
    public partial class QLTHUVIENContext : DbContext
    {
        public QLTHUVIENContext()
        {
        }

        public QLTHUVIENContext(DbContextOptions<QLTHUVIENContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Docgium> Docgia { get; set; } = null!;
        public virtual DbSet<Ngonngu> Ngonngus { get; set; } = null!;
        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;
        public virtual DbSet<Nhaxuatban> Nhaxuatbans { get; set; } = null!;
        public virtual DbSet<Phieumuon> Phieumuons { get; set; } = null!;
        public virtual DbSet<Phieumuonct> Phieumuoncts { get; set; } = null!;
        public virtual DbSet<Phieutra> Phieutras { get; set; } = null!;
        public virtual DbSet<Phieutract> Phieutracts { get; set; } = null!;
        public virtual DbSet<Sach> Saches { get; set; } = null!;
        public virtual DbSet<Sachchitiet> Sachchitiets { get; set; } = null!;
        public virtual DbSet<Tacgium> Tacgia { get; set; } = null!;
        public virtual DbSet<Theloai> Theloais { get; set; } = null!;
        public virtual DbSet<Xulyvp> Xulyvps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=HOANGTHANHGIANG\\SQLEXPRESS;Database=QLTHUVIEN;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docgium>(entity =>
            {
                entity.HasKey(e => e.Sothe)
                    .HasName("PK__DOCGIA__85462D9709B42E03");

                entity.ToTable("DOCGIA");

                entity.Property(e => e.Sothe)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOTHE");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CCCD");

                entity.Property(e => e.Diachi).HasColumnName("DIACHI");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");

                entity.Property(e => e.Hoten)
                    .HasMaxLength(50)
                    .HasColumnName("HOTEN");

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANV");

                entity.Property(e => e.Ngaycap)
                    .HasColumnType("date")
                    .HasColumnName("NGAYCAP");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("date")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("NGAYSINH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Docgia)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DOCGIA__MANV__412EB0B6");
            });

            modelBuilder.Entity<Ngonngu>(entity =>
            {
                entity.HasKey(e => e.Mangonngu)
                    .HasName("PK__NGONNGU__92B033FAC8001111");

                entity.ToTable("NGONNGU");

                entity.Property(e => e.Mangonngu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANGONNGU");

                entity.Property(e => e.Ghichu).HasColumnName("GHICHU");

                entity.Property(e => e.Tenngonngu)
                    .HasMaxLength(50)
                    .HasColumnName("TENNGONNGU");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manv)
                    .HasName("PK__NHANVIEN__603F5114F9EAD1DF");

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANV");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CCCD");

                entity.Property(e => e.Chucdanh)
                    .HasMaxLength(50)
                    .HasColumnName("CHUCDANH");

                entity.Property(e => e.Diachi).HasColumnName("DIACHI");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");

                entity.Property(e => e.Hoten)
                    .HasMaxLength(50)
                    .HasColumnName("HOTEN");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("NGAYSINH");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<Nhaxuatban>(entity =>
            {
                entity.HasKey(e => e.Manxb)
                    .HasName("PK__NHAXUATB__7ABD9EF29C300C8C");

                entity.ToTable("NHAXUATBAN");

                entity.Property(e => e.Manxb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANXB");

                entity.Property(e => e.Ghichu).HasColumnName("GHICHU");

                entity.Property(e => e.Tennxb)
                    .HasMaxLength(50)
                    .HasColumnName("TENNXB");
            });

            modelBuilder.Entity<Phieumuon>(entity =>
            {
                entity.HasKey(e => e.Mamuon)
                    .HasName("PK__PHIEUMUO__5065699E1820ADA7");

                entity.ToTable("PHIEUMUON");

                entity.Property(e => e.Mamuon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAMUON");

                entity.Property(e => e.Hantra)
                    .HasColumnType("date")
                    .HasColumnName("HANTRA");

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANV");

                entity.Property(e => e.Ngaymuon)
                    .HasColumnType("date")
                    .HasColumnName("NGAYMUON");

                entity.Property(e => e.Sothe)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOTHE");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.SotheNavigation)
                    .WithMany(p => p.Phieumuons)
                    .HasForeignKey(d => d.Sothe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUMUON__SOTHE__4CA06362");
            });

            modelBuilder.Entity<Phieumuonct>(entity =>
            {
                entity.ToTable("PHIEUMUONCT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mamuon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAMUON");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.HasOne(d => d.MamuonNavigation)
                    .WithMany(p => p.Phieumuoncts)
                    .HasForeignKey(d => d.Mamuon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUMUON__MAMUO__4F7CD00D");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.Phieumuoncts)
                    .HasForeignKey(d => d.Masach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUMUON__MASAC__5070F446");
            });

            modelBuilder.Entity<Phieutra>(entity =>
            {
                entity.HasKey(e => e.Matra)
                    .HasName("PK__PHIEUTRA__58240C494AAAEA72");

                entity.ToTable("PHIEUTRA");

                entity.Property(e => e.Matra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATRA");

                entity.Property(e => e.Hantra)
                    .HasColumnType("date")
                    .HasColumnName("HANTRA");

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANV");

                entity.Property(e => e.Ngaymuon)
                    .HasColumnType("date")
                    .HasColumnName("NGAYMUON");

                entity.Property(e => e.Ngaytra)
                    .HasColumnType("date")
                    .HasColumnName("NGAYTRA");

                entity.Property(e => e.Sothe)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOTHE");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Phieutras)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUTRA__MANV__5441852A");

                entity.HasOne(d => d.SotheNavigation)
                    .WithMany(p => p.Phieutras)
                    .HasForeignKey(d => d.Sothe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUTRA__SOTHE__534D60F1");
            });

            modelBuilder.Entity<Phieutract>(entity =>
            {
                entity.ToTable("PHIEUTRACT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH");

                entity.Property(e => e.Matra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATRA");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.Phieutracts)
                    .HasForeignKey(d => d.Masach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUTRAC__MASAC__5812160E");

                entity.HasOne(d => d.MatraNavigation)
                    .WithMany(p => p.Phieutracts)
                    .HasForeignKey(d => d.Matra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUTRAC__MATRA__571DF1D5");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.Masach)
                    .HasName("PK__SACH__3FC48E4C40C6965A");

                entity.ToTable("SACH");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH");

                entity.Property(e => e.
                Manxb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANXB");

                entity.Property(e => e.Ngaycn)
                    .HasColumnType("date")
                    .HasColumnName("NGAYCN");

                entity.Property(e => e.Ngayxb)
                    .HasColumnType("date")
                    .HasColumnName("NGAYXB");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Sotrang).HasColumnName("SOTRANG");

                entity.Property(e => e.Tensach)
                    .HasMaxLength(50)
                    .HasColumnName("TENSACH");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.ManxbNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.Manxb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SACH__MANXB__440B1D61");
            });

            modelBuilder.Entity<Sachchitiet>(entity =>
            {
                entity.ToTable("SACHCHITIET");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mangonngu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANGONNGU");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH");

                entity.Property(e => e.Matacgia)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATACGIA");

                entity.Property(e => e.Matheloai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATHELOAI");

                entity.HasOne(d => d.MangonnguNavigation)
                    .WithMany(p => p.Sachchitiets)
                    .HasForeignKey(d => d.Mangonngu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SACHCHITI__MANGO__49C3F6B7");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.Sachchitiets)
                    .HasForeignKey(d => d.Masach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SACHCHITI__MASAC__46E78A0C");

                entity.HasOne(d => d.MatacgiaNavigation)
                    .WithMany(p => p.Sachchitiets)
                    .HasForeignKey(d => d.Matacgia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SACHCHITI__MATAC__47DBAE45");

                entity.HasOne(d => d.MatheloaiNavigation)
                    .WithMany(p => p.Sachchitiets)
                    .HasForeignKey(d => d.Matheloai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SACHCHITI__MATHE__48CFD27E");
            });

            modelBuilder.Entity<Tacgium>(entity =>
            {
                entity.HasKey(e => e.Matacgia)
                    .HasName("PK__TACGIA__C57C166D3A775E74");

                entity.ToTable("TACGIA");

                entity.Property(e => e.Matacgia)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATACGIA");

                entity.Property(e => e.Ghichi).HasColumnName("GHICHI");

                entity.Property(e => e.Tentacgia)
                    .HasMaxLength(50)
                    .HasColumnName("TENTACGIA");
            });

            modelBuilder.Entity<Theloai>(entity =>
            {
                entity.HasKey(e => e.Matheloai)
                    .HasName("PK__THELOAI__AC8D7C2B599906CB");

                entity.ToTable("THELOAI");

                entity.Property(e => e.Matheloai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATHELOAI");

                entity.Property(e => e.Ghichu).HasColumnName("GHICHU");

                entity.Property(e => e.Tentheloai)
                    .HasMaxLength(50)
                    .HasColumnName("TENTHELOAI");
            });

            modelBuilder.Entity<Xulyvp>(entity =>
            {
                entity.HasKey(e => e.Maxuly)
                    .HasName("PK__XULYVP__CC5EFEA7B2126360");

                entity.ToTable("XULYVP");

                entity.Property(e => e.Maxuly)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAXULY");

                entity.Property(e => e.Htxuly).HasColumnName("HTXULY");

                entity.Property(e => e.Lydovp).HasColumnName("LYDOVP");

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANV");

                entity.Property(e => e.Matra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATRA");

                entity.Property(e => e.Ngayxl)
                    .HasColumnType("date")
                    .HasColumnName("NGAYXL");

                entity.Property(e => e.Sothe)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOTHE");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Xulyvps)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__XULYVP__MANV__5CD6CB2B");

                entity.HasOne(d => d.MatraNavigation)
                    .WithMany(p => p.Xulyvps)
                    .HasForeignKey(d => d.Matra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__XULYVP__MATRA__5AEE82B9");

                entity.HasOne(d => d.SotheNavigation)
                    .WithMany(p => p.Xulyvps)
                    .HasForeignKey(d => d.Sothe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__XULYVP__SOTHE__5BE2A6F2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
