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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBibliotechDB
{
    public partial class AddReader_s_Card : Form
    {
        public AddReader_s_Card()
        {
            BookLogic BL = new BookLogic();
            BL.Fill();
            Reader_s_CardLogic RCL = new Reader_s_CardLogic();
            RCL.Fill();
            
                InitializeComponent();
            foreach (Reader_s_CardModel item in RCL.Reader_s_Cards)
            {
                comboBox1.Items.Add(item.Bibliotheck.adress);
                comboBox3.Items.Add(Convert.ToString(item.Reader.Person.SNP.surename + item.Reader.Person.SNP.name + item.Reader.Person.SNP.patronomic));       
            }
            foreach(BookModel item in BL.Books)
            {
                comboBox2.Items.Add(item.nameOfBook);
            }
        }
    }
}
