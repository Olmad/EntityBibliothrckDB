using EnBibliotechDB.Entity;
using EnBibliotechDB.Logic;
using EnBibliotechDB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBibliotechDB
{
    public partial class Form1 : Form
    {
        public EnBibliotechDB.Entity.Entity entity = new EnBibliotechDB.Entity.Entity();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorTableForm atf = new authorTableForm();
            atf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBook adb = new AddBook();
            adb.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddReader_s_Card arc = new AddReader_s_Card();
            arc.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
              entity.Person.Load();
            foreach (Person author in entity.Person.Local) 
            { dataGridView1.Rows.Add(author.SNP.name,author.SNP.surename, author.SNP.patronomic); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            authorLogic Al = new authorLogic();
            Al.Fill();
            foreach (authorModel item in Al.authors)
            {
                if(item.id==8)
                Al.Update(item); 
            }
            label1.Text = "Всё ок";
        }
    }
}
