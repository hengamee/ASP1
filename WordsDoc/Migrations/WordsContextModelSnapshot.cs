﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WordsDoc.Models;

namespace WordsDoc.Migrations
{
    [DbContext(typeof(WordsContext))]
    partial class WordsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WordsDoc.Models.Words", b =>
                {
                    b.Property<string>("Word")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Word");

                    b.ToTable("Words");
                });
#pragma warning restore 612, 618
        }
    }
}
