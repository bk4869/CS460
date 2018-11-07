namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Purchasing.SupplierTransactions")]
    public partial class SupplierTransactions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierTransactionID { get; set; }

        public int SupplierID { get; set; }

        public int TransactionTypeID { get; set; }

        public int? PurchaseOrderID { get; set; }

        public int? PaymentMethodID { get; set; }

        [StringLength(20)]
        public string SupplierInvoiceNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime TransactionDate { get; set; }

        public decimal AmountExcludingTax { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TransactionAmount { get; set; }

        public decimal OutstandingBalance { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FinalizationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsFinalized { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastEditedWhen { get; set; }

        public virtual PaymentMethods PaymentMethods { get; set; }

        public virtual People People { get; set; }

        public virtual TransactionTypes TransactionTypes { get; set; }

        public virtual PurchaseOrders PurchaseOrders { get; set; }

        public virtual Suppliers Suppliers { get; set; }
    }
}
