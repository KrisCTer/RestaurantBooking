namespace RestaurantBooking.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RESTAURANT")]
    public partial class RESTAURANT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESTAURANT()
        {
            MENUITEMs = new HashSet<MENUITEM>();
            RESERVATIONs = new HashSet<RESERVATION>();
            REVIEWs = new HashSet<REVIEW>();
            SERVICEs = new HashSet<SERVICE>();
        }

        [Key]
        [StringLength(10)]
        public string ID_RES { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string LOCATION { get; set; }

        [Required]
        [StringLength(15)]
        public string PHONE { get; set; }

        [StringLength(255)]
        public string BIO { get; set; }

        [StringLength(255)]
        public string DETAIL { get; set; }

        public double? PRICE { get; set; }

        public DateTime OPEN { get; set; }

        public DateTime CLOSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENUITEM> MENUITEMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVATION> RESERVATIONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REVIEW> REVIEWs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICE> SERVICEs { get; set; }
    }
}
