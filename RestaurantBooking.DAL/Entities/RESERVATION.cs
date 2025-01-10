namespace RestaurantBooking.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RESERVATION")]
    public partial class RESERVATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESERVATION()
        {
            CANCELLATIONs = new HashSet<CANCELLATION>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_RESERVATION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ID_RES { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string ID_USER { get; set; }

        public DateTime? DATE_RESERVATION { get; set; }

        public int? NUMBERS_OF_GUEST { get; set; }

        [StringLength(255)]
        public string NOTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANCELLATION> CANCELLATIONs { get; set; }

        public virtual RESTAURANT RESTAURANT { get; set; }

        public virtual USER USER { get; set; }
    }
}
