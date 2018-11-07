namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Purchasing.PurchaseOrderLines")]
    public partial class PurchaseOrderLines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseOrderLineID { get; set; }

        public int PurchaseOrderID { get; set; }

        public int StockItemID { get; set; }

        public int OrderedOuters { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public int ReceivedOuters { get; set; }

        public int PackageTypeID { get; set; }

        public decimal? ExpectedUnitPricePerOuter { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastReceiptDate { get; set; }

        public bool IsOrderLineFinalized { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastEditedWhen { get; set; }

        public virtual People People { get; set; }

        public virtual PackageTypes PackageTypes { get; set; }

        public virtual PurchaseOrders PurchaseOrders { get; set; }

        public virtual StockItems StockItems { get; set; }
    }
}
