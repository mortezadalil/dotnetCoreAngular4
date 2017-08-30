﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SuperCoolApp.DAL;
using System;

namespace SuperCoolApp.DAL.Migrations
{
    [DbContext(typeof(CodemyDbContext))]
    partial class CodemyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
#pragma warning restore 612, 618
        }
    }
}
