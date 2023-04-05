using EnBibliotechDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBibliotechDB.Model
{
    internal class Reader_s_CardModel
    {
        public int id { get; set; }
        public int idBibliotheck { get; set; }
        public virtual Bibliotheck Bibliotheck { get; set; }
        public virtual ICollection<Book> Book { get; set; }
        public virtual Reader Reader { get; set; }
        
        
        
        public Reader_s_CardModel Fill(Reader_s_Card data)
        {
            return new Reader_s_CardModel() 
            {
            id = data.id,
            idBibliotheck = data.idBibliotheck,
            Bibliotheck = data.Bibliotheck,
            Book = data.Book,
            Reader = data.Reader
            };
        }
    }
}
