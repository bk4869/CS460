namespace hw8.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AuctionHouseContext : DbContext
    {
        public AuctionHouseContext()
            : base("name=AuctionHouseContext")
        {
        }

        public virtual DbSet<Bid> Bid { get; set; }
        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>()
                .HasMany(e => e.Bid1)
                .WithRequired(e => e.Buyer1)
                .HasForeignKey(e => e.Buyer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Bid)
                .WithRequired(e => e.Item1)
                .HasForeignKey(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seller>()
                .HasMany(e => e.Item)
                .WithRequired(e => e.Seller1)
                .HasForeignKey(e => e.Seller)
                .WillCascadeOnDelete(false);
        }
    }
}
