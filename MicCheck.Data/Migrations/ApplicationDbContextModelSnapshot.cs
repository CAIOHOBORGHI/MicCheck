﻿// <auto-generated />
using System;
using MicCheck.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicCheck.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MicCheck.Data.Entities.Address", b =>
                {
                    b.Property<Guid>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZIPCode")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Band", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeTown")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicturePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentationAudioPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoClipPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bands");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.BandGenre", b =>
                {
                    b.Property<int>("BandId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("BandId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("BandGenre");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.BandSocialMedia", b =>
                {
                    b.Property<int>("BandId")
                        .HasColumnType("int");

                    b.Property<int>("SocialMediaId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BandId", "SocialMediaId");

                    b.HasIndex("SocialMediaId");

                    b.ToTable("BandSocialMedias");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Fan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeTown")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicturePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fans");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.FanBandRelationship", b =>
                {
                    b.Property<int>("FanBandRelationshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ChoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FanId")
                        .HasColumnType("int");

                    b.Property<bool>("Liked")
                        .HasColumnType("bit");

                    b.HasKey("FanBandRelationshipId");

                    b.HasIndex("FanId");

                    b.HasIndex("BandId", "FanId")
                        .IsUnique();

                    b.ToTable("FanBandRelathionships");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.FanFavoriteGenre", b =>
                {
                    b.Property<int>("FanId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("FanId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("FanFavoriteGenre");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Name = "Rock and roll"
                        },
                        new
                        {
                            GenreId = 2,
                            Name = "Pop"
                        },
                        new
                        {
                            GenreId = 3,
                            Name = "Jazz"
                        });
                });

            modelBuilder.Entity("MicCheck.Data.Entities.MediaType", b =>
                {
                    b.Property<int>("MediaTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediaTypeId");

                    b.ToTable("MediaTypes");

                    b.HasData(
                        new
                        {
                            MediaTypeId = 1,
                            Type = "Image"
                        },
                        new
                        {
                            MediaTypeId = 2,
                            Type = "Video"
                        });
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Post", b =>
                {
                    b.Property<Guid>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("PostId");

                    b.HasIndex("BandId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.PostMedia", b =>
                {
                    b.Property<Guid>("PostMediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MediaPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MediaTypeId")
                        .HasColumnType("int");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostMediaId");

                    b.HasIndex("MediaTypeId");

                    b.HasIndex("PostId");

                    b.ToTable("PostMedias");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.PostReaction", b =>
                {
                    b.Property<int>("FanId")
                        .HasColumnType("int");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ReactionTypeId")
                        .HasColumnType("int");

                    b.Property<Guid>("PostReactionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FanId", "PostId", "ReactionTypeId");

                    b.HasIndex("PostId");

                    b.HasIndex("ReactionTypeId");

                    b.ToTable("PostReactions");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.ReactionType", b =>
                {
                    b.Property<int>("ReactionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmojiCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReactionTypeId");

                    b.ToTable("ReactionTypes");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Reel", b =>
                {
                    b.Property<Guid>("ReelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BandId")
                        .HasColumnType("int");

                    b.Property<int>("FanId")
                        .HasColumnType("int");

                    b.Property<string>("VideoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReelId");

                    b.HasIndex("BandId");

                    b.HasIndex("FanId", "BandId")
                        .IsUnique();

                    b.ToTable("Reels");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.ReelReaction", b =>
                {
                    b.Property<Guid>("ReelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ReactionTypeId")
                        .HasColumnType("int");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReelId", "ReactionTypeId");

                    b.HasIndex("ReactionTypeId");

                    b.ToTable("ReelReactions");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Show", b =>
                {
                    b.Property<Guid>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("VenueId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ShowId");

                    b.HasIndex("BandId");

                    b.HasIndex("VenueId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.SocialMedia", b =>
                {
                    b.Property<int>("SocialMediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialMediaId");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Venue", b =>
                {
                    b.Property<Guid>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("VenueId");

                    b.HasIndex("AddressId");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FriendlyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Xml")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKeys");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.BandGenre", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.Band", "Band")
                        .WithMany("GenreTags")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicCheck.Data.Entities.Genre", "Genre")
                        .WithMany("BandGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.BandSocialMedia", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.Band", "Band")
                        .WithMany("SocialMedias")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicCheck.Data.Entities.SocialMedia", "SocialMedia")
                        .WithMany("BandSocialMedias")
                        .HasForeignKey("SocialMediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");

                    b.Navigation("SocialMedia");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.FanBandRelationship", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.Band", "Band")
                        .WithMany("FansRelationships")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicCheck.Data.Entities.Fan", "Fan")
                        .WithMany("BandsRelationships")
                        .HasForeignKey("FanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");

                    b.Navigation("Fan");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.FanFavoriteGenre", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.Fan", "Fan")
                        .WithMany("FavoriteGenres")
                        .HasForeignKey("FanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicCheck.Data.Entities.Genre", "Genre")
                        .WithMany("FanFavoriteGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fan");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Post", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.Band", "Band")
                        .WithMany("Posts")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.PostMedia", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.MediaType", "MediaType")
                        .WithMany("PostMedias")
                        .HasForeignKey("MediaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicCheck.Data.Entities.Post", "Post")
                        .WithMany("PostMedias")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MediaType");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.PostReaction", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.Fan", "Fan")
                        .WithMany("PostReactions")
                        .HasForeignKey("FanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicCheck.Data.Entities.Post", "Post")
                        .WithMany("PostReactions")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicCheck.Data.Entities.ReactionType", "ReactionType")
                        .WithMany("PostsReactions")
                        .HasForeignKey("ReactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fan");

                    b.Navigation("Post");

                    b.Navigation("ReactionType");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Reel", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.Band", "Band")
                        .WithMany("FansReels")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicCheck.Data.Entities.Fan", "Fan")
                        .WithMany("Reels")
                        .HasForeignKey("FanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");

                    b.Navigation("Fan");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.ReelReaction", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.ReactionType", "ReactionType")
                        .WithMany("ReelsReactions")
                        .HasForeignKey("ReactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicCheck.Data.Entities.Reel", "Reel")
                        .WithMany("Reactions")
                        .HasForeignKey("ReelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReactionType");

                    b.Navigation("Reel");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Show", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.Band", "Band")
                        .WithMany("Shows")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicCheck.Data.Entities.Venue", "Venue")
                        .WithMany("Shows")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Venue", b =>
                {
                    b.HasOne("MicCheck.Data.Entities.Address", "Address")
                        .WithMany("Venues")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Address", b =>
                {
                    b.Navigation("Venues");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Band", b =>
                {
                    b.Navigation("FansReels");

                    b.Navigation("FansRelationships");

                    b.Navigation("GenreTags");

                    b.Navigation("Posts");

                    b.Navigation("Shows");

                    b.Navigation("SocialMedias");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Fan", b =>
                {
                    b.Navigation("BandsRelationships");

                    b.Navigation("FavoriteGenres");

                    b.Navigation("PostReactions");

                    b.Navigation("Reels");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Genre", b =>
                {
                    b.Navigation("BandGenres");

                    b.Navigation("FanFavoriteGenres");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.MediaType", b =>
                {
                    b.Navigation("PostMedias");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Post", b =>
                {
                    b.Navigation("PostMedias");

                    b.Navigation("PostReactions");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.ReactionType", b =>
                {
                    b.Navigation("PostsReactions");

                    b.Navigation("ReelsReactions");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Reel", b =>
                {
                    b.Navigation("Reactions");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.SocialMedia", b =>
                {
                    b.Navigation("BandSocialMedias");
                });

            modelBuilder.Entity("MicCheck.Data.Entities.Venue", b =>
                {
                    b.Navigation("Shows");
                });
#pragma warning restore 612, 618
        }
    }
}
