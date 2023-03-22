using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proiect2
{
    public partial class LoginPage : Form
    { 
        public LoginPage()
        {
            InitializeComponent();
            LoginState.IsLoggedIn = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Utilizator utilizator= new Utilizator();
            utilizator.Nume = null;
            RegisterWindowTask register= new RegisterWindowTask(utilizator);

            register.ShowDialog();

            var rez = Task.Run(() => AsyncAdaugareUtilizator(utilizator));
            rez.Wait();
        }

        private async Task AsyncAdaugareUtilizator(Utilizator u)
        {
            if (u.Nume != null)
                using (UtilizatorDbContext udb = new UtilizatorDbContext())
                {
                    udb.Utilizatori.Add(u);
                    await udb.SaveChangesAsync();
                }
            else
                Console.WriteLine("Fereastra inchisa!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Length == 0 || password.Length == 0)
                MessageBox.Show("Completati toate campurile!");
            else
            {
                
                using (UtilizatorDbContext ut = new UtilizatorDbContext())
                {
                    var rez = from s in ut.Utilizatori
                              where (s.Username.Equals(username) && s.Password.Equals(password))
                              select new
                              {
                                  s.ID,
                                  s.Nume,
                                  s.Prenume,
                                  s.Username,
                                  s.IsAdmin
                              };
                    try
                    {
                        if (rez.First() != null)
                        {
                            Console.WriteLine("Login successful");
                            LoginState.IsLoggedIn = true;
                            LoginState.id = rez.First().ID;
                            LoginState.nume = rez.First().Nume;
                            LoginState.prenume= rez.First().Prenume;
                            LoginState.username= rez.First().Username;
                            LoginState.isAdmin=rez.First().IsAdmin;

                            MainWindow m = new MainWindow(this);
                            m.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Date incorecte!");
                    }
                }
                
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            LoginState.IsLoggedIn = true;
            LoginState.id = -1;
            LoginState.nume = null; 
            LoginState.username = null;
            LoginState.username = null;
            LoginState.isAdmin = false;

            MainWindow m = new MainWindow(this);
            m.Show();
            this.Hide();
        }
    }
}
