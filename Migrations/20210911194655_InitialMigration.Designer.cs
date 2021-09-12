﻿// <auto-generated />
using System;
using ChamadosTI.Models.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChamadosTI.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210911194655_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChamadosTI.Models.Modelo.Chamados", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricaoChamados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("usuariosnomeUsuarioid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("usuariosnomeUsuarioid");

                    b.ToTable("chamadosContext");
                });

            modelBuilder.Entity("ChamadosTI.Models.Modelo.Perifericos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("especificacaoPerifericos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomePerifericos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("quantidadePerifericos")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("perifericosContext");
                });

            modelBuilder.Entity("ChamadosTI.Models.Modelo.Solicitacoes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("nomeUsuarioSolicitacoesid")
                        .HasColumnType("int");

                    b.Property<int?>("perifericosSolicitacoesid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("nomeUsuarioSolicitacoesid");

                    b.HasIndex("perifericosSolicitacoesid");

                    b.ToTable("solicitacoesContext");
                });

            modelBuilder.Entity("ChamadosTI.Models.Modelo.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("maquinaUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("setorUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("usuarioContext");
                });

            modelBuilder.Entity("ChamadosTI.Models.Modelo.Chamados", b =>
                {
                    b.HasOne("ChamadosTI.Models.Modelo.Usuario", "usuariosnomeUsuario")
                        .WithMany("chamados")
                        .HasForeignKey("usuariosnomeUsuarioid");

                    b.Navigation("usuariosnomeUsuario");
                });

            modelBuilder.Entity("ChamadosTI.Models.Modelo.Solicitacoes", b =>
                {
                    b.HasOne("ChamadosTI.Models.Modelo.Usuario", "nomeUsuarioSolicitacoes")
                        .WithMany("solicitacoes")
                        .HasForeignKey("nomeUsuarioSolicitacoesid");

                    b.HasOne("ChamadosTI.Models.Modelo.Perifericos", "perifericosSolicitacoes")
                        .WithMany("SolicitacoesPerifericos")
                        .HasForeignKey("perifericosSolicitacoesid");

                    b.Navigation("nomeUsuarioSolicitacoes");

                    b.Navigation("perifericosSolicitacoes");
                });

            modelBuilder.Entity("ChamadosTI.Models.Modelo.Perifericos", b =>
                {
                    b.Navigation("SolicitacoesPerifericos");
                });

            modelBuilder.Entity("ChamadosTI.Models.Modelo.Usuario", b =>
                {
                    b.Navigation("chamados");

                    b.Navigation("solicitacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
