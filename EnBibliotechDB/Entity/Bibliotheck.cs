namespace EnBibliotechDB.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bibliotheck")]
    public partial class Bibliotheck
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bibliotheck()
        {
            Reader_s_Card = new HashSet<Reader_s_Card>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(40)]
        public string adress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reader_s_Card> Reader_s_Card { get; set; }
    }
}
