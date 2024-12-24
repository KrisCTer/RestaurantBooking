namespace RestaurantBooking
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERS")]
    public partial class USER
    {
        public int ID { get; set; }

        public string USERNAME { get; set; }

        public string PASSWORD { get; set; }

        public string ROLE { get; set; }

        public string STATUS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE { get; set; }
    }
}
