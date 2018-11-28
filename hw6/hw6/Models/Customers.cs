namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.Customers")]
    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            Customers1 = new HashSet<Customers>();
            CustomerTransactions = new HashSet<CustomerTransactions>();
            Invoices = new HashSet<Invoices>();
            Invoices1 = new HashSet<Invoices>();
            Orders = new HashSet<Orders>();
            SpecialDeals = new HashSet<SpecialDeals>();
            StockItemTransactions = new HashSet<StockItemTransactions>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        public int BillToCustomerID { get; set; }

        public int CustomerCategoryID { get; set; }

        public int? BuyingGroupID { get; set; }

        public int PrimaryContactPersonID { get; set; }

        public int? AlternateContactPersonID { get; set; }

        public int DeliveryMethodID { get; set; }

        public int DeliveryCityID { get; set; }

        public int PostalCityID { get; set; }

        public decimal? CreditLimit { get; set; }

        [Column(TypeName = "date")]
        public DateTime AccountOpenedDate { get; set; }

        public decimal StandardDiscountPercentage { get; set; }

        public bool IsStatementSent { get; set; }

        public bool IsOnCreditHold { get; set; }

        public int PaymentDays { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string FaxNumber { get; set; }

        [StringLength(5)]
        public string DeliveryRun { get; set; }

        [StringLength(5)]
        public string RunPosition { get; set; }

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

        public virtual BuyingGroups BuyingGroups { get; set; }

        public virtual CustomerCategories CustomerCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers1 { get; set; }

        public virtual Customers Customers2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerTransactions> CustomerTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialDeals> SpecialDeals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItemTransactions> StockItemTransactions { get; set; }
    }
}