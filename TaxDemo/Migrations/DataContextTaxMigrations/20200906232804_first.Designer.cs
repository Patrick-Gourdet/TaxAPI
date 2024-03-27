﻿// <auto-generated />
using System;
using TaxDemo.DataAccess;
using TaxDemo.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TaxDemo.Migrations.DataContextTaxMigrations
{
    [DbContext(typeof(DataContextTax))]
    [Migration("20200906232804_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("TaxDemo.Model.RatesRate", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SubRateId")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("SubRateId");

                    b.ToTable("rates");
                });

            modelBuilder.Entity("TaxDemo.Model.SubRate", b =>
                {
                    b.Property<Guid>("rate_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("city")
                        .HasColumnType("TEXT");

                    b.Property<string>("city_rate")
                        .HasColumnType("TEXT");

                    b.Property<string>("combined_district_rate")
                        .HasColumnType("TEXT");

                    b.Property<string>("combined_rate")
                        .HasColumnType("TEXT");

                    b.Property<string>("country")
                        .HasColumnType("TEXT");

                    b.Property<string>("country_rate")
                        .HasColumnType("TEXT");

                    b.Property<string>("county")
                        .HasColumnType("TEXT");

                    b.Property<string>("county_rate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("freight_taxable")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("state")
                        .HasColumnType("TEXT");

                    b.Property<string>("state_rate")
                        .HasColumnType("TEXT");

                    b.Property<string>("zip")
                        .HasColumnType("TEXT");

                    b.HasKey("rate_id");

                    b.ToTable("SubRate");
                });

            modelBuilder.Entity("TaxDemo.Model.TaxItemEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustmerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndpointUsed")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("taxItem");
                });

            modelBuilder.Entity("TaxDemo.Model.RatesRate", b =>
                {
                    b.HasOne("TaxDemo.Model.SubRate", "rate")
                        .WithMany()
                        .HasForeignKey("SubRateId");
                });
#pragma warning restore 612, 618
        }
    }
}
