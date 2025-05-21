namespace Канторольная
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessoriesToBoat")]
    public partial class AccessoriesToBoat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Fit_ID { get; set; }

        public int? Accessory_ID { get; set; }

        public int? Boat_ID { get; set; }

        public virtual Accessory Accessory { get; set; }

        public virtual Boat Boat { get; set; }
    }
}
