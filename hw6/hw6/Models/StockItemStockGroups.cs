namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warehouse.StockItemStockGroups")]
    public partial class StockItemStockGroups
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockItemStockGroupID { get; set; }

        public int StockItemID { get; set; }

        public int StockGroupID { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastEditedWhen { get; set; }

        public virtual People People { get; set; }

        public virtual StockGroups StockGroups { get; set; }

        public virtual StockItems StockItems { get; set; }
    }
}
