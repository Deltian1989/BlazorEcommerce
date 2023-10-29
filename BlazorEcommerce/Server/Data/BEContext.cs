﻿using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data
{
    public class BEContext : DbContext
    {
        public BEContext(DbContextOptions<BEContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id=1,
                    Title = "Pirates of the Caribbean: Dead Men Tell No Tales (DVD/Blu-ray)",
                    Description = "Captain Jack Sparrow (Johnny Depp) sets sail for a fifth effects-filled swashbuckler, now on a quest for the Trident of Poseidon and the ultimate power it can bestow. However, he'll have to outrace young Henry Turner (Brenton Thwaites), who's looking to free father Will (Orlando Bloom) from the Flying Dutchman's curse... and outpace the vengeance hunt of the undead Captain Salazar (Javier Bardem). Geoffrey Rush, Kaya Scodelario, and Keira Knightley co-star.",
                    ImageUrl = "https://m.media-amazon.com/images/I/81aLSDXBZqL._AC_SY606_.jpg",
                    Price = 39.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Heroes of Might & Magic III Complete (PC CD-ROM)",
                    Description = "This is a must have for every Might and Magic series fan! Includes Heroes of Might & Magic III and its expansions: Armageddon's Blade and The Shadow of Death. Insanely addictive gameplay that will make you want to play “just one more turn” over and over again great multiplayer, especially when playing in hot seat mode on one PC",
                    ImageUrl = "https://i.ebayimg.com/images/g/0pcAAOSw3~diWWLL/s-l1600.jpg",
                    Price = 35m
                },
                new Product
                {
                    Id = 3,
                    Title = "ORIGINAL Nintendo Entertainment System Video Game Bundle Set Kit NES Console OG",
                    Description = "This is the original vintage gaming system from the 1980's. It comes with brand new accessories, which makes you feel like you are playing it for the first time again! Please note that this is NOT the \"Classic\" edition that has pre-loaded games, you will have to use old school game cartridges in this system (not included) like its 1989.",
                    ImageUrl = "https://i.ebayimg.com/images/g/AD4AAOSw3YphYRwA/s-l1600.jpg",
                    Price = 170m
                }
            );
        }
    }
}