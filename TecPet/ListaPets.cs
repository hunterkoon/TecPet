using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
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
        List<AnimalModel> Animais = new List<AnimalModel>();
        AnimalModel SelectedAnimal = new AnimalModel();
        UsuarioModel usuario = new UsuarioModel();

        public ListaPets()
        {
            InitializeComponent();


            try
            {
                Animais = repository.GetPets();
                for (int i = 0; i < Animais.Count(); i++)
                {

                    tabelaMeusPets.Rows.Add(Animais[i].Id, Animais[i].Nome, Animais[i].Raca, Animais[i].Idade, Animais[i].Peso, Animais[i].Imagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                tabelaMeusPets.Rows.Clear();
                Animais = repository.GetPets();
                for (int i = 0; i < Animais.Count(); i++)
                {
                    tabelaMeusPets.Rows.Add(Animais[i].Id, Animais[i].Nome, Animais[i].Raca, Animais[i].Idade, Animais[i].Peso);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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

        private void cadastrarPetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public string redesenhar(string nome)
        {
            return welcomeLabel.Text = $"Olá, {nome}";

        }

    }
}
