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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNP()
        {
            Person = new HashSet<Person>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Person { get; set; }
    }
}
