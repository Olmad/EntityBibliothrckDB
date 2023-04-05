using EnBibliotechDB.Entity;
using EnBibliotechDB.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EnBibliotechDB.Logic
{
    internal class BookLogic:IDisposable
    {
        Entity.Entity model;
        public List<BookModel> Books { get; set; }
        BookModel selectedBook { get; set; }
        public BookLogic() 
        {
            model = new Entity.Entity();
            Books = new List<BookModel>();
        }
        public async Task Fill() 
        {
            await model.Book.LoadAsync();
            foreach (Book item in model.Book.Local)
            {
                Books.Add(new BookModel().Fill(item));
            }
        }

        public void Dispose()
        {
            MessageBox.Show("Внимание, используемая функция находится на стадии разработки и на данный момент не имеет реализации. Автор данной программы убедительно просит не пользоваться этой функцией", "Функция не работает", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
}
}
