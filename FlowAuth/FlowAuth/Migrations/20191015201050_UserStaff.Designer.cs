﻿// <auto-generated />
using System;
using FlowAuth.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlowAuth.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191015201050_UserStaff")]
    partial class UserStaff
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlowAuth.Models.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("FlowAuth.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

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

                    b.Property<int>("StaffID");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("StaffID")
                        .IsUnique();

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FlowAuth.Models.Assigned", b =>
                {
                    b.Property<int>("AssignedID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Project_Code")
                        .IsRequired();

                    b.Property<int>("StaffID");

                    b.HasKey("AssignedID");

                    b.HasIndex("Project_Code");

                    b.HasIndex("StaffID");

                    b.ToTable("Assigned");
                });

            modelBuilder.Entity("FlowAuth.Models.Claim", b =>
                {
                    b.Property<int>("ClaimID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Claim_amount");

                    b.Property<DateTime>("Claim_date");

                    b.Property<string>("Claim_description")
                        .IsRequired();

                    b.Property<string>("Claim_status");

                    b.Property<int>("StaffID");

                    b.Property<int?>("UserId");

                    b.HasKey("ClaimID");

                    b.HasIndex("StaffID");

                    b.HasIndex("UserId");

                    b.ToTable("Claim");
                });

            modelBuilder.Entity("FlowAuth.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account_status")
                        .IsRequired();

                    b.Property<DateTime>("Client_DOB");

                    b.Property<string>("Client_contactEmail")
                        .IsRequired();

                    b.Property<string>("Client_contactName")
                        .IsRequired();

                    b.Property<long>("Client_contactNo");

                    b.Property<long>("Client_id_no");

                    b.Property<string>("Client_name")
                        .IsRequired();

                    b.Property<string>("Client_service")
                        .IsRequired();

                    b.Property<int>("Client_workNo");

                    b.Property<string>("Client_work_address");

                    b.Property<string>("Company_regNo");

                    b.HasKey("ClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("FlowAuth.Models.Leave", b =>
                {
                    b.Property<int>("LeaveID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Leave_days_taken");

                    b.Property<DateTime>("Leave_endDate");

                    b.Property<string>("Leave_motivation");

                    b.Property<DateTime>("Leave_startDate");

                    b.Property<string>("Leave_status");

                    b.Property<int>("Leave_type");

                    b.Property<int>("StaffID");

                    b.Property<int?>("UserId");

                    b.HasKey("LeaveID");

                    b.HasIndex("StaffID");

                    b.HasIndex("UserId");

                    b.ToTable("Leave");
                });

            modelBuilder.Entity("FlowAuth.Models.Log", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Log_date");

                    b.Property<double>("Log_hours");

                    b.Property<string>("Project_Code")
                        .IsRequired();

                    b.Property<int>("StaffID");

                    b.Property<int>("TaskDescriptionID");

                    b.HasKey("LogID");

                    b.HasIndex("Project_Code");

                    b.HasIndex("StaffID");

                    b.HasIndex("TaskDescriptionID");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("FlowAuth.Models.Project", b =>
                {
                    b.Property<string>("Project_Code");

                    b.Property<int>("ClientID");

                    b.Property<double>("Project_budget");

                    b.Property<string>("Project_description")
                        .IsRequired();

                    b.Property<DateTime>("Project_dueDate");

                    b.Property<DateTime>("Project_endDate");

                    b.Property<string>("Project_location")
                        .IsRequired();

                    b.Property<string>("Project_nature")
                        .IsRequired();

                    b.Property<DateTime>("Project_startDate");

                    b.Property<string>("Project_status")
                        .IsRequired();

                    b.HasKey("Project_Code");

                    b.HasIndex("ClientID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("FlowAuth.Models.Staff", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Staff_DOB");

                    b.Property<int>("Staff_cellphone");

                    b.Property<string>("Staff_country")
                        .IsRequired();

                    b.Property<string>("Staff_email")
                        .IsRequired();

                    b.Property<string>("Staff_emp_nature")
                        .IsRequired();

                    b.Property<string>("Staff_fullName")
                        .IsRequired();

                    b.Property<long>("Staff_idNum");

                    b.Property<long>("Staff_incomeTax");

                    b.Property<DateTime>("Staff_lastDay");

                    b.Property<string>("Staff_medicalAid")
                        .IsRequired();

                    b.Property<long>("Staff_medicalAidNo");

                    b.Property<int>("Staff_nextKin_cellphone");

                    b.Property<string>("Staff_nextKin_name")
                        .IsRequired();

                    b.Property<long>("Staff_passport");

                    b.Property<string>("Staff_position")
                        .IsRequired();

                    b.Property<string>("Staff_res_addr")
                        .IsRequired();

                    b.Property<string>("Staff_type")
                        .IsRequired();

                    b.HasKey("StaffID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("FlowAuth.Models.SuppliedBy", b =>
                {
                    b.Property<int>("SuppliedByID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Project_Code")
                        .IsRequired();

                    b.Property<int>("SupplierID");

                    b.HasKey("SuppliedByID");

                    b.HasIndex("Project_Code");

                    b.HasIndex("SupplierID");

                    b.ToTable("SuppliedBy");
                });

            modelBuilder.Entity("FlowAuth.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Supplier_address")
                        .IsRequired();

                    b.Property<string>("Supplier_bank_accNumber")
                        .IsRequired();

                    b.Property<string>("Supplier_bank_accType")
                        .IsRequired();

                    b.Property<string>("Supplier_bank_branch")
                        .IsRequired();

                    b.Property<string>("Supplier_bank_name")
                        .IsRequired();

                    b.Property<string>("Supplier_contactName")
                        .IsRequired();

                    b.Property<int>("Supplier_contactNo");

                    b.Property<string>("Supplier_name")
                        .IsRequired();

                    b.Property<string>("Supplier_reg_no")
                        .IsRequired();

                    b.Property<string>("Supplier_services")
                        .IsRequired();

                    b.Property<double>("Supplier_vatNo");

                    b.HasKey("SupplierID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("FlowAuth.Models.TaskDescription", b =>
                {
                    b.Property<int>("TaskDescriptionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Task_name")
                        .IsRequired();

                    b.HasKey("TaskDescriptionID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FlowAuth.Models.AppUser", b =>
                {
                    b.HasOne("FlowAuth.Models.Staff", "Staff")
                        .WithOne("AppUser")
                        .HasForeignKey("FlowAuth.Models.AppUser", "StaffID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FlowAuth.Models.Assigned", b =>
                {
                    b.HasOne("FlowAuth.Models.Project", "Project")
                        .WithMany("Assigneds")
                        .HasForeignKey("Project_Code")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FlowAuth.Models.Staff", "Staff")
                        .WithMany("Assigneds")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FlowAuth.Models.Claim", b =>
                {
                    b.HasOne("FlowAuth.Models.Staff", "Staff")
                        .WithMany("Claims")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FlowAuth.Models.AppUser", "AppUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FlowAuth.Models.Leave", b =>
                {
                    b.HasOne("FlowAuth.Models.Staff", "Staff")
                        .WithMany("Leaves")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FlowAuth.Models.AppUser", "AppUser")
                        .WithMany("Leaves")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FlowAuth.Models.Log", b =>
                {
                    b.HasOne("FlowAuth.Models.Project", "Project")
                        .WithMany("Logs")
                        .HasForeignKey("Project_Code")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FlowAuth.Models.Staff", "Staff")
                        .WithMany("Logs")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FlowAuth.Models.TaskDescription", "TaskDescription")
                        .WithMany("Logs")
                        .HasForeignKey("TaskDescriptionID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FlowAuth.Models.Project", b =>
                {
                    b.HasOne("FlowAuth.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FlowAuth.Models.SuppliedBy", b =>
                {
                    b.HasOne("FlowAuth.Models.Project", "Project")
                        .WithMany("SuppliedBys")
                        .HasForeignKey("Project_Code")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FlowAuth.Models.Supplier", "Supplier")
                        .WithMany("SuppliedBys")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("FlowAuth.Models.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("FlowAuth.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("FlowAuth.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("FlowAuth.Models.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FlowAuth.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("FlowAuth.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
