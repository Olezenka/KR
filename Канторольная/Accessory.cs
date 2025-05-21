namespace Канторольная
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accessory")]
    public partial class Accessory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accessory()
        {
            AccessoriesToBoat = new HashSet<AccessoriesToBoat>();
            Order_Details = new HashSet<Order_Details>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Accessory_ID { get; set; }

        [StringLength(100)]
        public string AccName { get; set; }

        [StringLength(100)]
        public string DescriptionOfAccessory { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public double? VAT { get; set; }

        public int? Inventory { get; set; }

        public int? OrderLevel { get; set; }

        public int? OrderBatch { get; set; }

        public int? Partner_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessoriesToBoat> AccessoriesToBoat { get; set; }

        public virtual Partner Partner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
    }
}
