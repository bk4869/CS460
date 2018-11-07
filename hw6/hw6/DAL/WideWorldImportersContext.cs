namespace hw6.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WideWorldImportersContext : DbContext
    {
        public WideWorldImportersContext()
            : base("name=WideWorldImportersContext")
        {
        }

        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<DeliveryMethods> DeliveryMethods { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<StateProvinces> StateProvinces { get; set; }
        public virtual DbSet<SystemParameters> SystemParameters { get; set; }
        public virtual DbSet<TransactionTypes> TransactionTypes { get; set; }
        public virtual DbSet<PurchaseOrderLines> PurchaseOrderLines { get; set; }
        public virtual DbSet<PurchaseOrders> PurchaseOrders { get; set; }
        public virtual DbSet<SupplierCategories> SupplierCategories { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<SupplierTransactions> SupplierTransactions { get; set; }
        public virtual DbSet<BuyingGroups> BuyingGroups { get; set; }
        public virtual DbSet<CustomerCategories> CustomerCategories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CustomerTransactions> CustomerTransactions { get; set; }
        public virtual DbSet<InvoiceLines> InvoiceLines { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<OrderLines> OrderLines { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<SpecialDeals> SpecialDeals { get; set; }
        public virtual DbSet<ColdRoomTemperatures> ColdRoomTemperatures { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<PackageTypes> PackageTypes { get; set; }
        public virtual DbSet<StockGroups> StockGroups { get; set; }
        public virtual DbSet<StockItemHoldings> StockItemHoldings { get; set; }
        public virtual DbSet<StockItems> StockItems { get; set; }
        public virtual DbSet<StockItemStockGroups> StockItemStockGroups { get; set; }
        public virtual DbSet<StockItemTransactions> StockItemTransactions { get; set; }
        public virtual DbSet<VehicleTemperatures> VehicleTemperatures { get; set; }
        public virtual DbSet<Cities_Archive> Cities_Archive { get; set; }
        public virtual DbSet<Countries_Archive> Countries_Archive { get; set; }
        public virtual DbSet<DeliveryMethods_Archive> DeliveryMethods_Archive { get; set; }
        public virtual DbSet<PaymentMethods_Archive> PaymentMethods_Archive { get; set; }
        public virtual DbSet<People_Archive> People_Archive { get; set; }
        public virtual DbSet<StateProvinces_Archive> StateProvinces_Archive { get; set; }
        public virtual DbSet<TransactionTypes_Archive> TransactionTypes_Archive { get; set; }
        public virtual DbSet<SupplierCategories_Archive> SupplierCategories_Archive { get; set; }
        public virtual DbSet<Suppliers_Archive> Suppliers_Archive { get; set; }
        public virtual DbSet<BuyingGroups_Archive> BuyingGroups_Archive { get; set; }
        public virtual DbSet<CustomerCategories_Archive> CustomerCategories_Archive { get; set; }
        public virtual DbSet<Customers_Archive> Customers_Archive { get; set; }
        public virtual DbSet<ColdRoomTemperatures_Archive> ColdRoomTemperatures_Archive { get; set; }
        public virtual DbSet<Colors_Archive> Colors_Archive { get; set; }
        public virtual DbSet<PackageTypes_Archive> PackageTypes_Archive { get; set; }
        public virtual DbSet<StockGroups_Archive> StockGroups_Archive { get; set; }
        public virtual DbSet<StockItems_Archive> StockItems_Archive { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>()
                .HasMany(e => e.SystemParameters)
                .WithRequired(e => e.Cities)
                .HasForeignKey(e => e.DeliveryCityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.SystemParameters1)
                .WithRequired(e => e.Cities1)
                .HasForeignKey(e => e.PostalCityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Suppliers)
                .WithRequired(e => e.Cities)
                .HasForeignKey(e => e.DeliveryCityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Suppliers1)
                .WithRequired(e => e.Cities1)
                .HasForeignKey(e => e.PostalCityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.Cities)
                .HasForeignKey(e => e.DeliveryCityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Customers1)
                .WithRequired(e => e.Cities1)
                .HasForeignKey(e => e.PostalCityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.StateProvinces)
                .WithRequired(e => e.Countries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeliveryMethods>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.DeliveryMethods)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeliveryMethods>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.DeliveryMethods)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeliveryMethods>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.DeliveryMethods)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Cities)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Countries)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.DeliveryMethods)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.PaymentMethods)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.People1)
                .WithRequired(e => e.People2)
                .HasForeignKey(e => e.LastEditedBy);

            modelBuilder.Entity<People>()
                .HasMany(e => e.StateProvinces)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.SystemParameters)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.TransactionTypes)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.PurchaseOrderLines)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.PurchaseOrders1)
                .WithRequired(e => e.People1)
                .HasForeignKey(e => e.ContactPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.SupplierCategories)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Suppliers)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.AlternateContactPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Suppliers1)
                .WithRequired(e => e.People1)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Suppliers2)
                .WithRequired(e => e.People2)
                .HasForeignKey(e => e.PrimaryContactPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.SupplierTransactions)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.BuyingGroups)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.CustomerCategories)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.People)
                .HasForeignKey(e => e.AlternateContactPersonID);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Customers1)
                .WithRequired(e => e.People1)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Customers2)
                .WithRequired(e => e.People2)
                .HasForeignKey(e => e.PrimaryContactPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.CustomerTransactions)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.InvoiceLines)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.AccountsPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Invoices1)
                .WithRequired(e => e.People1)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Invoices2)
                .WithRequired(e => e.People2)
                .HasForeignKey(e => e.ContactPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Invoices3)
                .WithRequired(e => e.People3)
                .HasForeignKey(e => e.PackedByPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Invoices4)
                .WithRequired(e => e.People4)
                .HasForeignKey(e => e.SalespersonPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.OrderLines)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Orders1)
                .WithRequired(e => e.People1)
                .HasForeignKey(e => e.ContactPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Orders2)
                .WithOptional(e => e.People2)
                .HasForeignKey(e => e.PickedByPersonID);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Orders3)
                .WithRequired(e => e.People3)
                .HasForeignKey(e => e.SalespersonPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.SpecialDeals)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Colors)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.PackageTypes)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.StockGroups)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.StockItemHoldings)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.StockItems)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.StockItemStockGroups)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.StockItemTransactions)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StateProvinces>()
                .HasMany(e => e.Cities)
                .WithRequired(e => e.StateProvinces)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionTypes>()
                .HasMany(e => e.SupplierTransactions)
                .WithRequired(e => e.TransactionTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionTypes>()
                .HasMany(e => e.CustomerTransactions)
                .WithRequired(e => e.TransactionTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionTypes>()
                .HasMany(e => e.StockItemTransactions)
                .WithRequired(e => e.TransactionTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrders>()
                .HasMany(e => e.PurchaseOrderLines)
                .WithRequired(e => e.PurchaseOrders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplierCategories>()
                .HasMany(e => e.Suppliers)
                .WithRequired(e => e.SupplierCategories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suppliers>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.Suppliers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suppliers>()
                .HasMany(e => e.SupplierTransactions)
                .WithRequired(e => e.Suppliers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suppliers>()
                .HasMany(e => e.StockItems)
                .WithRequired(e => e.Suppliers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerCategories>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.CustomerCategories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.StandardDiscountPercentage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Customers1)
                .WithRequired(e => e.Customers2)
                .HasForeignKey(e => e.BillToCustomerID);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.CustomerTransactions)
                .WithRequired(e => e.Customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Customers)
                .HasForeignKey(e => e.BillToCustomerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Invoices1)
                .WithRequired(e => e.Customers1)
                .HasForeignKey(e => e.CustomerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceLines>()
                .Property(e => e.TaxRate)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Invoices>()
                .HasMany(e => e.InvoiceLines)
                .WithRequired(e => e.Invoices)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderLines>()
                .Property(e => e.TaxRate)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderLines)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Orders1)
                .WithOptional(e => e.Orders2)
                .HasForeignKey(e => e.BackorderOrderID);

            modelBuilder.Entity<SpecialDeals>()
                .Property(e => e.DiscountPercentage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ColdRoomTemperatures>()
                .Property(e => e.Temperature)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PackageTypes>()
                .HasMany(e => e.PurchaseOrderLines)
                .WithRequired(e => e.PackageTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PackageTypes>()
                .HasMany(e => e.InvoiceLines)
                .WithRequired(e => e.PackageTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PackageTypes>()
                .HasMany(e => e.OrderLines)
                .WithRequired(e => e.PackageTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PackageTypes>()
                .HasMany(e => e.StockItems)
                .WithRequired(e => e.PackageTypes)
                .HasForeignKey(e => e.OuterPackageID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PackageTypes>()
                .HasMany(e => e.StockItems1)
                .WithRequired(e => e.PackageTypes1)
                .HasForeignKey(e => e.UnitPackageID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockGroups>()
                .HasMany(e => e.StockItemStockGroups)
                .WithRequired(e => e.StockGroups)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockItems>()
                .Property(e => e.TaxRate)
                .HasPrecision(18, 3);

            modelBuilder.Entity<StockItems>()
                .Property(e => e.TypicalWeightPerUnit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<StockItems>()
                .HasMany(e => e.PurchaseOrderLines)
                .WithRequired(e => e.StockItems)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockItems>()
                .HasMany(e => e.InvoiceLines)
                .WithRequired(e => e.StockItems)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockItems>()
                .HasMany(e => e.OrderLines)
                .WithRequired(e => e.StockItems)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockItems>()
                .HasOptional(e => e.StockItemHoldings)
                .WithRequired(e => e.StockItems);

            modelBuilder.Entity<StockItems>()
                .HasMany(e => e.StockItemStockGroups)
                .WithRequired(e => e.StockItems)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockItems>()
                .HasMany(e => e.StockItemTransactions)
                .WithRequired(e => e.StockItems)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockItemTransactions>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VehicleTemperatures>()
                .Property(e => e.Temperature)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customers_Archive>()
                .Property(e => e.StandardDiscountPercentage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ColdRoomTemperatures_Archive>()
                .Property(e => e.Temperature)
                .HasPrecision(10, 2);

            modelBuilder.Entity<StockItems_Archive>()
                .Property(e => e.TaxRate)
                .HasPrecision(18, 3);

            modelBuilder.Entity<StockItems_Archive>()
                .Property(e => e.TypicalWeightPerUnit)
                .HasPrecision(18, 3);
        }
    }
}
