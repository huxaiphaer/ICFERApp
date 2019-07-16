﻿// <auto-generated />
using System;
using ICFERApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ICFERApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190716094927_modify tables 1")]
    partial class modifytables1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ICFERApp.Models.Education", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("StudentId");

                    b.Property<string>("AddressOfSchool");

                    b.Property<string>("EducationLevel");

                    b.Property<string>("HeadTeacher");

                    b.Property<string>("School");

                    b.Property<string>("Telephone");

                    b.HasKey("Id", "StudentId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Education");
                });

            modelBuilder.Entity("ICFERApp.Models.Guardian", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("StudentId");

                    b.Property<string>("Comments");

                    b.Property<string>("EmployersName");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("MobileNo");

                    b.Property<string>("MonthlyIncome");

                    b.Property<string>("Occupation");

                    b.Property<string>("PhysicalLocation");

                    b.Property<string>("RelationshipToOrphan");

                    b.Property<string>("WorkAddress");

                    b.HasKey("Id", "StudentId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Guardian");
                });

            modelBuilder.Entity("ICFERApp.Models.Parents", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("StudentId");

                    b.Property<DateTime>("DateOfDemiseOfFather");

                    b.Property<DateTime>("DateOfDemiseOfMother");

                    b.Property<string>("MaritalStatusOfMother");

                    b.Property<double>("MonthlyIncome");

                    b.Property<string>("NamesOfFather");

                    b.Property<string>("NamesOfMother");

                    b.Property<string>("OccupationOfMother");

                    b.Property<string>("ReligionOfDeceasedFather");

                    b.Property<string>("ReligionOfDeceasedMother");

                    b.Property<string>("ReligionOfMother");

                    b.HasKey("Id", "StudentId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("ICFERApp.Models.Siblings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("StudentId");

                    b.Property<int>("NumberOfBrothers");

                    b.Property<int>("NumberOfSisters");

                    b.HasKey("Id", "StudentId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Siblings");
                });

            modelBuilder.Entity("ICFERApp.Models.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("City");

                    b.Property<string>("CountryOfResidence");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Deceased");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("HomeAddress");

                    b.Property<string>("LastName");

                    b.Property<string>("MedicalCondition");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Nationality");

                    b.Property<string>("Religion");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ICFERApp.Models.Education", b =>
                {
                    b.HasOne("ICFERApp.Models.Student", "Student")
                        .WithOne("Education")
                        .HasForeignKey("ICFERApp.Models.Education", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ICFERApp.Models.Guardian", b =>
                {
                    b.HasOne("ICFERApp.Models.Student", "Student")
                        .WithOne("Guardian")
                        .HasForeignKey("ICFERApp.Models.Guardian", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ICFERApp.Models.Parents", b =>
                {
                    b.HasOne("ICFERApp.Models.Student", "Student")
                        .WithOne("Parents")
                        .HasForeignKey("ICFERApp.Models.Parents", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ICFERApp.Models.Siblings", b =>
                {
                    b.HasOne("ICFERApp.Models.Student", "Student")
                        .WithOne("Siblings")
                        .HasForeignKey("ICFERApp.Models.Siblings", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
