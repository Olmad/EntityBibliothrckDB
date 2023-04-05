namespace EnBibliotechDB.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int id { get; set; }

        public int? idReadersCard { get; set; }

        [Required]
        [StringLength(100)]
        public string nameoOfBook { get; set; }

        [Required]
        [StringLength(20)]
        public string ISBN { get; set; }

        [StringLength(20)]
        public string BBC { get; set; }

        public int idAuthor { get; set; }

        public int idPublishingHouse { get; set; }

        [Column(TypeName = "date")]
        public DateTime yearOfPublication { get; set; }

        public int numberOfPages { get; set; }

        public virtual author author { get; set; }

        public virtual Publishing_House Publishing_House { get; set; }

        public virtual Reader_s_Card Reader_s_Card { get; set; }
    }
}
