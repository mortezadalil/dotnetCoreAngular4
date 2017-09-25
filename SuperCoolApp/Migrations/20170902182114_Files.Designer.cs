﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SuperCoolApp.DAL;
using SuperCoolApp.Domain.Enum;
using System;

namespace SuperCoolApp.Migrations
{
    [DbContext(typeof(CodemyDbContext))]
    [Migration("20170902182114_Files")]
    partial class Files
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Title");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CategoryId");

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<string>("Description");

                    b.Property<string>("ImageSrc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.CourseTag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CourseId");

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<long>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TagId");

                    b.ToTable("CourseTags");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.DownloadLink", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<string>("DownloadCount");

                    b.Property<DateTime>("ExpiredDate");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsDeleted");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("DownloadLinks");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("Status");

                    b.Property<string>("TransactionId");

                    b.Property<long>("UserId");

                    b.Property<long>("WorkshopId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkshopId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Post", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Summary");

                    b.Property<string>("Title");

                    b.Property<string>("UrlTitle");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.PostComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<long>("PostId");

                    b.Property<decimal>("Rate");

                    b.Property<string>("Text");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostComments");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.PostTag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<long>("PostId");

                    b.Property<long>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Session", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<int>("Duration");

                    b.Property<string>("FileSrc");

                    b.Property<DateTime>("HoldingDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Title");

                    b.Property<int>("ViewOrder");

                    b.Property<long>("WorkshopId");

                    b.HasKey("Id");

                    b.HasIndex("WorkshopId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.UserDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Test");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Workshop", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<long>("CourseId");

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<string>("Goal");

                    b.Property<DateTime>("HoldingDateTime");

                    b.Property<string>("ImageSrc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("PreRequirements");

                    b.Property<string>("PreviewVideoSrc");

                    b.Property<decimal>("Rate");

                    b.Property<int>("RateCount");

                    b.Property<int>("RateSum");

                    b.Property<long>("TeacherId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Workshops");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.WorkshopComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<decimal>("Rate");

                    b.Property<string>("Text");

                    b.Property<long>("UserId");

                    b.Property<long>("WorkshopId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkshopId");

                    b.ToTable("WorkshopComments");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.WorkshopFile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<long?>("DownloadLinkId");

                    b.Property<string>("FileSrc");

                    b.Property<int>("FileType");

                    b.Property<bool>("IsDeleted");

                    b.Property<long>("WorkshopId");

                    b.HasKey("Id");

                    b.HasIndex("DownloadLinkId");

                    b.HasIndex("WorkshopId");

                    b.ToTable("WorkshopFiles");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.WorkshopTag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<long>("TagId");

                    b.Property<long>("WorkshopId");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("WorkshopId");

                    b.ToTable("WorkShopTags");
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Course", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.CourseTag", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.Course", "Course")
                        .WithMany("CourseTags")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SuperCoolApp.Domain.Entity.Tag", "Tag")
                        .WithMany("CourseTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.DownloadLink", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.UserDetail", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Order", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.UserDetail", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SuperCoolApp.Domain.Entity.Workshop", "Workshop")
                        .WithMany("Orders")
                        .HasForeignKey("WorkshopId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Post", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.PostComment", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.Post", "Post")
                        .WithMany("PostComments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SuperCoolApp.Domain.Entity.UserDetail", "UserDetail")
                        .WithMany("PostComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.PostTag", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SuperCoolApp.Domain.Entity.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Session", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.Workshop", "Workshop")
                        .WithMany("Sessions")
                        .HasForeignKey("WorkshopId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.Workshop", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.Course", "Course")
                        .WithMany("Workshops")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SuperCoolApp.Domain.Entity.UserDetail", "UserDetail")
                        .WithMany("Workshops")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.WorkshopComment", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.UserDetail", "UserDetail")
                        .WithMany("CourseComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SuperCoolApp.Domain.Entity.Workshop", "Workshop")
                        .WithMany("CourseComments")
                        .HasForeignKey("WorkshopId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.WorkshopFile", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.DownloadLink")
                        .WithMany("WorkshopFiles")
                        .HasForeignKey("DownloadLinkId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SuperCoolApp.Domain.Entity.Workshop", "Workshop")
                        .WithMany()
                        .HasForeignKey("WorkshopId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SuperCoolApp.Domain.Entity.WorkshopTag", b =>
                {
                    b.HasOne("SuperCoolApp.Domain.Entity.Tag", "Tag")
                        .WithMany("WorkshopTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SuperCoolApp.Domain.Entity.Workshop", "Workshop")
                        .WithMany("WorkshopTags")
                        .HasForeignKey("WorkshopId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}