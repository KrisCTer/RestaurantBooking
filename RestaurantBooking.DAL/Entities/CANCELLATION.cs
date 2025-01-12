namespace RestaurantBooking.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CANCELLATION")]
    public partial class CANCELLATION
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CAN { get; set; }

        public DateTime? DATE_CAN { get; set; }

        public double? REFUND_AMOUNT { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_RESERVATION { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string ID_RES { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string ID_USER { get; set; }
    }
}
