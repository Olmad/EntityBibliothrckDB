using EnBibliotechDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBibliotechDB.Model
{
    internal class BibliotheckModel
    {
        public int id { get; set; }
        public string adress { get; set; }
        public virtual ICollection<Reader_s_Card> Reader_s_Card { get; set; }
        public BibliotheckModel Fill(Bibliotheck data)
        {
            return new BibliotheckModel()
            {
                id = data.id,
                adress = data.adress,
                //Reader_s_Card = data.Reader_s_Card
            };
        }
    }
}
