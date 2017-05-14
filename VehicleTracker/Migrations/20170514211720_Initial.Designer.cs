using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using VehicleTracker.Models;

namespace VehicleTracker.Migrations
{
    [DbContext(typeof(VehicleContext))]
    [Migration("20170514211720_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleTracker.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("GasAmount");

                    b.Property<int>("TiresNum");

                    b.Property<int>("Type");

                    b.HasKey("VehicleID");

                    b.ToTable("Vehicle");
                });
        }
    }
}
