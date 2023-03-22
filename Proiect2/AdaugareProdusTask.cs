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
    public partial class AdaugareProdusTask : Form
    {
        private Produs produs;
        public AdaugareProdusTask(Produs produs)
        {
            InitializeComponent();
            this.produs = produs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            produs.Denumire = txtDenumire.Text;
            produs.Descriere = txtDescriere.Text;
            produs.Intrare = dtIntrare.Value;
            produs.Valabilitate = dtValabilitate.Value;
            produs.Cantitate = (int)nuCantitate.Value;
            this.Close();
        }
    }
}
