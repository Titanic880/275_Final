﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Framework_Ent;

namespace Server.Migrations
{
    [DbContext(typeof(Server_DbContext))]
    [Migration("20210414212548_Quiz")]
    partial class Quiz
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Standards_Final.Quizlet.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Accessiblity")
                        .HasColumnType("bit");

                    b.Property<string>("Correct_Answers_Str")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_Question")
                        .HasColumnType("datetime2");

                    b.Property<int>("Question_Time")
                        .HasColumnType("int");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.Property<string>("Vis_Answers_Str")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vis_Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Db_Questions");
                });

            modelBuilder.Entity("Standards_Final.Quizlet.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Db_Quizzes");
                });

            modelBuilder.Entity("Standards_Final.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Db_Users");
                });

            modelBuilder.Entity("Standards_Final.Quizlet.Question", b =>
                {
                    b.HasOne("Standards_Final.Quizlet.Quiz", null)
                        .WithMany("Qs")
                        .HasForeignKey("QuizId");
                });
#pragma warning restore 612, 618
        }
    }
}
