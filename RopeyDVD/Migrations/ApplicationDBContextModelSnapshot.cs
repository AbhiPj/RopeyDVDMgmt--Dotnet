﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RopeyDVD.Data;

#nullable disable

namespace RopeyDVD.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RopeyDVD.Models.Actor", b =>
                {
                    b.Property<int>("ActorNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorNumber"), 1L, 1);

                    b.Property<int>("ActorFirstName")
                        .HasColumnType("int");

                    b.Property<string>("ActorSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorNumber");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("RopeyDVD.Models.CastMember", b =>
                {
                    b.Property<int>("DVDNumber")
                        .HasColumnType("int");

                    b.Property<int>("ActorNumber")
                        .HasColumnType("int");

                    b.HasKey("DVDNumber", "ActorNumber");

                    b.HasIndex("ActorNumber");

                    b.ToTable("CastMember");
                });

            modelBuilder.Entity("RopeyDVD.Models.DVDCategory", b =>
                {
                    b.Property<int>("CategoryNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryNumber"), 1L, 1);

                    b.Property<string>("AgeRestricted")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategotyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryNumber");

                    b.ToTable("DVDCategory");
                });

            modelBuilder.Entity("RopeyDVD.Models.DVDCopy", b =>
                {
                    b.Property<int>("CopyNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CopyNumber"), 1L, 1);

                    b.Property<int>("DVDNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime2");

                    b.HasKey("CopyNumber");

                    b.HasIndex("DVDNumber");

                    b.ToTable("DVDCopy");
                });

            modelBuilder.Entity("RopeyDVD.Models.DVDTitle", b =>
                {
                    b.Property<int>("DVDNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DVDNumber"), 1L, 1);

                    b.Property<int>("CategoryNumber")
                        .HasColumnType("int");

                    b.Property<int>("DVDCategoryCategoryNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReleased")
                        .HasColumnType("datetime2");

                    b.Property<int>("PenaltyCharge")
                        .HasColumnType("int");

                    b.Property<int>("ProducerNumber")
                        .HasColumnType("int");

                    b.Property<int>("StandardCharge")
                        .HasColumnType("int");

                    b.Property<int>("StudioNumber")
                        .HasColumnType("int");

                    b.HasKey("DVDNumber");

                    b.HasIndex("DVDCategoryCategoryNumber");

                    b.HasIndex("ProducerNumber");

                    b.HasIndex("StudioNumber");

                    b.ToTable("DVDTitle");
                });

            modelBuilder.Entity("RopeyDVD.Models.Loan", b =>
                {
                    b.Property<int>("LoanNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanNumber"), 1L, 1);

                    b.Property<int>("CopyNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateReturned")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoanTypeNumber")
                        .HasColumnType("int");

                    b.Property<int>("MemberNumber")
                        .HasColumnType("int");

                    b.HasKey("LoanNumber");

                    b.HasIndex("CopyNumber");

                    b.HasIndex("LoanTypeNumber");

                    b.HasIndex("MemberNumber");

                    b.ToTable("Loan");
                });

            modelBuilder.Entity("RopeyDVD.Models.LoanType", b =>
                {
                    b.Property<int>("LoanTypeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanTypeNumber"), 1L, 1);

                    b.Property<string>("LoanDuration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("loanType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoanTypeNumber");

                    b.ToTable("LoanTypes");
                });

            modelBuilder.Entity("RopeyDVD.Models.Member", b =>
                {
                    b.Property<int>("MembershipNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MembershipNumber"), 1L, 1);

                    b.Property<DateTime>("MemberDOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("MembershipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MembershipCategoryNumber")
                        .HasColumnType("int");

                    b.Property<string>("MembershipFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MembershipLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MembershipNumber");

                    b.HasIndex("MembershipCategoryNumber");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("RopeyDVD.Models.MembershipCategory", b =>
                {
                    b.Property<int>("MembershipCategoryNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MembershipCategoryNumber"), 1L, 1);

                    b.Property<string>("MembershipCategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MembershipCategoryTotalLoans")
                        .HasColumnType("int");

                    b.HasKey("MembershipCategoryNumber");

                    b.ToTable("MembershipCategories");
                });

            modelBuilder.Entity("RopeyDVD.Models.Producer", b =>
                {
                    b.Property<int>("ProducerNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProducerNumber"), 1L, 1);

                    b.Property<string>("ProducerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProducerNumber");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("RopeyDVD.Models.Studio", b =>
                {
                    b.Property<int>("StudioNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudioNumber"), 1L, 1);

                    b.Property<string>("StudioName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudioNumber");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("RopeyDVD.Models.User", b =>
                {
                    b.Property<int>("UserNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserNumber"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("UserNumber");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RopeyDVD.Models.CastMember", b =>
                {
                    b.HasOne("RopeyDVD.Models.Actor", "Actor")
                        .WithMany("CastMember")
                        .HasForeignKey("ActorNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RopeyDVD.Models.DVDTitle", "DVDTitle")
                        .WithMany("CastMember")
                        .HasForeignKey("DVDNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("DVDTitle");
                });

            modelBuilder.Entity("RopeyDVD.Models.DVDCopy", b =>
                {
                    b.HasOne("RopeyDVD.Models.DVDTitle", "DVDTitle")
                        .WithMany("DVDCopy")
                        .HasForeignKey("DVDNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DVDTitle");
                });

            modelBuilder.Entity("RopeyDVD.Models.DVDTitle", b =>
                {
                    b.HasOne("RopeyDVD.Models.DVDCategory", "DVDCategory")
                        .WithMany("DVDTitle")
                        .HasForeignKey("DVDCategoryCategoryNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RopeyDVD.Models.Producer", "Producer")
                        .WithMany("DVDTitle")
                        .HasForeignKey("ProducerNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RopeyDVD.Models.Studio", "Studio")
                        .WithMany("DVDTitle")
                        .HasForeignKey("StudioNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DVDCategory");

                    b.Navigation("Producer");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("RopeyDVD.Models.Loan", b =>
                {
                    b.HasOne("RopeyDVD.Models.DVDCopy", "DVDCopy")
                        .WithMany("Loan")
                        .HasForeignKey("CopyNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RopeyDVD.Models.LoanType", "LoanType")
                        .WithMany("Loan")
                        .HasForeignKey("LoanTypeNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RopeyDVD.Models.Member", "Member")
                        .WithMany("Loan")
                        .HasForeignKey("MemberNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DVDCopy");

                    b.Navigation("LoanType");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("RopeyDVD.Models.Member", b =>
                {
                    b.HasOne("RopeyDVD.Models.MembershipCategory", "MembershipCategory")
                        .WithMany("Member")
                        .HasForeignKey("MembershipCategoryNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipCategory");
                });

            modelBuilder.Entity("RopeyDVD.Models.Actor", b =>
                {
                    b.Navigation("CastMember");
                });

            modelBuilder.Entity("RopeyDVD.Models.DVDCategory", b =>
                {
                    b.Navigation("DVDTitle");
                });

            modelBuilder.Entity("RopeyDVD.Models.DVDCopy", b =>
                {
                    b.Navigation("Loan");
                });

            modelBuilder.Entity("RopeyDVD.Models.DVDTitle", b =>
                {
                    b.Navigation("CastMember");

                    b.Navigation("DVDCopy");
                });

            modelBuilder.Entity("RopeyDVD.Models.LoanType", b =>
                {
                    b.Navigation("Loan");
                });

            modelBuilder.Entity("RopeyDVD.Models.Member", b =>
                {
                    b.Navigation("Loan");
                });

            modelBuilder.Entity("RopeyDVD.Models.MembershipCategory", b =>
                {
                    b.Navigation("Member");
                });

            modelBuilder.Entity("RopeyDVD.Models.Producer", b =>
                {
                    b.Navigation("DVDTitle");
                });

            modelBuilder.Entity("RopeyDVD.Models.Studio", b =>
                {
                    b.Navigation("DVDTitle");
                });
#pragma warning restore 612, 618
        }
    }
}
