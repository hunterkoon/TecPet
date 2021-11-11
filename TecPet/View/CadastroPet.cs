using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecPet.Model;
using TecPet.Repository;
using static TecPet.Model.Modelo;

namespace TecPet
{
    public partial class CadastroPet : Form
    {
        BaseConection.Repository repository = new BaseConection.Repository();
        List<AnimalModel> Animais = new List<AnimalModel>();

        public CadastroPet()
        {
            InitializeComponent();


            try
            {
                Animais = repository.GetRacas();
                foreach (var param in Animais)
                {
                    comboBoxRacas.Items.Add(param.Raca);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void comboBoxRacas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // SALVAR IMAGEM DENTRO DE UM ARRAY BYTES

                if (picturePetBox.ImageLocation == null)
                {
                    throw new Exception("Selecione uma imagem");
                }
                if (NomePetTextBox.Text == "")
                {
                    throw new Exception("Dê um nome para seu Pet");
                }
                if (IdadePetTextBox.Text == "")
                {
                    throw new Exception("Digite a idade de seu Pet");
                }
                if (PesoPetTextBox.Text == "")
                {
                    throw new Exception("Digite o peso de seu Pet");
                }
                if (tipoPetCbx.SelectedItem == null)
                {
                    throw new Exception("Selecione o Tipo do seu Pet");
                }
                if (comboBoxRacas.SelectedItem == null)
                {
                    throw new Exception("Selecione a raça de seu Pet");
                }


                byte[] imageByte = null;
                FileStream fstream = new FileStream(picturePetBox.ImageLocation.ToString(), FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageByte = br.ReadBytes((int)fstream.Length);

                // ALIMENTAR MODEL 

                AnimalModel animal = new AnimalModel()
                {
                    Nome = NomePetTextBox.Text,
                    Peso = Convert.ToInt32(PesoPetTextBox.Text),
                    Idade = Convert.ToInt32(IdadePetTextBox.Text),
                    TipoPet = tipoPetCbx.Text,
                    Raca = comboBoxRacas.SelectedItem.ToString(),
                    Imagem = imageByte
                };

                // GRAVAR NO BANCO DE DADOS

                repository.PostPet(animal);

                MessageBox.Show("Animal Cadastado");

                // Atualiza a Lista e limpa os campos

                LimparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaPets new_Form = new ListaPets();
            new_Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void inserirFotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)| *.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                picturePetBox.ImageLocation = foto;

            }

        }

        private void LimparCampos()
        {

            NomePetTextBox.Text = "";
            IdadePetTextBox.Text = "";
            PesoPetTextBox.Text = "";
            IdadePetTextBox.Text = "";
            comboBoxRacas.Text = "";
            tipoPetCbx.Text = "";
            picturePetBox.ImageLocation = null;
        }

        private void girarDirBtn_Click(object sender, EventArgs e)
        {

            picturePetBox.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
            picturePetBox.Refresh();
        }
    }
}
