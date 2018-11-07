namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.CustomerTransactions")]
    public partial class CustomerTransactions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerTransactionID { get; set; }

        public int CustomerID { get; set; }

        public int TransactionTypeID { get; set; }

        public int? InvoiceID { get; set; }

        public int? PaymentMethodID { get; set; }

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

        public virtual Customers Customers { get; set; }

        public virtual Invoices Invoices { get; set; }
    }
}
