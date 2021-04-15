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
    [Migration("20210415190708_UpdatedQuestionNQuiz")]
    partial class UpdatedQuestionNQuiz
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

                    b.Property<bool>("Accessiblity")
                        .HasColumnType("bit");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Db_Quizzes");
                });

            modelBuilder.Entity("Standards_Final.Sessions.Session_Conn", b =>
                {
                    b.Property<string>("Session_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Is_Host")
                        .HasColumnType("bit");

                    b.HasKey("Session_ID");

                    b.ToTable("Session_Conn");
                });

            modelBuilder.Entity("Standards_Final.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Current_SessionSession_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Current_SessionSession_ID");

                    b.HasIndex("QuizId");

                    b.ToTable("Db_Users");
                });

            modelBuilder.Entity("Standards_Final.Quizlet.Question", b =>
                {
                    b.HasOne("Standards_Final.Quizlet.Quiz", null)
                        .WithMany("Qs")
                        .HasForeignKey("QuizId");
                });

            modelBuilder.Entity("Standards_Final.Quizlet.Quiz", b =>
                {
                    b.HasOne("Standards_Final.Users.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");
                });

            modelBuilder.Entity("Standards_Final.Users.User", b =>
                {
                    b.HasOne("Standards_Final.Sessions.Session_Conn", "Current_Session")
                        .WithMany()
                        .HasForeignKey("Current_SessionSession_ID");

                    b.HasOne("Standards_Final.Quizlet.Quiz", null)
                        .WithMany("AccessUsers")
                        .HasForeignKey("QuizId");
                });
#pragma warning restore 612, 618
        }
    }
}
