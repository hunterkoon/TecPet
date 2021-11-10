using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecPet.Entitys;
using TecPet.Model;
using TecPet.Repository;
using static TecPet.Model.Modelo;

namespace TecPet
{

    public partial class ListaPets : Form
    {
        BaseConection.Repository repository = new BaseConection.Repository();

        public ListaPets()
        {
            InitializeComponent();

        }


        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            tabelaPets();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {


        }


        public void tabelaMeusPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        public string redesenhar(string nome)
        {
            return welcomeLabel.Text = $"Olá, {nome}";

        }

        public void tabelaPets()
        {

            try
            {
                tabelaMeusPets.Rows.Clear();
                var dados = repository.GetPets();
                for (int i = 0; i < dados.Count(); i++)
                {
                    if (dados[i].Imagem != null)    
                    {
                        MemoryStream mstream = new MemoryStream(dados[i].Imagem);
                        tabelaMeusPets.Rows.Add(dados[i].Id, dados[i].Nome, dados[i].Raca, dados[i].Idade, dados[i].Peso);
                        imagemColumn.Image = Image.FromStream(mstream);


                    }
                    else
                        tabelaMeusPets.Rows.Add(dados[i].Id, dados[i].Nome, dados[i].Raca, dados[i].Idade, dados[i].Peso);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void cadastrarPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPet cadPet = new CadastroPet();
            cadPet.Show();

        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadUser = new CadastroUsuario();
            cadUser.Show();
        }
    }
}
