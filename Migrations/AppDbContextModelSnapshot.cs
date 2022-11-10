﻿// <auto-generated />
using E_Commerce_V2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Commerce_V2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Commerce_V2.Models.Caracteristica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Caracteristicas");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.Linea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lineas");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.OrdenDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<int>("OrdenId")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId");

                    b.HasIndex("ProductoId");

                    b.ToTable("OrdenDetalles");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaracteristicaId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaProducto")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Imagen1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LineaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Valoracion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CaracteristicaId");

                    b.HasIndex("LineaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.SubCaracteristica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaracteristicaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CaracteristicaId");

                    b.ToTable("SubCaracteristicas");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.SubLinea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LineaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LineaId");

                    b.ToTable("SubLineas");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.OrdenDetalle", b =>
                {
                    b.HasOne("E_Commerce_V2.Models.Orden", "Orden")
                        .WithMany("ordenDetalles")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce_V2.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orden");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.Producto", b =>
                {
                    b.HasOne("E_Commerce_V2.Models.Caracteristica", "Caracteristica")
                        .WithMany("Productos")
                        .HasForeignKey("CaracteristicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce_V2.Models.Linea", "Linea")
                        .WithMany("Productos")
                        .HasForeignKey("LineaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caracteristica");

                    b.Navigation("Linea");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.SubCaracteristica", b =>
                {
                    b.HasOne("E_Commerce_V2.Models.Caracteristica", "Caracteristica")
                        .WithMany("SubCaracteristicas")
                        .HasForeignKey("CaracteristicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caracteristica");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.SubLinea", b =>
                {
                    b.HasOne("E_Commerce_V2.Models.Linea", "Linea")
                        .WithMany("SubLineas")
                        .HasForeignKey("LineaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Linea");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.Caracteristica", b =>
                {
                    b.Navigation("Productos");

                    b.Navigation("SubCaracteristicas");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.Linea", b =>
                {
                    b.Navigation("Productos");

                    b.Navigation("SubLineas");
                });

            modelBuilder.Entity("E_Commerce_V2.Models.Orden", b =>
                {
                    b.Navigation("ordenDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
