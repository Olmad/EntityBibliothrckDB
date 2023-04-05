namespace EnBibliotechDB.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reader")]
    public partial class Reader
    {
        public int id { get; set; }

        [StringLength(50)]
        public string adress { get; set; }

        public virtual Person Person { get; set; }

        public virtual Reader_s_Card Reader_s_Card { get; set; }
    }
}
