using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class Detalii : Form
    {
        public Detalii(Produs produs)
        {
            InitializeComponent();
            txtDenumire.Text = produs.Denumire;
            txtCantitate.Text = produs.Cantitate.ToString();
            txtDescriere.Text = produs.Descriere;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
