using System;
using EnBibliotechDB.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnBibliotechDB.Model;
using System.Windows.Forms;
using System.Data.Entity;

namespace EnBibliotechDB.Logic
{
    internal class authorLogic: IDisposable
    {
        Entity.Entity model;
        public List<authorModel> authors { get; set; }
        authorModel selectedAuthors { get; set; }
        public authorLogic() 
        {
            model = new Entity.Entity();
            authors = new List<authorModel>();

        }

        public async Task Fill() 
        {
            model.author.Load();
            foreach (author item in model.author.Local) 
            {
                authors.Add(new authorModel().Fill(item));
            }
        }

        public void Add(authorModel newAuthor) 
        {
            model.author.Add(new author 
            {
            id_Person=newAuthor.id_Person,
            adress=newAuthor.adress,
            Person = newAuthor.Person,
            Book = newAuthor.Book,
            });
            model.SaveChanges();
        }

        public void Update(authorModel updatingAuthor) 
        {
            //var OrderForUpdate = model.author.FirstOrDefault(,);
            author au = model.author.Find(updatingAuthor.id);
            au.id_Person = updatingAuthor.id_Person;
            au.adress = updatingAuthor.adress;
            au.Book = updatingAuthor.Book;
            au.Person = updatingAuthor.Person;
            model.SaveChanges();
        }
        public void Remove(int idDeletingAuthor)
        {
            author au = model.author.Find(idDeletingAuthor);
            model.author.Remove(au);
            model.SaveChanges();
        }
        public void Remove(author au)
        {
            model.author.Remove(au);
            model.SaveChanges();
        }
        public void Remove(authorModel deletingAuthor) 
        {
            author au = model.author.Find(deletingAuthor.id);
            model.author.Remove(au);
            model.SaveChanges();
        }
        public void Dispose() 
        {
            MessageBox.Show("Внимание, используемая функция находится на стадии разработки и на данный момент не имеет реализации. Автор данной программы убедительно просит не пользоваться этой функцией", "Функция не работает", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
