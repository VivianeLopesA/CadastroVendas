﻿// <auto-generated />
using System;
using CadastroVendas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadastroVendas.Migrations
{
    [DbContext(typeof(CadastroVendasContext))]
    [Migration("20240502141035_segundaMigrationProduto")]
    partial class segundaMigrationProduto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CadastroVendas.Models.ADM", b =>
                {
                    b.Property<int>("ADMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ADMId"));

                    b.Property<string>("ADMName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ADMId");

                    b.ToTable("ADM");
                });

            modelBuilder.Entity("CadastroVendas.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoID"));

                    b.Property<string>("ProdutoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("ProdutoID");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
