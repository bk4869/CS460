namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.InvoiceLines")]
    public partial class InvoiceLines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceLineID { get; set; }

        public int InvoiceID { get; set; }

        public int StockItemID { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public int PackageTypeID { get; set; }

        public int Quantity { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal TaxRate { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal LineProfit { get; set; }

        public decimal ExtendedPrice { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastEditedWhen { get; set; }

        public virtual People People { get; set; }

        public virtual Invoices Invoices { get; set; }

        public virtual PackageTypes PackageTypes { get; set; }

        public virtual StockItems StockItems { get; set; }
    }
}
