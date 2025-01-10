namespace RestaurantBooking.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            RESERVATIONs = new HashSet<RESERVATION>();
            REVIEWs = new HashSet<REVIEW>();
        }

        [Key]
        [StringLength(5)]
        public string ID_USER { get; set; }

        [Required]
        [StringLength(100)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string PASSWORD { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL { get; set; }

        public DateTime? DATE { get; set; }

        [StringLength(255)]
        public string BIO { get; set; }

        [StringLength(15)]
        public string PHONE { get; set; }

        [StringLength(255)]
        public string ADDRESS { get; set; }

        [StringLength(10)]
        public string GENDER { get; set; }

        public DateTime? BIRTHDAY { get; set; }

        [StringLength(255)]
        public string AVATAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVATION> RESERVATIONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REVIEW> REVIEWs { get; set; }
    }
}
