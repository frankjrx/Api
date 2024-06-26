﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240316203543_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredientes", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Mesas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantidadPersonas")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mesas", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OrdenMesa", b =>
                {
                    b.Property<int>("OrdenId")
                        .HasColumnType("int");

                    b.Property<int>("MesaId")
                        .HasColumnType("int");

                    b.HasKey("OrdenId", "MesaId");

                    b.HasIndex("MesaId");

                    b.ToTable("OrdenMesas");
                });

            modelBuilder.Entity("Domain.Entities.Ordenes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MesaId")
                        .HasColumnType("int");

                    b.Property<double>("Subtotal")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MesaId");

                    b.ToTable("Ordenes", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OrdenesPlatos", b =>
                {
                    b.Property<int>("OrdenId")
                        .HasColumnType("int");

                    b.Property<int>("PlatoId")
                        .HasColumnType("int");

                    b.HasKey("OrdenId", "PlatoId");

                    b.HasIndex("PlatoId");

                    b.ToTable("OrdenPlatos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Platos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantidadPersonas")
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Platos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.PlatosIngrediente", b =>
                {
                    b.Property<int>("PlatoId")
                        .HasColumnType("int");

                    b.Property<int>("IngredienteId")
                        .HasColumnType("int");

                    b.HasKey("PlatoId", "IngredienteId");

                    b.HasIndex("IngredienteId");

                    b.ToTable("PlatoIngredientes", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OrdenMesa", b =>
                {
                    b.HasOne("Domain.Entities.Mesas", "Mesa")
                        .WithMany("OrdenMesa")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Ordenes", "Orden")
                        .WithMany("OrdenMesa")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Mesa");

                    b.Navigation("Orden");
                });

            modelBuilder.Entity("Domain.Entities.Ordenes", b =>
                {
                    b.HasOne("Domain.Entities.Mesas", "mesa")
                        .WithMany()
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mesa");
                });

            modelBuilder.Entity("Domain.Entities.OrdenesPlatos", b =>
                {
                    b.HasOne("Domain.Entities.Ordenes", "Orden")
                        .WithMany("OrdenesPlatos")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Platos", "Plato")
                        .WithMany("OrdenesPlatos")
                        .HasForeignKey("PlatoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Orden");

                    b.Navigation("Plato");
                });

            modelBuilder.Entity("Domain.Entities.PlatosIngrediente", b =>
                {
                    b.HasOne("Domain.Entities.Ingrediente", "Ingrediente")
                        .WithMany("PlatosIngrediente")
                        .HasForeignKey("IngredienteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Platos", "Plato")
                        .WithMany("PlatosIngrediente")
                        .HasForeignKey("PlatoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ingrediente");

                    b.Navigation("Plato");
                });

            modelBuilder.Entity("Domain.Entities.Ingrediente", b =>
                {
                    b.Navigation("PlatosIngrediente");
                });

            modelBuilder.Entity("Domain.Entities.Mesas", b =>
                {
                    b.Navigation("OrdenMesa");
                });

            modelBuilder.Entity("Domain.Entities.Ordenes", b =>
                {
                    b.Navigation("OrdenMesa");

                    b.Navigation("OrdenesPlatos");
                });

            modelBuilder.Entity("Domain.Entities.Platos", b =>
                {
                    b.Navigation("OrdenesPlatos");

                    b.Navigation("PlatosIngrediente");
                });
#pragma warning restore 612, 618
        }
    }
}
