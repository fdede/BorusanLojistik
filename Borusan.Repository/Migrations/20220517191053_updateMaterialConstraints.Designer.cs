// <auto-generated />
using System;
using Borusan.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Borusan.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220517191053_updateMaterialConstraints")]
    partial class updateMaterialConstraints
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Borusan.Core.Models.AmountType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AmountTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4436),
                            Name = "Adet"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4446),
                            Name = "Koli"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4447),
                            Name = "Paket"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4448),
                            Name = "palet"
                        });
                });

            modelBuilder.Entity("Borusan.Core.Models.Material", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "MLZ-1234",
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4618),
                            Name = "Monitör"
                        },
                        new
                        {
                            Id = 2L,
                            Code = "MLZ-1235",
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4620),
                            Name = "Klavye"
                        },
                        new
                        {
                            Id = 3L,
                            Code = "MLZ-1236",
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4621),
                            Name = "Mouse"
                        });
                });

            modelBuilder.Entity("Borusan.Core.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<long>("AmountTypeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerOrderNo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FromAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MaterialId")
                        .HasColumnType("bigint");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OrderStatusId")
                        .HasColumnType("bigint");

                    b.Property<string>("ToAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("WeightUnitId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AmountTypeId");

                    b.HasIndex("CustomerOrderNo")
                        .IsUnique();

                    b.HasIndex("MaterialId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("WeightUnitId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Borusan.Core.Models.OrderStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4764),
                            Name = "Sipariş Alındı"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4766),
                            Name = "Yola Çıktı"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4767),
                            Name = "Dağıtım Merkezinde"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4767),
                            Name = "Dağıtıma Çıktı"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4768),
                            Name = "Teslim Edildi"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4769),
                            Name = "Teslim Edilemedi"
                        });
                });

            modelBuilder.Entity("Borusan.Core.Models.WeightUnit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WeightUnits");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4875),
                            Name = "Kg"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4877),
                            Name = "Ton"
                        });
                });

            modelBuilder.Entity("Borusan.Core.Models.Order", b =>
                {
                    b.HasOne("Borusan.Core.Models.AmountType", "AmountType")
                        .WithMany("Orders")
                        .HasForeignKey("AmountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Borusan.Core.Models.Material", "Material")
                        .WithMany("Orders")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Borusan.Core.Models.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Borusan.Core.Models.WeightUnit", "WeightUnit")
                        .WithMany("Orders")
                        .HasForeignKey("WeightUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AmountType");

                    b.Navigation("Material");

                    b.Navigation("OrderStatus");

                    b.Navigation("WeightUnit");
                });

            modelBuilder.Entity("Borusan.Core.Models.AmountType", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Borusan.Core.Models.Material", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Borusan.Core.Models.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Borusan.Core.Models.WeightUnit", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
