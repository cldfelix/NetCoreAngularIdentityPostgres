using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TemplateAngularNetcore.Models;

namespace TemplateAngularNetcore.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170818184019_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("TemplateAngularNetcore.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<long?>("SupplierId");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TemplateAngularNetcore.Models.Rating", b =>
                {
                    b.Property<long>("RatingId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ProductId");

                    b.Property<int>("Stars");

                    b.HasKey("RatingId");

                    b.HasIndex("ProductId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("TemplateAngularNetcore.Models.Supplier", b =>
                {
                    b.Property<long>("SupplierId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("TemplateAngularNetcore.Models.Product", b =>
                {
                    b.HasOne("TemplateAngularNetcore.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("TemplateAngularNetcore.Models.Rating", b =>
                {
                    b.HasOne("TemplateAngularNetcore.Models.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId");
                });
        }
    }
}
