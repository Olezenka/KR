namespace Канторольная
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Boat")]
    public partial class Boat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boat()
        {
            AccessoriesToBoat = new HashSet<AccessoriesToBoat>();
            Order = new HashSet<Order>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int boat_ID { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string BoatType { get; set; }

        public int? NumberOfRowers { get; set; }

        public bool? Mast { get; set; }

        [StringLength(50)]
        public string Colour { get; set; }

        [StringLength(50)]
        public string Wood { get; set; }

        [Column(TypeName = "money")]
        public decimal? BasePrice { get; set; }

        public double? VAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessoriesToBoat> AccessoriesToBoat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
