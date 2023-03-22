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
    public partial class RegisterWindowTask : Form
    {
        private string adminKey = "@umfst2022@";
        Utilizator utilizator;
        public RegisterWindowTask(Utilizator utilizator)
        {
            InitializeComponent();
            this.utilizator = utilizator;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool verificareUsername()
        {
            using (UtilizatorDbContext ut = new UtilizatorDbContext())
            {
                var rez = from s in ut.Utilizatori
                          where s.Username.Equals(txtUsername.Text)
                          select new
                          {
                              s.Username
                          };
                try
                {
                    if (rez.First() != null)
                    {
                        //username existent
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text;
            string prenume = txtPrenume.Text;
            string username = txtUsername.Text;
            string parola = txtParola.Text;
            string parola2 = txtParola2.Text;

            if (nume.Length == 0 || prenume.Length == 0 || username.Length == 0
                || parola.Length == 0 || parola2.Length == 0)
                MessageBox.Show("Completati toate campurile!");
            else if(parola != parola2)
                MessageBox.Show("Parolele nu coincid!");
            else if(verificareUsername())
            {
                MessageBox.Show("Username-ul introdus exista deja");
                return;
            }
            else
            {
                if(txtKey.Text == adminKey)
                    utilizator.IsAdmin = true;
                else
                    utilizator.IsAdmin = false;

                utilizator.Nume = nume;
                utilizator.Prenume = prenume;
                utilizator.Username = username;
                utilizator.Password= parola2;
                this.Close();

                MessageBox.Show("Contul a fost creat cu succes!");
            }
        }
    }
}
