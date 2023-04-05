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
    internal class Reader_s_CardLogic
    {
        Entity.Entity model;
        public List<Reader_s_CardModel> Reader_s_Cards { get; set; }
        Reader_s_CardModel selectedReader_s_Card { get; set; }
        public Reader_s_CardLogic()
        {
            model = new Entity.Entity();
            Reader_s_Cards = new List<Reader_s_CardModel>();

        }

        public async Task Fill()
        {
            await model.author.LoadAsync();
            foreach (Reader_s_Card item in model.Reader_s_Card.Local)
            {
                Reader_s_Cards.Add(new Reader_s_CardModel().Fill(item));
            }
        }

        public void Dispose()
        {
            MessageBox.Show("Внимание, используемая функция находится на стадии разработки и на данный момент не имеет реализации. Автор данной программы убедительно просит не пользоваться этой функцией", "Функция не работает", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
