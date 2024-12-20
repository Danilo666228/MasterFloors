namespace MasterFloor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HistorySale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdHistorySales { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }

        public int PartnerId { get; set; }

        public double Quantity { get; set; }

        public DateTime DateSales { get; set; }

        public virtual Partner Partner { get; set; }
    }
}
