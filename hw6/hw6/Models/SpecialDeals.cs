namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.SpecialDeals")]
    public partial class SpecialDeals
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecialDealID { get; set; }

        public int? StockItemID { get; set; }

        public int? CustomerID { get; set; }

        public int? BuyingGroupID { get; set; }

        public int? CustomerCategoryID { get; set; }

        public int? StockGroupID { get; set; }

        [Required]
        [StringLength(30)]
        public string DealDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? DiscountPercentage { get; set; }

        public decimal? UnitPrice { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastEditedWhen { get; set; }

        public virtual People People { get; set; }

        public virtual BuyingGroups BuyingGroups { get; set; }

        public virtual CustomerCategories CustomerCategories { get; set; }

        public virtual Customers Customers { get; set; }

        public virtual StockGroups StockGroups { get; set; }

        public virtual StockItems StockItems { get; set; }
    }
}
