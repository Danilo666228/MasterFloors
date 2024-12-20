namespace MasterFloor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            HistorySales = new HashSet<HistorySale>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int IdPartner { get; set; }

        public int PartnerTypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string PartnerName { get; set; }

        [Required]
        [StringLength(255)]
        public string DirectorName { get; set; }

        [Required]
        [StringLength(255)]
        public string PartnerEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string PartnerPhone { get; set; }

        [Required]
        [StringLength(255)]
        public string PartnerAddress { get; set; }

        [Required]
        [StringLength(255)]
        public string TaxpayerNumber { get; set; }

        public double PartnerRating { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorySale> HistorySales { get; set; }

        public virtual PartnerType PartnerType { get; set; }
    }
}
