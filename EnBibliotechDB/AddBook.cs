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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
            /*ScrollBar vScrollBar1 = new VScrollBar();
vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { panel1.VerticalScroll.Value = vScrollBar1.Value; };
            panel1.Controls.Add(vScrollBar1);*/

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
