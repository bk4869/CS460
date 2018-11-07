namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Purchasing.PurchaseOrders")]
    public partial class PurchaseOrders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrders()
        {
            PurchaseOrderLines = new HashSet<PurchaseOrderLines>();
            SupplierTransactions = new HashSet<SupplierTransactions>();
            StockItemTransactions = new HashSet<StockItemTransactions>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseOrderID { get; set; }

        public int SupplierID { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public int DeliveryMethodID { get; set; }

        public int ContactPersonID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpectedDeliveryDate { get; set; }

        [StringLength(20)]
        public string SupplierReference { get; set; }

        public bool IsOrderFinalized { get; set; }

        public string Comments { get; set; }

        public string InternalComments { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastEditedWhen { get; set; }

        public virtual DeliveryMethods DeliveryMethods { get; set; }

        public virtual People People { get; set; }

        public virtual People People1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderLines> PurchaseOrderLines { get; set; }

        public virtual Suppliers Suppliers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierTransactions> SupplierTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItemTransactions> StockItemTransactions { get; set; }
    }
}
