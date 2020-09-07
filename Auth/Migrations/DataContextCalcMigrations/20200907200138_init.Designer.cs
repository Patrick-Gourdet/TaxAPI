﻿// <auto-generated />
using System;
using Auth.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Auth.Migrations.DataContextCalcMigrations
{
    [DbContext(typeof(DataContextCalc))]
    [Migration("20200907200138_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("Auth.Model.TaxCalculationItemEvent", b =>
                {
                    b.Property<Guid>("CalcId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CalculatedAmount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Percent")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TaxId")
                        .HasColumnType("TEXT");

                    b.HasKey("CalcId");

                    b.ToTable("taxCalcItem");
                });
#pragma warning restore 612, 618
        }
    }
}
