﻿// <auto-generated />
using System;
using HospitalManegement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalManegement.Migrations
{
    [DbContext(typeof(HositalContext))]
    [Migration("20220429000120_edit")]
    partial class edit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalManegement.Models.Bed", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bedfloor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospitalsid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("available")
                        .HasColumnType("bit");

                    b.Property<int>("bednumber")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Hospitalsid");

                    b.ToTable("Beds");
                });

            modelBuilder.Entity("HospitalManegement.Models.BookingDoctor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doctorid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("patientid")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("reservedate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("id");

                    b.HasIndex("doctorid");

                    b.HasIndex("patientid");

                    b.ToTable("BookingDoctors");
                });

            modelBuilder.Entity("HospitalManegement.Models.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hospitalsid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Hospitalsid");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HospitalManegement.Models.Doctor", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DAge")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DBd")
                        .HasColumnType("datetime2");

                    b.Property<string>("DGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DPass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DidId")
                        .HasColumnType("int");

                    b.Property<string>("Hospitalsid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UseryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("departmentid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Hospitalsid");

                    b.HasIndex("UseryId")
                        .IsUnique()
                        .HasFilter("[UseryId] IS NOT NULL");

                    b.HasIndex("departmentid");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HospitalManegement.Models.Hospitals", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("HospitalManegement.Models.Patient", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Hospitalsid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("PAge")
                        .HasColumnType("int");

                    b.Property<string>("PFirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserxId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("Hospitalsid");

                    b.HasIndex("PFirstName");

                    b.HasIndex("UserxId")
                        .IsUnique()
                        .HasFilter("[UserxId] IS NOT NULL");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HospitalManegement.Models.bookingBed", b =>
                {
                    b.Property<string>("bedid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("patientid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Hospitalsid")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("bedid", "patientid");

                    b.HasIndex("Hospitalsid");

                    b.HasIndex("patientid");

                    b.ToTable("BookingBeds");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HospitalManegement.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("HospitalManegement.Models.Bed", b =>
                {
                    b.HasOne("HospitalManegement.Models.Hospitals", "Hospitals")
                        .WithMany()
                        .HasForeignKey("Hospitalsid");

                    b.Navigation("Hospitals");
                });

            modelBuilder.Entity("HospitalManegement.Models.BookingDoctor", b =>
                {
                    b.HasOne("HospitalManegement.Models.Doctor", "doctor")
                        .WithMany("bookingDoctors")
                        .HasForeignKey("doctorid");

                    b.HasOne("HospitalManegement.Models.Patient", "patient")
                        .WithMany("bookingDoctors")
                        .HasForeignKey("patientid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("HospitalManegement.Models.Department", b =>
                {
                    b.HasOne("HospitalManegement.Models.Hospitals", "Hospitals")
                        .WithMany()
                        .HasForeignKey("Hospitalsid");

                    b.Navigation("Hospitals");
                });

            modelBuilder.Entity("HospitalManegement.Models.Doctor", b =>
                {
                    b.HasOne("HospitalManegement.Models.Hospitals", "Hospitals")
                        .WithMany()
                        .HasForeignKey("Hospitalsid");

                    b.HasOne("HospitalManegement.Models.ApplicationUser", "AppUser")
                        .WithOne("doctor")
                        .HasForeignKey("HospitalManegement.Models.Doctor", "UseryId");

                    b.HasOne("HospitalManegement.Models.Department", "department")
                        .WithMany("doctors")
                        .HasForeignKey("departmentid");

                    b.Navigation("AppUser");

                    b.Navigation("department");

                    b.Navigation("Hospitals");
                });

            modelBuilder.Entity("HospitalManegement.Models.Patient", b =>
                {
                    b.HasOne("HospitalManegement.Models.Hospitals", "Hospitals")
                        .WithMany()
                        .HasForeignKey("Hospitalsid");

                    b.HasOne("HospitalManegement.Models.ApplicationUser", "AppUser")
                        .WithOne("patient")
                        .HasForeignKey("HospitalManegement.Models.Patient", "UserxId");

                    b.Navigation("AppUser");

                    b.Navigation("Hospitals");
                });

            modelBuilder.Entity("HospitalManegement.Models.bookingBed", b =>
                {
                    b.HasOne("HospitalManegement.Models.Hospitals", "Hospitals")
                        .WithMany()
                        .HasForeignKey("Hospitalsid");

                    b.HasOne("HospitalManegement.Models.Bed", "bed")
                        .WithMany()
                        .HasForeignKey("bedid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManegement.Models.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("patientid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bed");

                    b.Navigation("Hospitals");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManegement.Models.Department", b =>
                {
                    b.Navigation("doctors");
                });

            modelBuilder.Entity("HospitalManegement.Models.Doctor", b =>
                {
                    b.Navigation("bookingDoctors");
                });

            modelBuilder.Entity("HospitalManegement.Models.Patient", b =>
                {
                    b.Navigation("bookingDoctors");
                });

            modelBuilder.Entity("HospitalManegement.Models.ApplicationUser", b =>
                {
                    b.Navigation("doctor");

                    b.Navigation("patient");
                });
#pragma warning restore 612, 618
        }
    }
}
