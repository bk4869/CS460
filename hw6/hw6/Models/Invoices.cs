namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.Invoices")]
    public partial class Invoices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoices()
        {
            CustomerTransactions = new HashSet<CustomerTransactions>();
            InvoiceLines = new HashSet<InvoiceLines>();
            StockItemTransactions = new HashSet<StockItemTransactions>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        public int CustomerID { get; set; }

        public int BillToCustomerID { get; set; }

        public int? OrderID { get; set; }

        public int DeliveryMethodID { get; set; }

        public int ContactPersonID { get; set; }

        public int AccountsPersonID { get; set; }

        public int SalespersonPersonID { get; set; }

        public int PackedByPersonID { get; set; }

        [Column(TypeName = "date")]
        public DateTime InvoiceDate { get; set; }

        [StringLength(20)]
        public string CustomerPurchaseOrderNumber { get; set; }

        public bool IsCreditNote { get; set; }

        public string CreditNoteReason { get; set; }

        public string Comments { get; set; }

        public string DeliveryInstructions { get; set; }

        public string InternalComments { get; set; }

        public int TotalDryItems { get; set; }

        public int TotalChillerItems { get; set; }

        [StringLength(5)]
        public string DeliveryRun { get; set; }

        [StringLength(5)]
        public string RunPosition { get; set; }

        public string ReturnedDeliveryData { get; set; }

        [Column(TypeName = "datetime2")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? ConfirmedDeliveryTime { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(4000)]
        public string ConfirmedReceivedBy { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastEditedWhen { get; set; }

        public virtual DeliveryMethods DeliveryMethods { get; set; }

        public virtual People People { get; set; }

        public virtual People People1 { get; set; }

        public virtual People People2 { get; set; }

        public virtual People People3 { get; set; }

        public virtual People People4 { get; set; }

        public virtual Customers Customers { get; set; }

        public virtual Customers Customers1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerTransactions> CustomerTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceLines> InvoiceLines { get; set; }

        public virtual Orders Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItemTransactions> StockItemTransactions { get; set; }
    }
}
