using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Proiect2
{
    public partial class UpdateCantitatePage : Form
    {
        public UpdateCantitatePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantitate, id;
            if(int.TryParse(txtID.Text, out id) && int.TryParse(txtCantitate.Text, out cantitate)) 
            {
                using (ProdusDbContext pdb = new ProdusDbContext())
                {
                    var res = from s in pdb.Produse
                              where s.ID.Equals(id)
                              select new
                              {
                                  s.Cantitate
                              };
                    if (res.Count() == 1)
                    {
                        txtID.Text = "";
                        txtCantitate.Text = "";

                        Produs p = pdb.Produse.Where(o => o.ID.Equals(id)).FirstOrDefault();
                        p.Cantitate += cantitate;
                        pdb.Entry(p).State = EntityState.Modified;
                        pdb.SaveChanges();

                        MessageBox.Show("Produsul a fost actualizat cu succes!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ID-ul nu a fost gasit");
                    }
                }
            }
            else
            {
                MessageBox.Show("Datele introduse sunt invalide");
            }
        }
    }
}
