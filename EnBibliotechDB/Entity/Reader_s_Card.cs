namespace EnBibliotechDB.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reader's Card")]
    public partial class Reader_s_Card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reader_s_Card()
        {
            Book = new HashSet<Book>();
        }

        public int id { get; set; }

        public int idBibliotheck { get; set; }

        public virtual Bibliotheck Bibliotheck { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Book { get; set; }

        public virtual Reader Reader { get; set; }
    }
}
