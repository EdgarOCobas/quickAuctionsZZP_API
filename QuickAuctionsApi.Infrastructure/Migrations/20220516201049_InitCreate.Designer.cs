﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickAuctionsApi.Infrastructure.Database;

#nullable disable

namespace QuickAuctionsApi.Infrastructure.Migrations
{
    [DbContext(typeof(QuickAuctionsContext))]
    [Migration("20220516201049_InitCreate")]
    partial class InitCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("QuickAuctionsApi.Domain.Entity.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CreatorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CurrentPrice")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CurrentWinnerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinimumBid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("StartingPrice")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("QuickAuctionsApi.Domain.Entity.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemConditionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemCategoryId");

                    b.HasIndex("ItemConditionId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("QuickAuctionsApi.Domain.Entity.ItemCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("QuickAuctionsApi.Domain.Entity.ItemCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("QuickAuctionsApi.Domain.Entity.Auction", b =>
                {
                    b.HasOne("QuickAuctionsApi.Domain.Entity.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("QuickAuctionsApi.Domain.Entity.Item", b =>
                {
                    b.HasOne("QuickAuctionsApi.Domain.Entity.ItemCategory", "ItemCategory")
                        .WithMany()
                        .HasForeignKey("ItemCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickAuctionsApi.Domain.Entity.ItemCondition", "ItemCondition")
                        .WithMany()
                        .HasForeignKey("ItemConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemCategory");

                    b.Navigation("ItemCondition");
                });
#pragma warning restore 612, 618
        }
    }
}
