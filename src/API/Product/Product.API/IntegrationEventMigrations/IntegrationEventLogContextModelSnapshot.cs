﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using BigPurpleBank.Common.IntegrationEventLogEF;

namespace Catalog.API.Migrations
{
    [DbContext(typeof(IntegrationEventLogContext))]
    partial class IntegrationEventLogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BigPurpleBank.Common.IntegrationEventLogEF.IntegrationEventLogEntry", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("EventTypeName")
                        .IsRequired();

                    b.Property<int>("State");

                    b.Property<int>("TimesSent");

                    b.Property<string>("TransactionId");

                    b.HasKey("EventId");

                    b.ToTable("IntegrationEventLog");
                });
#pragma warning restore 612, 618
        }
    }
}
