namespace RestaurantBooking.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MENUITEM")]
    public partial class MENUITEM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ITEM { get; set; }

        [Required]
        [StringLength(255)]
        public string ITEM { get; set; }

        [StringLength(255)]
        public string DESCRIPTION { get; set; }

        public double PRICE { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_RES { get; set; }

        public virtual RESTAURANT RESTAURANT { get; set; }
    }
}
