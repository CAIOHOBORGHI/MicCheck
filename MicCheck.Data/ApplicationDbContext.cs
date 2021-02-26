using System;
using MicCheck.Data.Entities;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MicCheck.Data
{
    public class ApplicationDbContext : DbContext    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Creates initial tables in database
            //Database.Migrate();
        }

        public DbSet<DataProtectionKey> DataProtectionKeys { get; set; }

        #region Entities
        public DbSet<Address> Addresses { get; set; }
        
        public DbSet<Band> Bands { get; set; }
        public DbSet<BandSocialMedia> BandSocialMedias { get; set; }
        
        public DbSet<Fan> Fans { get; set; }
        public DbSet<FanBandRelationship> FanBandRelathionships { get; set; }

        public DbSet<Genre> Genres { get; set; }
        
        public DbSet<MediaType> MediaTypes { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<PostMedia> PostMedias { get; set; }
        public DbSet<PostReaction> PostReactions { get; set; }

        public DbSet<ReactionType> ReactionTypes { get; set; }
        public DbSet<Reel> Reels { get; set; }
        public DbSet<ReelReaction> ReelReactions { get; set; }

        public DbSet<Show> Shows { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Venue> Venues { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {

            #region Relationships
            // User
            //builder.Entity<User>()
            //    .HasMany<Band>(u => u.Bands)
            //    .WithOne(b => b.User)
            //    .HasForeignKey(b => b.UserId);

            //builder.Entity<User>()
            //    .HasMany<Fan>(u => u.Fans)
            //    .WithOne(f => f.User)
            //    .HasForeignKey(f => f.UserId);

            // Band Social Medias
            builder.Entity<BandSocialMedia>()
                .HasKey(bsm => new { bsm.BandId, bsm.SocialMediaId });

            builder.Entity<BandSocialMedia>()
                .HasOne<Band>(bsm => bsm.Band)
                .WithMany(b => b.SocialMedias)
                .HasForeignKey(bsm => bsm.BandId);

            builder.Entity<BandSocialMedia>()
                .HasOne<SocialMedia>(bsm => bsm.SocialMedia)
                .WithMany(sm => sm.BandSocialMedias)
                .HasForeignKey(bsm => bsm.SocialMediaId);

            // Fan Band Relationships
            builder.Entity<FanBandRelationship>()
                .HasIndex(fb => new { fb.BandId, fb.FanId })
                .IsUnique();

            builder.Entity<FanBandRelationship>()
                .HasOne<Band>(fbr => fbr.Band)
                .WithMany(b => b.FansRelationships)
                .HasForeignKey(fbr => fbr.BandId);

            builder.Entity<FanBandRelationship>()
                .HasOne<Fan>(fbr => fbr.Fan)
                .WithMany(f => f.BandsRelationships)
                .HasForeignKey(fbr => fbr.FanId);

            // Band Genres
            builder.Entity<BandGenre>()
                .HasKey(bg => new { bg.BandId, bg.GenreId });

            builder.Entity<BandGenre>()
                .HasOne<Band>(bg => bg.Band)
                .WithMany(b => b.GenreTags)
                .HasForeignKey(bg => bg.BandId);

            builder.Entity<BandGenre>()
                .HasOne<Genre>(bg => bg.Genre)
                .WithMany(g => g.BandGenres)
                .HasForeignKey(bg => bg.GenreId);

            // Band Posts
            builder.Entity<Post>()
                .HasOne<Band>(p => p.Band)
                .WithMany(b => b.Posts)
                .HasForeignKey(p => p.BandId);

            // Fan Favorite Genres
            builder.Entity<FanFavoriteGenre>()
                .HasKey(ffg => new { ffg.FanId, ffg.GenreId });

            builder.Entity<FanFavoriteGenre>()
                .HasOne<Fan>(ffg => ffg.Fan)
                .WithMany(f => f.FavoriteGenres)
                .HasForeignKey(ffg => ffg.FanId);

            builder.Entity<FanFavoriteGenre>()
                .HasOne<Genre>(ffg => ffg.Genre)
                .WithMany(g => g.FanFavoriteGenres)
                .HasForeignKey(ffg => ffg.GenreId);

            // Reels
            builder.Entity<Reel>()
                .HasIndex(r => new { r.FanId, r.BandId })
                .IsUnique();

            builder.Entity<Reel>()
                .HasOne<Fan>(r => r.Fan)
                .WithMany(f => f.Reels)
                .HasForeignKey(r => r.FanId);

            builder.Entity<Reel>()
                .HasOne<Band>(r => r.Band)
                .WithMany(g => g.FansReels)
                .HasForeignKey(r => r.BandId);

            // Reels Reactions
            builder.Entity<ReelReaction>()
                .HasKey(rr => new { rr.ReelId, rr.ReactionTypeId });

            builder.Entity<ReelReaction>()
                .HasOne<Reel>(rr => rr.Reel)
                .WithMany(r => r.Reactions)
                .HasForeignKey(rr => rr.ReelId);

            builder.Entity<ReelReaction>()
               .HasOne<ReactionType>(rt => rt.ReactionType)
               .WithMany(r => r.ReelsReactions)
               .HasForeignKey(rt => rt.ReactionTypeId);

            // Post Reactions
            builder.Entity<PostReaction>()
                .HasKey(pr => new { pr.FanId, pr.PostId, pr.ReactionTypeId });

            builder.Entity<PostReaction>()
                .HasOne<Fan>(pr => pr.Fan)
                .WithMany(f => f.PostReactions)
                .HasForeignKey(pr => pr.FanId);

            builder.Entity<PostReaction>()
                .HasOne<Post>(pr => pr.Post)
                .WithMany(p => p.PostReactions)
                .HasForeignKey(pr => pr.PostId);

            builder.Entity<PostReaction>()
               .HasOne<ReactionType>(pr => pr.ReactionType)
               .WithMany(rt => rt.PostsReactions)
               .HasForeignKey(pr => pr.ReactionTypeId);


            // Post Medias
            builder.Entity<PostMedia>()
                .HasOne<Post>(pm => pm.Post)
                .WithMany(p => p.PostMedias)
                .HasForeignKey(pm => pm.PostId);

            builder.Entity<PostMedia>()
                .HasOne<MediaType>(pm => pm.MediaType)
                .WithMany(m => m.PostMedias)
                .HasForeignKey(pm => pm.MediaTypeId);

            // Shows
            builder.Entity<Show>()
                .HasOne<Band>(s => s.Band)
                .WithMany(b => b.Shows)
                .HasForeignKey(s => s.BandId);

            builder.Entity<Show>()
                .HasOne<Venue>(s => s.Venue)
                .WithMany(v => v.Shows)
                .HasForeignKey(s => s.VenueId);

            // Venues
            builder.Entity<Venue>()
                .HasOne<Address>(v => v.Address)
                .WithMany(a => a.Venues)
                .HasForeignKey(v => v.AddressId);


            #endregion

            #region Seed
            // Music genres
            builder.Entity<Genre>().HasData(
                    new[]
                    {
                        new Genre { GenreId = 1, Name = "Rock and roll"  },
                        new Genre { GenreId = 2, Name = "Pop"},
                        new Genre { GenreId = 3, Name = "Jazz"},
                    }
                );

            // Media types
            builder.Entity<MediaType>().HasData
                (
                    new[]
                    {
                        new MediaType{ MediaTypeId = 1, Type = "Image" },
                        new MediaType{ MediaTypeId = 2, Type = "Video"},
                    }
                );

            #endregion

            base.OnModelCreating(builder);
        }
    }
}
