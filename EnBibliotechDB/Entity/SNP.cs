namespace EnBibliotechDB.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SNP")]
    public partial class SNP
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string surename { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        [Required]
        [StringLength(20)]
        public string patronomic { get; set; }

        public virtual Person Person { get; set; }
    }
}
