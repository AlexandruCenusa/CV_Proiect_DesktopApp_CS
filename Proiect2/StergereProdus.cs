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
    public partial class StergereProdus : Form
    {
        public StergereProdus()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            using (ProdusDbContext pdb = new ProdusDbContext())
            {
                int id;
                if (int.TryParse(txtID.Text, out id))
                {
                    Produs prod = pdb.Produse.Where(o => o.ID == id).FirstOrDefault();
                    try
                    {
                        pdb.Entry(prod).State = System.Data.Entity.EntityState.Deleted;
                        pdb.SaveChanges();
                        MessageBox.Show("Produs sters cu succes!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ID-ul nu exista!");
                    }
                }
                else
                {
                    MessageBox.Show("Introduceti o valoare valida!");
                }
            }
        }
    }
}
