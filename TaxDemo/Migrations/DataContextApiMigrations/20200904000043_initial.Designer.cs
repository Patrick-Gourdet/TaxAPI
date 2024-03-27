﻿// <auto-generated />
using System;
using TaxDemo.DataAccess;
using TaxDemo.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TaxDemo.Migrations.DataContextApiMigrations
{
    [DbContext(typeof(DataContextApi))]
    [Migration("20200904000043_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("TaxDemo.Model.ApiDbItem", b =>
                {
                    b.Property<Guid>("ApiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("APIName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApiKey")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("UserHash")
                        .HasColumnType("BLOB");

                    b.HasKey("ApiId");

                    b.ToTable("apiDBItem");
                });
#pragma warning restore 612, 618
        }
    }
}
