﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Relacionamento_1xN.Models;

namespace Relacionamento_1xN.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220929184615_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Relacionamento_1xN.Models.Empregado", b =>
                {
                    b.Property<int>("EmpregadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<int>("TrabalhoId");

                    b.HasKey("EmpregadoId");

                    b.HasIndex("TrabalhoId");

                    b.ToTable("Empregados");
                });

            modelBuilder.Entity("Relacionamento_1xN.Models.Trabalho", b =>
                {
                    b.Property<int>("TrabalhoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("TrabalhoId");

                    b.ToTable("Trabalho");
                });

            modelBuilder.Entity("Relacionamento_1xN.Models.Empregado", b =>
                {
                    b.HasOne("Relacionamento_1xN.Models.Trabalho", "Trabalho")
                        .WithMany("Empregados")
                        .HasForeignKey("TrabalhoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
