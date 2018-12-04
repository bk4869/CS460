namespace hw8.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AuctionHouseContext : DbContext
    {
        public AuctionHouseContext()
            : base("name=AuctionHouseContext2")
        {
        }

        public virtual DbSet<Bid> Bid { get; set; }
        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<BuyerBid> BuyerBid { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<SellerItem> SellerItem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>()
                .HasMany(e => e.BuyerBid)
                .WithRequired(e => e.Buyer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Bid)
                .WithRequired(e => e.Item1)
                .HasForeignKey(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.BuyerBid)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.SellerItem)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seller>()
                .HasMany(e => e.SellerItem)
                .WithRequired(e => e.Seller)
                .WillCascadeOnDelete(false);
        }
    }
}
