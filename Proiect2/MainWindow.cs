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
    public partial class MainWindow : Form
    {
        LoginPage loginPage;
        public MainWindow(LoginPage loginPage)
        {
            InitializeComponent();

            refreshGrid();

            if (LoginState.id == -1)
            {
                lblNume.Text = "guest";
                btnCumparare.Enabled = false;
                lblWarning.Text = "Trebuie sa fi logat pentru a cumpara!";
                lblWarning.Enabled = true;

                lblID.Enabled = false;
                txtID.Enabled = false;
                lblCantitate.Enabled = false;
                txtCantitate.Enabled = false;
            }
            else
            {
                lblNume.Text = LoginState.nume;
                btnCumparare.Enabled = true;
                lblWarning.Text = "";
                lblWarning.Enabled = false;
            }

            if (LoginState.isAdmin == true)
            {
                lblNume.Text = LoginState.nume + " (admin)";
                mAdministrareMagazin.Enabled = true;
                mAdministrareUtilizatori.Enabled = true;
            }
            else
            {
                mAdministrareMagazin.Text = "";
                mAdministrareUtilizatori.Text = "";
                mAdministrareUtilizatori.Enabled = false;
                mAdministrareMagazin.Enabled = false;
            }

            this.loginPage = loginPage;
        }

        public void refreshGrid()
        {
            using (ProdusDbContext pdb = new ProdusDbContext())
            {
                /*List<Produs> lst = pdb.Produse.Where(o => o.Cantitate.Equals(0)).ToList();
                
                foreach(var d in lst)
                {
                    pdb.Entry(d).State = System.Data.Entity.EntityState.Deleted;
                }
                pdb.SaveChanges();*/

                var res = from s in pdb.Produse
                          select new
                          {
                              s.ID,
                              s.Denumire,
                              s.Cantitate
                          };
                dgView.DataSource = res.ToList();
            }
        }

        private void istoricComenziToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (IstoricVanzariDbContext pdb = new IstoricVanzariDbContext())
            {
                var res = from s in pdb.Istoric
                          select new
                          {
                              s.ID,
                              s.ID_user,
                              s.Produs,
                              s.Cantitate
                          };
                dgView.DataSource = res.ToList();
            }
        }

        private void refreshProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void adaugareProdusNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produs produs = new Produs();
            produs.Denumire = null;
            AdaugareProdusTask ap = new AdaugareProdusTask(produs);
            ap.Show();

            var rez = Task.Run(() => AsyncAdaugareProdus(produs));
            rez.Wait();

            refreshGrid();
        }

        private async Task AsyncAdaugareProdus(Produs p)
        {
                using (ProdusDbContext pdb = new ProdusDbContext())
                {
                    pdb.Produse.Add(p);
                    await pdb.SaveChangesAsync();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtCantitate.Text.Length == 0 || txtID.Text.Length == 0)
            {
                MessageBox.Show("Completati ambele campuri!");
            }
            else
            {
                int id;
                if (int.TryParse(txtID.Text, out id))
                {
                    int cantitate = int.Parse(txtCantitate.Text);

                    using (ProdusDbContext pdb = new ProdusDbContext())
                    {
                        var res = from s in pdb.Produse
                                  where s.ID.Equals(id)
                                  select new
                                  {
                                      s.Cantitate
                                  };
                        try
                        {
                            if (res.First().Cantitate >= cantitate)
                            {
                                Console.WriteLine("BUYED");
                                txtID.Text = "";
                                txtCantitate.Text = "";

                                Produs p = pdb.Produse.Where(o => o.ID.Equals(id)).FirstOrDefault();
                                p.Cantitate -= cantitate;
                                pdb.Entry(p).State = System.Data.Entity.EntityState.Modified;
                                pdb.SaveChanges();

                                //Adaugare produse in istoric
                                IstoricVanzari ip = new IstoricVanzari()
                                {
                                    ID_user = LoginState.id,
                                    Produs = p.Denumire,
                                    Cantitate = cantitate
                                };
                                var rez = Task.Run(() => AsyncAdaugareProdusIstoric(ip));
                                rez.Wait();

                                refreshGrid();
                                MessageBox.Show("Produsul a fost achizitionat cu succes!");
                            }
                            else
                                MessageBox.Show("Nu sunt destule produse in stoc!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Produsul cu ID-ul introdus nu a fost gasit");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Introduceti un id valid!");
                    txtID.Text = "";
                    txtCantitate.Text = "";
                }
            }
        }

        private async Task AsyncAdaugareProdusIstoric(IstoricVanzari p)
        {
            using (IstoricVanzariDbContext pdb = new IstoricVanzariDbContext())
            {
                pdb.Istoric.Add(p);
                await pdb.SaveChangesAsync();
            }
        }

        private void deconectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginState.IsLoggedIn = false;
            LoginState.id = -1;
            LoginState.nume = null;
            LoginState.username = null;
            LoginState.username = null;
            LoginPage p = new LoginPage();
            p.Show();
            this.Hide();
        }

        //Oprire program din alt form
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginPage.Close();
            this.Dispose();
        }

        private void istoricComenziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (IstoricVanzariDbContext idb = new IstoricVanzariDbContext())
            {
                var res = from s in idb.Istoric
                          where s.ID_user.Equals(LoginState.id)
                          select new
                          {
                              s.ID,
                              s.Produs,
                              s.Cantitate
                          };
                dgView.DataSource = res.ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (ProdusDbContext idb = new ProdusDbContext())
            {
                var res = from s in idb.Produse
                          where (s.Denumire.Contains(txtSearch.Text) || s.Descriere.Contains(txtSearch.Text))
                          select new
                          {
                              s.ID,
                              s.Denumire,
                              s.Descriere,
                              s.Cantitate
                          };
                dgView.DataSource = res.ToList();
            }
        }

        private void btnDetalii_Click(object sender, EventArgs e)
        {
            Produs produs = new Produs();

            using(ProdusDbContext pdb = new ProdusDbContext())
            {
                int id;
                if (int.TryParse(txtIDDet.Text, out id))
                {
                    var rez = from s in pdb.Produse
                              where s.ID.Equals(id)
                              select new
                              {
                                  s.Denumire,
                                  s.Descriere,
                                  s.Cantitate
                              };
                    produs.Denumire = rez.First().Denumire;
                    produs.Descriere = rez.First().Descriere;
                    produs.Cantitate = rez.First().Cantitate;

                    Detalii det = new Detalii(produs);
                    det.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Introduceti o valoare valida!");
                }
            }
        }
        private void adaugareCantitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCantitatePage page = new UpdateCantitatePage();
            page.ShowDialog();

            refreshGrid();
        }

        private void stergereContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergereCont form = new StergereCont();
            form.ShowDialog();
        }

        private async void stergereProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergereProdus form = new StergereProdus();
            form.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect realizat de Cenusa Stefan Alexandru. \nRelease: 14.01.2023");
        }
    }
}
