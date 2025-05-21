namespace Канторольная
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            Invoice = new HashSet<Invoice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Contract_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? DepositPayed { get; set; }

        public int? Order_ID { get; set; }

        public int? ContractTotalPrice { get; set; }

        public int? ContracTotalPrice_inclVAT { get; set; }

        [StringLength(50)]
        public string ProductionProcess { get; set; }

        public virtual Order Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
