namespace EnBibliotechDB.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public int id { get; set; }

        [StringLength(50)]
        public string adress { get; set; }

        public virtual author author { get; set; }

        public virtual SNP SNP { get; set; }

        public virtual Reader Reader { get; set; }
    }
}
