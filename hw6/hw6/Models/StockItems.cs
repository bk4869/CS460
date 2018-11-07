namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warehouse.StockItems")]
    public partial class StockItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockItems()
        {
            PurchaseOrderLines = new HashSet<PurchaseOrderLines>();
            InvoiceLines = new HashSet<InvoiceLines>();
            OrderLines = new HashSet<OrderLines>();
            SpecialDeals = new HashSet<SpecialDeals>();
            StockItemStockGroups = new HashSet<StockItemStockGroups>();
            StockItemTransactions = new HashSet<StockItemTransactions>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockItemID { get; set; }

        [Required]
        [StringLength(100)]
        public string StockItemName { get; set; }

        public int SupplierID { get; set; }

        public int? ColorID { get; set; }

        public int UnitPackageID { get; set; }

        public int OuterPackageID { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [StringLength(20)]
        public string Size { get; set; }

        public int LeadTimeDays { get; set; }

        public int QuantityPerOuter { get; set; }

        public bool IsChillerStock { get; set; }

        [StringLength(50)]
        public string Barcode { get; set; }

        public decimal TaxRate { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal? RecommendedRetailPrice { get; set; }

        public decimal TypicalWeightPerUnit { get; set; }

        public string MarketingComments { get; set; }

        public string InternalComments { get; set; }

        public byte[] Photo { get; set; }

        public string CustomFields { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string Tags { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        public string SearchDetails { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ValidFrom { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ValidTo { get; set; }

        public virtual People People { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderLines> PurchaseOrderLines { get; set; }

        public virtual Suppliers Suppliers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceLines> InvoiceLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLines> OrderLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialDeals> SpecialDeals { get; set; }

        public virtual Colors Colors { get; set; }

        public virtual PackageTypes PackageTypes { get; set; }

        public virtual PackageTypes PackageTypes1 { get; set; }

        public virtual StockItemHoldings StockItemHoldings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItemStockGroups> StockItemStockGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItemTransactions> StockItemTransactions { get; set; }
    }
}
