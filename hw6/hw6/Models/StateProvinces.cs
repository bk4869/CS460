namespace hw6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Application.StateProvinces")]
    public partial class StateProvinces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StateProvinces()
        {
            Cities = new HashSet<Cities>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StateProvinceID { get; set; }

        [Required]
        [StringLength(5)]
        public string StateProvinceCode { get; set; }

        [Required]
        [StringLength(50)]
        public string StateProvinceName { get; set; }

        public int CountryID { get; set; }

        [Required]
        [StringLength(50)]
        public string SalesTerritory { get; set; }

        public DbGeography Border { get; set; }

        public long? LatestRecordedPopulation { get; set; }

        public int LastEditedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ValidFrom { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ValidTo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cities> Cities { get; set; }

        public virtual Countries Countries { get; set; }

        public virtual People People { get; set; }
    }
}
