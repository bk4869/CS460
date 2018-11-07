namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warehouse.StockItemTransactions")]
    public partial class StockItemTransactions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockItemTransactionID { get; set; }

        public int StockItemID { get; set; }

        public int TransactionTypeID { get; set; }

        public int? CustomerID { get; set; }

        public int? InvoiceID { get; set; }

        public int? SupplierID { get; set; }

        public int? PurchaseOrderID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TransactionOccurredWhen { get; set; }

        public decimal Quantity { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastEditedWhen { get; set; }

        public virtual People People { get; set; }

        public virtual TransactionTypes TransactionTypes { get; set; }

        public virtual PurchaseOrders PurchaseOrders { get; set; }

        public virtual Suppliers Suppliers { get; set; }

        public virtual Customers Customers { get; set; }

        public virtual Invoices Invoices { get; set; }

        public virtual StockItems StockItems { get; set; }
    }
}
