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
    public partial class StergereCont : Form
    {
        public StergereCont()
        {
            InitializeComponent();
            refreshGrid();

        }

        public void refreshGrid()
        {
            using (UtilizatorDbContext udb = new UtilizatorDbContext())
            {
                var res = from s in udb.Utilizatori
                          select new
                          {
                              s.ID,
                              s.Nume,
                              s.Prenume,
                              s.Username
                          };
                gridUtilizatori.DataSource = res.ToList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            using (UtilizatorDbContext udb = new UtilizatorDbContext())
            {
                int id;
                if (int.TryParse(txtID.Text, out id))
                {
                    Utilizator utilizator = udb.Utilizatori.Where(o => o.ID== id).FirstOrDefault();
                    try
                    {
                        udb.Entry(utilizator).State = System.Data.Entity.EntityState.Deleted;
                        udb.SaveChanges();
                        refreshGrid();
                        MessageBox.Show("Cont sters cu succes!");
                    }
                    catch(Exception ex)
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
