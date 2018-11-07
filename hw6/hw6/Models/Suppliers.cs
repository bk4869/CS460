namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Purchasing.Suppliers")]
    public partial class Suppliers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Suppliers()
        {
            PurchaseOrders = new HashSet<PurchaseOrders>();
            SupplierTransactions = new HashSet<SupplierTransactions>();
            StockItems = new HashSet<StockItems>();
            StockItemTransactions = new HashSet<StockItemTransactions>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierID { get; set; }

        [Required]
        [StringLength(100)]
        public string SupplierName { get; set; }

        public int SupplierCategoryID { get; set; }

        public int PrimaryContactPersonID { get; set; }

        public int AlternateContactPersonID { get; set; }

        public int? DeliveryMethodID { get; set; }

        public int DeliveryCityID { get; set; }

        public int PostalCityID { get; set; }

        [StringLength(20)]
        public string SupplierReference { get; set; }

        [StringLength(50)]
        public string BankAccountName { get; set; }

        [StringLength(50)]
        public string BankAccountBranch { get; set; }

        [StringLength(20)]
        public string BankAccountCode { get; set; }

        [StringLength(20)]
        public string BankAccountNumber { get; set; }

        [StringLength(20)]
        public string BankInternationalCode { get; set; }

        public int PaymentDays { get; set; }

        public string InternalComments { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string FaxNumber { get; set; }

        [Required]
        [StringLength(256)]
        public string WebsiteURL { get; set; }

        [Required]
        [StringLength(60)]
        public string DeliveryAddressLine1 { get; set; }

        [StringLength(60)]
        public string DeliveryAddressLine2 { get; set; }

        [Required]
        [StringLength(10)]
        public string DeliveryPostalCode { get; set; }

        public DbGeography DeliveryLocation { get; set; }

        [Required]
        [StringLength(60)]
        public string PostalAddressLine1 { get; set; }

        [StringLength(60)]
        public string PostalAddressLine2 { get; set; }

        [Required]
        [StringLength(10)]
        public string PostalPostalCode { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ValidFrom { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ValidTo { get; set; }

        public virtual Cities Cities { get; set; }

        public virtual Cities Cities1 { get; set; }

        public virtual DeliveryMethods DeliveryMethods { get; set; }

        public virtual People People { get; set; }

        public virtual People People1 { get; set; }

        public virtual People People2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrders> PurchaseOrders { get; set; }

        public virtual SupplierCategories SupplierCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierTransactions> SupplierTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItems> StockItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItemTransactions> StockItemTransactions { get; set; }
    }
}
