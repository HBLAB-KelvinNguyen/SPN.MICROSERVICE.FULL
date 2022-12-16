﻿// <auto-generated />
using System;
using DatabaseCore.Infrastructure.ConfigurationEFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DatabaseCore.Infrastructure.Migrations
{
    [DbContext(typeof(EFContext))]
    partial class EFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DatabaseCore.Domain.Entities.Normals.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("timestamp");

                    b.Property<string>("define")
                        .HasColumnType("text");

                    b.Property<int>("fk_userid")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("priority")
                        .HasColumnType("integer");

                    b.Property<int>("totalquestion")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("categories", "usr");
                });

            modelBuilder.Entity("DatabaseCore.Domain.Entities.Normals.Cours", b =>
                {
                    b.Property<int>("Pk_coursId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Pk_coursId"));

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("Target")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("timestamp");

                    b.HasKey("Pk_coursId");

                    b.ToTable("Cours", "usr");
                });

            modelBuilder.Entity("DatabaseCore.Domain.Entities.Normals.Grammar", b =>
                {
                    b.Property<int>("PK_grammarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PK_grammarId"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Concept")
                        .HasColumnType("text");

                    b.Property<int>("FK_UserId")
                        .HasColumnType("integer");

                    b.Property<string>("KD")
                        .HasColumnType("text");

                    b.Property<string>("NV")
                        .HasColumnType("text");

                    b.Property<string>("PD")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("timestamp");

                    b.Property<string>("grammar_content")
                        .HasColumnType("text");

                    b.Property<string>("grammar_name")
                        .HasColumnType("text");

                    b.HasKey("PK_grammarId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Grammar", "usr");
                });

            modelBuilder.Entity("DatabaseCore.Domain.Entities.Normals.Question", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("ImageSource")
                        .HasColumnType("text");

                    b.Property<string>("answer")
                        .HasColumnType("text");

                    b.Property<string>("audio")
                        .HasColumnType("text");

                    b.Property<int>("category_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("timestamp");

                    b.Property<int>("fk_userid")
                        .HasColumnType("integer");

                    b.Property<int>("is_delete")
                        .HasColumnType("integer");

                    b.Property<string>("phonetic")
                        .HasColumnType("text");

                    b.Property<string>("questionname")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("question", "usr");
                });

            modelBuilder.Entity("DatabaseCore.Domain.Entities.Normals.Target", b =>
                {
                    b.Property<int>("PK_TargetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PK_TargetId"));

                    b.Property<int>("FK_UserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("timestamp");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<DateTime>("end_date")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("timestamp");

                    b.Property<string>("target_content")
                        .HasColumnType("text");

                    b.Property<int>("total_days")
                        .HasColumnType("integer");

                    b.HasKey("PK_TargetId");

                    b.ToTable("Target", "usr");
                });

            modelBuilder.Entity("DatabaseCore.Domain.Entities.Normals.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DeviceToken")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int>("isnotification")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("User", "usr");
                });

            modelBuilder.Entity("DatabaseCore.Domain.Entities.Normals.UserManual", b =>
                {
                    b.Property<int>("Pk_UserManual_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Pk_UserManual_Id"));

                    b.Property<string>("DetailExample")
                        .HasColumnType("text");

                    b.Property<string>("Example")
                        .HasColumnType("text");

                    b.Property<int>("Fk_Grannar_Id")
                        .HasColumnType("integer");

                    b.Property<string>("Used")
                        .HasColumnType("text");

                    b.HasKey("Pk_UserManual_Id");

                    b.ToTable("UserManual", "usr");
                });
#pragma warning restore 612, 618
        }
    }
}
