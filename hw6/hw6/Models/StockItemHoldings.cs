namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warehouse.StockItemHoldings")]
    public partial class StockItemHoldings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockItemID { get; set; }

        public int QuantityOnHand { get; set; }

        [Required]
        [StringLength(20)]
        public string BinLocation { get; set; }

        public int LastStocktakeQuantity { get; set; }

        public decimal LastCostPrice { get; set; }

        public int ReorderLevel { get; set; }

        public int TargetStockLevel { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastEditedWhen { get; set; }

        public virtual People People { get; set; }

        public virtual StockItems StockItems { get; set; }
    }
}
