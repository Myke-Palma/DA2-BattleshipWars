﻿// <auto-generated />
using BattleshipPRJ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BattleshipPRJ.Migrations
{
    [DbContext(typeof(BattleshipDbContext))]
    partial class BattleshipDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BattleshipPRJ.Models.HiScoresModel", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Missao");

                    b.Property<string>("NomeJogador");

                    b.Property<double>("PercentagemAfundado");

                    b.Property<double>("PercentagemAlvo");

                    b.Property<string>("Resultado");

                    b.Property<int>("Score");

                    b.Property<int>("TirosAgua");

                    b.Property<int>("TirosAlvo");

                    b.Property<int>("TirosRepetido");

                    b.HasKey("ID");

                    b.ToTable("HiScoresDb");
                });
#pragma warning restore 612, 618
        }
    }
}
