namespace RestaurantBooking.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REVIEW")]
    public partial class REVIEW
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_REVIEW { get; set; }

        public int? RATING { get; set; }

        [StringLength(255)]
        public string COMMENT { get; set; }

        [Required]
        [StringLength(5)]
        public string ID_USER { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_RES { get; set; }

        public virtual RESTAURANT RESTAURANT { get; set; }

        public virtual USER USER { get; set; }
    }
}
