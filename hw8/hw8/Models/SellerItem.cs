namespace hw8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SellerItem")]
    public partial class SellerItem
    {
        [Key]
        public int SIID { get; set; }

        public int SID { get; set; }

        public int IID { get; set; }

        public virtual Item Item { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
