﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Relacionamento_1x1.Models;

namespace Relacionamento_1x1.Migrations
{
    [DbContext(typeof(PessoaContexto))]
    [Migration("20220929175622_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Relacionamento_1x1.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<int>("Numero");

                    b.Property<string>("Rua");

                    b.HasKey("EnderecoId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Relacionamento_1x1.Models.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EnderecoId");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.HasKey("PessoaId");

                    b.HasIndex("EnderecoId")
                        .IsUnique()
                        .HasFilter("[EnderecoId] IS NOT NULL");

                    b.ToTable("pessoas");
                });

            modelBuilder.Entity("Relacionamento_1x1.Models.Pessoa", b =>
                {
                    b.HasOne("Relacionamento_1x1.Models.Endereco", "Endereco")
                        .WithOne("Pessoa")
                        .HasForeignKey("Relacionamento_1x1.Models.Pessoa", "EnderecoId");
                });
#pragma warning restore 612, 618
        }
    }
}