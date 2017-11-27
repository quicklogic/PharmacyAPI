namespace PharmacyAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Image
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(1000)]
        public string imageURL { get; set; }

        public virtual Product Product { get; set; }
    }
}
