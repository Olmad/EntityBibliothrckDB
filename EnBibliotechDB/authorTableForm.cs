using EnBibliotechDB.Entity;
using EnBibliotechDB.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBibliotechDB
{
    public partial class authorTableForm : Form
    {
        public Entity.Entity entity = new Entity.Entity();
        public authorTableForm()
        {
            InitializeComponent();
            foreach (author item in entity.author)
            {
                string[] proporties = { item.Person.SNP.surename, item.Person.SNP.name, item.Person.SNP.patronomic, item.adress };
                short i = 0;
                while(i!=proporties.Length) 
                {
                    if (proporties[i] == null) { proporties[i] = " "; }
                    i++;
                }
                dataGridView1.Rows.Add(item.id, proporties[0], proporties[1], proporties[2], proporties[3]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAuthor aa = new AddAuthor();
            aa.ShowDialog();
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            authorLogic al = new authorLogic();
            al.Remove(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.Refresh();
        }

       
    }
}
