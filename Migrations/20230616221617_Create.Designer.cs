﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrganizEtec.Data;

#nullable disable

namespace OrganizEtec.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230616221617_Create")]
    partial class Create
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrganizEtec.Models.Integrante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Integrantes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Alex Vitor"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Antonio Mauricio"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Breno Lisboa"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Gustavo Leite"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Rafael Thomas"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Vitor Silva"
                        });
                });

            modelBuilder.Entity("OrganizEtec.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Materia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Prazo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Projetos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Inicio = new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Materia = 2,
                            Nome = "RotaLimpa",
                            Prazo = new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Inicio = new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Materia = 4,
                            Nome = "Finalização do frontend",
                            Prazo = new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Inicio = new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Materia = 6,
                            Nome = "OrganizEtec",
                            Prazo = new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Inicio = new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Materia = 3,
                            Nome = "React Native",
                            Prazo = new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Inicio = new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Materia = 1,
                            Nome = "Atividade BD",
                            Prazo = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("OrganizEtec.Models.Tema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IntegranteId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjetoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IntegranteId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Temas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IntegranteId = 1,
                            Nome = "Criar uma pagina a sua ecolha",
                            ProjetoId = 2
                        },
                        new
                        {
                            Id = 2,
                            IntegranteId = 1,
                            Nome = "Finalizar atividade do dia 12/06",
                            ProjetoId = 5
                        },
                        new
                        {
                            Id = 3,
                            IntegranteId = 1,
                            Nome = "Finalizar projeto do da API",
                            ProjetoId = 3
                        },
                        new
                        {
                            Id = 4,
                            IntegranteId = 1,
                            Nome = "Narrativa Caso de Uso 1/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 5,
                            IntegranteId = 4,
                            Nome = "Narrativa Caso de Uso 2/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 6,
                            IntegranteId = 2,
                            Nome = "Sprint 03 - Apresentação Diagramas UML 1 1/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 7,
                            IntegranteId = 6,
                            Nome = "Sprint 03 - Apresentação Diagramas UML 1 2/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 8,
                            IntegranteId = 1,
                            Nome = "Diagrama de Classe 1/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 9,
                            IntegranteId = 4,
                            Nome = "Diagrama de Classe 2/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 10,
                            IntegranteId = 4,
                            Nome = "Modelo Lógico BD 1/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 11,
                            IntegranteId = 5,
                            Nome = "Modelo Lógico BD 2/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 12,
                            IntegranteId = 1,
                            Nome = "Scripts BD 1/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 13,
                            IntegranteId = 2,
                            Nome = "Scripts BD 2/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 14,
                            IntegranteId = 2,
                            Nome = "Sprint 04 - Apresentação Diagramas UML 1 1/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 15,
                            IntegranteId = 6,
                            Nome = "Sprint 04 - Apresentação Diagramas UML 1 2/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 16,
                            IntegranteId = 3,
                            Nome = "Logo da Empresa 1/2",
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 17,
                            IntegranteId = 5,
                            Nome = "Logo da Empresa 2/2",
                            ProjetoId = 1
                        });
                });

            modelBuilder.Entity("OrganizEtec.Models.Tema", b =>
                {
                    b.HasOne("OrganizEtec.Models.Integrante", "Responsavel")
                        .WithMany()
                        .HasForeignKey("IntegranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrganizEtec.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projeto");

                    b.Navigation("Responsavel");
                });
#pragma warning restore 612, 618
        }
    }
}
