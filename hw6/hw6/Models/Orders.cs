namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.Orders")]
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            Invoices = new HashSet<Invoices>();
            OrderLines = new HashSet<OrderLines>();
            Orders1 = new HashSet<Orders>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int SalespersonPersonID { get; set; }

        public int? PickedByPersonID { get; set; }

        public int ContactPersonID { get; set; }

        public int? BackorderOrderID { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpectedDeliveryDate { get; set; }

        [StringLength(20)]
        public string CustomerPurchaseOrderNumber { get; set; }

        public bool IsUndersupplyBackordered { get; set; }

        public string Comments { get; set; }

        public string DeliveryInstructions { get; set; }

        public string InternalComments { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PickingCompletedWhen { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastEditedWhen { get; set; }

        public virtual People People { get; set; }

        public virtual People People1 { get; set; }

        public virtual People People2 { get; set; }

        public virtual People People3 { get; set; }

        public virtual Customers Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLines> OrderLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders1 { get; set; }

        public virtual Orders Orders2 { get; set; }
    }
}
