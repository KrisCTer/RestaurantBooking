namespace RestaurantBooking.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SERVICE")]
    public partial class SERVICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICE()
        {
            RESERVATIONs = new HashSet<RESERVATION>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SER { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_RES { get; set; }

        [StringLength(255)]
        public string NAME_SER { get; set; }

        public double? PRICE { get; set; }

        [StringLength(255)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVATION> RESERVATIONs { get; set; }

        public virtual RESTAURANT RESTAURANT { get; set; }
    }
}
