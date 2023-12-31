﻿// <auto-generated />
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(delalalaDBContext))]
    partial class delalalaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Siniflar.Icecekler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrunFiyat")
                        .HasColumnType("int");

                    b.Property<string>("UrunFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunTanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Iceceklers");
                });

            modelBuilder.Entity("EntityLayer.Siniflar.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("EntityLayer.Siniflar.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("EntityLayer.Siniflar.Tatlilar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrunFiyat")
                        .HasColumnType("int");

                    b.Property<string>("UrunFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunTanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Tatlilars");
                });

            modelBuilder.Entity("EntityLayer.Siniflar.Icecekler", b =>
                {
                    b.HasOne("EntityLayer.Siniflar.Kategori", "Kategori")
                        .WithMany("Iceceklers")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("EntityLayer.Siniflar.Tatlilar", b =>
                {
                    b.HasOne("EntityLayer.Siniflar.Kategori", "Kategori")
                        .WithMany("Tatlilars")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("EntityLayer.Siniflar.Kategori", b =>
                {
                    b.Navigation("Iceceklers");

                    b.Navigation("Tatlilars");
                });
#pragma warning restore 612, 618
        }
    }
}
