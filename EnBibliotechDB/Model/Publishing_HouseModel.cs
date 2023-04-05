using EnBibliotechDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBibliotechDB.Model
{
    internal class Publishing_HouseModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string adress { get; set; }
        public virtual ICollection<Book> Book { get; set; }
        public Publishing_HouseModel Fill(Publishing_House data)
        {
            return new Publishing_HouseModel()
            {
            id = data.id,
            title = data.title,
            adress = data.adress,
            //Book = data.Book
            };
        }
    }
}
