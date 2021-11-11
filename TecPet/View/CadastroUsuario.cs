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
    public partial class CadastroUsuario : Form
    {
        BaseConection.Repository repository = new BaseConection.Repository();
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void cadastrarUsuarioBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomeCadastroTextBox.Text != "" && usuarioCadastroTextBox.Text != "" && senhaCadastroTextBox.Text != "")
                {
                    repository.CadastrarLogin(nomeCadastroTextBox.Text, usuarioCadastroTextBox.Text, senhaCadastroTextBox.Text);

                    nomeCadastroTextBox.Text = "";
                    usuarioCadastroTextBox.Text = "";
                    senhaCadastroTextBox.Text = "";

                    MessageBox.Show("Usuario Cadastrado Com Sucesso");
                    ActiveForm.Close();
                }


                else
                    MessageBox.Show("Preencha todos os campos");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void fecharCadastroBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
