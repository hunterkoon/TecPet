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
                int selectedRowIndex = tabelaMeusPets.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tabelaMeusPets.Rows[selectedRowIndex];
                int cellValue = Convert.ToInt32(selectedRow.Cells["IdPet"].Value);
                animal.Id = cellValue;
            }
            else
                MessageBox.Show("Não selecionado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {


        }


            try
            {
                tabelaMeusPets.Rows.Clear();
                var dados = repository.GetPets();
                for (int i = 0; i < dados.Count(); i++)
                {
                    if (dados[i].Imagem != null)
                    {
                        // blob to byte
                        byte[] imageBytes = dados[i].Imagem;
                        MemoryStream buf = new MemoryStream(imageBytes);

                        // converter para imagem
                        Image image = Image.FromStream(buf, true);

                        // rotacionar  imagem
                        image.RotateFlip(RotateFlipType.Rotate90FlipX);


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
