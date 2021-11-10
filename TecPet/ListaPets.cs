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
        AnimalModel animal = new AnimalModel();


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
            if (animal.Id != 0)
            {
                repository.DeletePet(animal.Id);
                MessageBox.Show("Pet Deletado");
            }
            else
                MessageBox.Show("Selecione um Pet para deletar");
        }


        public void tabelaMeusPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (tabelaMeusPets.SelectedCells.Count > 0)
            {
                int selectedRowIndex = tabelaMeusPets.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tabelaMeusPets.Rows[selectedRowIndex];
                int cellValue = Convert.ToInt32(selectedRow.Cells["IdPet"].Value);

                animal.Id = cellValue;

            }
            else
                MessageBox.Show("Não selecionado");


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
                        // blob to byte
                        byte[] imageBytes = dados[i].Imagem;
                        MemoryStream buf = new MemoryStream(imageBytes);

                        // to image 
                        Image image = Image.FromStream(buf, true);

                        // rotate image
                        image.RotateFlip(RotateFlipType.Rotate90FlipX);

                        //popular lista
                        tabelaMeusPets.Rows.Add(dados[i].Id, dados[i].Nome, dados[i].Raca, dados[i].Idade, dados[i].Peso, dados[i].TipoPet,image);
                        imagemColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                        tabelaMeusPets.Rows[i].Height = 100;                       

                    }
                    else
                        tabelaMeusPets.Rows.Add(dados[i].Id, dados[i].Nome, dados[i].Raca, dados[i].Idade, dados[i].Peso, dados[i].TipoPet);


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
