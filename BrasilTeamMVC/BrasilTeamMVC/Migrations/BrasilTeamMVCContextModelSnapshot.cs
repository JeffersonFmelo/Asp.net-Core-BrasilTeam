﻿// <auto-generated />
using BrasilTeamMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrasilTeamMVC.Migrations
{
    [DbContext(typeof(BrasilTeamMVCContext))]
    partial class BrasilTeamMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrasilTeamMVC.Models.Brasil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeJogador");

                    b.Property<byte>("NumeroJogador");

                    b.Property<string>("PosicaoJogador");

                    b.HasKey("Id");

                    b.ToTable("Brasil");
                });
#pragma warning restore 612, 618
        }
    }
}
