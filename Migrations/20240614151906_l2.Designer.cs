﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace baithuchanh.Migrations
{
    [DbContext(typeof(LTQDD))]
    [Migration("20240614151906_l2")]
    partial class l2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("baithuchanh.Models.LopHoc", b =>
                {
                    b.Property<string>("MaLop")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaLop");

                    b.ToTable("LopHoc");
                });
#pragma warning restore 612, 618
        }
    }
}
