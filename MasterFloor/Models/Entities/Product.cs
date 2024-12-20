namespace MasterFloor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [Key]
        public double IdProduct { get; set; }

        public int ProductTypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductArticle { get; set; }

        public double ProductMinPricePartner { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
