using EnBibliotechDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBibliotechDB.Model
{
    internal class authorModel
    {
        public int id { get; set; }
        public virtual ICollection<Book> Book { get; set; }
        public virtual Person Person { get; set; }

        public authorModel Fill(author data)
        {
            return new authorModel() 
            {
            id = data.id,
            Book = data.Book,
            Person = data.Person
            };
        
                
        
        }
    }
}
