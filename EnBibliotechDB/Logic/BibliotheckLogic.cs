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
    internal class BibliotheckLogic : IDisposable
    {
        Entity.Entity model;
        public List<BibliotheckModel> Bibliothecks { get; set; }
        BibliotheckModel selectedBibliotheck { get; set; }
        public BibliotheckLogic() 
        {
            model = new Entity.Entity();
            Bibliothecks = new List<BibliotheckModel>();
        }
        public async Task Fill() 
        {
            model.Bibliotheck.Load();
            foreach (Bibliotheck item in model.Bibliotheck.Local)
            {
                Bibliothecks.Add(new BibliotheckModel().Fill(item));
            }
        }
        public void Dispose()
        {
            MessageBox.Show("Внимание, используемая функция находится на стадии разработки и на данный момент не имеет реализации. Автор данной программы убедительно просит не пользоваться этой функцией", "Функция не работает", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
}
