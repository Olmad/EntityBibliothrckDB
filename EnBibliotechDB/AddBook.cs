using EnBibliotechDB.Entity;
using EnBibliotechDB.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBibliotechDB
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
            
            
            Reader_s_CardLogic RCL = new Reader_s_CardLogic();
            RCL.Fill();
            authorLogic AL = new authorLogic();
            AL.Fill();
            Publishing_HouseLogic PHL = new Publishing_HouseLogic();
            PHL.Fill(); 
            foreach (Model.Reader_s_CardModel reader in RCL.Reader_s_Cards) 
            {
                comboBox1.Items.Add(reader.Reader.Person.SNP.surename + " " + reader.Reader.Person.SNP.name + " " + reader.Reader.Person.SNP.patronomic);
            }
            foreach (Model.authorModel author in AL.authors)
            {
                comboBox2.Items.Add(author.Person.SNP.surename+" "+ author.Person.SNP.name + author.Person.SNP.patronomic);
            }
            foreach (Model.Publishing_HouseModel PH in PHL.Publishing_Houses)
            {
                comboBox3.Items.Add(PH.title);
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
