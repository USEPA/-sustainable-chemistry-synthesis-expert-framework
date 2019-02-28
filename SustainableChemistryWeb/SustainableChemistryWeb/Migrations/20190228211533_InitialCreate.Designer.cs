﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SustainableChemistryWeb.Models;

namespace SustainableChemistryWeb.Migrations
{
    [DbContext(typeof(SustainableChemistryContext))]
    [Migration("20190228211533_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("SustainableChemistryWeb.Models.Catalyst", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("app_catalyst");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.Compound", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("CasNumber")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("app_compound");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.FunctionalGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Smarts")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Smarts")
                        .IsUnique();

                    b.ToTable("app_functionalgroup");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.NamedReaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("AcidBase")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<long>("CatalystId")
                        .HasColumnName("Catalyst_id");

                    b.Property<long>("FunctionalGroupId")
                        .HasColumnName("Functional_Group_id");

                    b.Property<string>("Heat")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ReactantA")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ReactantB")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ReactantC")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<long>("SolventId")
                        .HasColumnName("Solvent_id");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("URL")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CatalystId")
                        .HasName("app_namedreaction_Catalyst_id_63600e1e");

                    b.HasIndex("FunctionalGroupId")
                        .HasName("app_namedreaction_Functional_Group_id_057af1bd");

                    b.HasIndex("SolventId")
                        .HasName("app_namedreaction_Solvent_id_7ec52782");

                    b.HasIndex("FunctionalGroupId", "Name")
                        .IsUnique()
                        .HasName("app_namedreaction_Functional_Group_id_Name_5a5a6724_uniq");

                    b.ToTable("app_namedreaction");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.NamedReactionByProducts", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("NamedreactionId")
                        .HasColumnName("namedreaction_id");

                    b.Property<long>("ReactantId")
                        .HasColumnName("reactant_id");

                    b.HasKey("Id");

                    b.HasIndex("NamedreactionId")
                        .HasName("app_namedreaction_ByProducts_namedreaction_id_a2dc2fd2");

                    b.HasIndex("ReactantId")
                        .HasName("app_namedreaction_ByProducts_reactant_id_fc608f72");

                    b.HasIndex("NamedreactionId", "ReactantId")
                        .IsUnique()
                        .HasName("app_namedreaction_ByProducts_namedreaction_id_reactant_id_0784f477_uniq");

                    b.ToTable("app_namedreaction_ByProducts");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.NamedReactionReactants", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("NamedreactionId")
                        .HasColumnName("namedreaction_id");

                    b.Property<long>("ReactantId")
                        .HasColumnName("reactant_id");

                    b.HasKey("Id");

                    b.HasIndex("NamedreactionId")
                        .HasName("app_namedreaction_Reactants_namedreaction_id_b07b57ce");

                    b.HasIndex("ReactantId")
                        .HasName("app_namedreaction_Reactants_reactant_id_5118ff6c");

                    b.HasIndex("NamedreactionId", "ReactantId")
                        .IsUnique()
                        .HasName("app_namedreaction_Reactants_namedreaction_id_reactant_id_a9ecf412_uniq");

                    b.ToTable("app_namedreaction_Reactants");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.Reactant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Temp2")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("app_reactant");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.Reference", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long?>("FunctionalGroupId")
                        .HasColumnName("Functional_Group_id");

                    b.Property<long?>("ReactionId")
                        .HasColumnName("Reaction_id");

                    b.Property<string>("Risdata")
                        .IsRequired()
                        .HasColumnName("RISData");

                    b.HasKey("Id");

                    b.HasIndex("FunctionalGroupId")
                        .HasName("app_reference_Functional_Group_id_b8927bac");

                    b.HasIndex("ReactionId")
                        .HasName("app_reference_Reaction_id_bf824395");

                    b.ToTable("app_reference");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.Solvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("app_solvent");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.NamedReaction", b =>
                {
                    b.HasOne("SustainableChemistryWeb.Models.Catalyst", "Catalyst")
                        .WithMany("AppNamedreaction")
                        .HasForeignKey("CatalystId");

                    b.HasOne("SustainableChemistryWeb.Models.FunctionalGroup", "FunctionalGroup")
                        .WithMany("AppNamedreaction")
                        .HasForeignKey("FunctionalGroupId");

                    b.HasOne("SustainableChemistryWeb.Models.Solvent", "Solvent")
                        .WithMany("AppNamedreaction")
                        .HasForeignKey("SolventId");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.NamedReactionByProducts", b =>
                {
                    b.HasOne("SustainableChemistryWeb.Models.NamedReaction", "Namedreaction")
                        .WithMany("AppNamedreactionByProducts")
                        .HasForeignKey("NamedreactionId");

                    b.HasOne("SustainableChemistryWeb.Models.Reactant", "Reactant")
                        .WithMany("AppNamedreactionByProducts")
                        .HasForeignKey("ReactantId");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.NamedReactionReactants", b =>
                {
                    b.HasOne("SustainableChemistryWeb.Models.NamedReaction", "Namedreaction")
                        .WithMany("AppNamedreactionReactants")
                        .HasForeignKey("NamedreactionId");

                    b.HasOne("SustainableChemistryWeb.Models.Reactant", "Reactant")
                        .WithMany("AppNamedreactionReactants")
                        .HasForeignKey("ReactantId");
                });

            modelBuilder.Entity("SustainableChemistryWeb.Models.Reference", b =>
                {
                    b.HasOne("SustainableChemistryWeb.Models.FunctionalGroup", "FunctionalGroup")
                        .WithMany("AppReference")
                        .HasForeignKey("FunctionalGroupId");

                    b.HasOne("SustainableChemistryWeb.Models.NamedReaction", "Reaction")
                        .WithMany("AppReference")
                        .HasForeignKey("ReactionId");
                });
#pragma warning restore 612, 618
        }
    }
}
