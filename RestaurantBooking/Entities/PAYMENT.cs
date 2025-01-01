namespace RestaurantBooking.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PAYMENT")]
    public partial class PAYMENT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PAYMENT { get; set; }

        public double? AMOUNT { get; set; }

        public DateTime? DATE_PAYMENT { get; set; }

        [StringLength(1)]
        public string METHOD { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_RESERVATION { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string ID_USER { get; set; }

        public virtual RESERVATION RESERVATION { get; set; }

        public virtual USER USER { get; set; }
    }
}
