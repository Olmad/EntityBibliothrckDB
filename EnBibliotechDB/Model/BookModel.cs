using EnBibliotechDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBibliotechDB.Model
{
    internal class BookModel
    {
        public int id { get; set; }
        public int? idReaderCard { get; set; }//

        public string nameOfBook { get; set; }//
        public string ISBN { get; set; }//
        public string BBC { get; set; }//

        public int idAuthor { get; set; }//
        public int idPublishingHouse { get; set; }//

        
        public DateTime yearOfPublication { get; set; }//
        public int numberOfPages { get; set; }//

        public virtual author author { get; set; }

        public virtual Publishing_House Publishing_House { get; set; }

        public virtual Reader_s_Card Reader_s_Card { get; set; }

        public BookModel Fill(Book data)
        {
            return new BookModel()
            {
            id = data.id,
            idReaderCard = data.idReadersCard,
            nameOfBook = data.nameoOfBook,
            ISBN = data.ISBN,
            BBC = data.BBC,
            idAuthor = data.idAuthor,
            idPublishingHouse = data.idPublishingHouse,
            yearOfPublication = data.yearOfPublication,
            numberOfPages = data.numberOfPages,
            author = data.author,
            Publishing_House = data.Publishing_House,
            Reader_s_Card = data.Reader_s_Card
            };
        }
    }
}
