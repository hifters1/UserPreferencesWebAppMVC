﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserPreferencesWebApp.Data;

#nullable disable

namespace UserPreferencesWebApp.Migrations
{
    [DbContext(typeof(UserPreferencesWebAppContext))]
    [Migration("20240422061106_InitialCreateRedo")]
    partial class InitialCreateRedo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UserPreferencesWebApp.Models.Preference", b =>
                {
                    b.Property<int>("PreferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PreferenceId"));

                    b.Property<string>("PreferenceValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PreferenceId");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("UserPreferencesWebApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("PreferenceId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("PreferenceId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UserPreferencesWebApp.Models.User", b =>
                {
                    b.HasOne("UserPreferencesWebApp.Models.Preference", "Preferences")
                        .WithMany("Users")
                        .HasForeignKey("PreferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Preferences");
                });

            modelBuilder.Entity("UserPreferencesWebApp.Models.Preference", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
