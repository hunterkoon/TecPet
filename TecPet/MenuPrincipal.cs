using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecPet.Repository;

namespace TecPet
{
    public partial class MenuPrincipal : Form
    {
        ListaPets lstPets = new ListaPets();
        BaseConection.Repository repository = new BaseConection.Repository();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastarNovoPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();

        }

        private void primeiroAcesso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroUsuario cadUser = new CadastroUsuario();
            cadUser.Show();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginUsuarioTxtBox.Text != "" && loginSenhaTxtBox.Text != "")
                {
                    var login = repository.Login(loginUsuarioTxtBox.Text, loginSenhaTxtBox.Text);
                   
                    if (login != null)
                    {
                        lstPets.Show();
                        lstPets.redesenhar(login.Nome);

                    }
                    else
                        MessageBox.Show("Usuário e/ou senha incorretos");

                }
                else
                    MessageBox.Show("Preencha todos os campos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
