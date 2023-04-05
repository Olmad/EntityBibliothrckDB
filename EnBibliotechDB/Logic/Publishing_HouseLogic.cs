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
    internal class Publishing_HouseLogic
    {
        Entity.Entity model;
        public List<Publishing_HouseModel> Publishing_Houses { get; set; }
        Publishing_HouseModel selectedPublishing_House { get; set; }
        public Publishing_HouseLogic() 
        {
            model = new Entity.Entity();
            model = new Entity.Entity();
            Publishing_Houses = new List<Publishing_HouseModel>();
        }

        public async Task Fill() 
        {
            await model.Publishing_House.LoadAsync();
            foreach (Publishing_House item in model.Publishing_House.Local)
            {
                Publishing_Houses.Add(new Publishing_HouseModel().Fill(item));
            }
        }
        public void Dispose()
        {
            MessageBox.Show("Внимание, используемая функция находится на стадии разработки и на данный момент не имеет реализации. Автор данной программы убедительно просит не пользоваться этой функцией", "Функция не работает", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
