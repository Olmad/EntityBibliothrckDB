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
            await model.author.LoadAsync();
            foreach (author item in model.author.Local) 
            {
                authors.Add(new authorModel().Fill(item));
            }
        }

        public void Dispose() 
        {
            MessageBox.Show("Внимание, используемая функция находится на стадии разработки и на данный момент не имеет реализации. Автор данной программы убедительно просит не пользоваться этой функцией", "Функция не работает", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
