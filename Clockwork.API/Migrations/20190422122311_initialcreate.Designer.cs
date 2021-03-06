﻿// <auto-generated />
using Clockwork.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Clockwork.API.Migrations
{
    [DbContext(typeof(ClockworkContext))]
    [Migration("20190422122311_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Clockwork.API.Entities.ServerDateTimeRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<string>("IpAddress");

                    b.Property<DateTimeOffset>("ServerDateTime");

                    b.HasKey("Id");

                    b.ToTable("ServerDateTimeRequest");
                });
#pragma warning restore 612, 618
        }
    }
}
