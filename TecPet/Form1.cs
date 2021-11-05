using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecPet.Model;
using TecPet.Repository;
using static TecPet.Model.Modelo;

namespace TecPet
{
    public partial class Form1 : Form
    {
        BaseConection.Repository repository = new BaseConection.Repository();
        List<AnimalModel> Animais = new List<AnimalModel>();

        public Form1()
        {
            InitializeComponent();
            Animais = repository.GetRacas();

            try
            {
                foreach (var param in Animais)
                {
                    comboBoxRacas.Items.Add(param.Raca);
                }

            }
            catch (Exception ex)
            {
                erroMenssagem.Text = ex.ToString();
            }
      

        }

        private void comboBoxRacas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                repository.PostPet(NomePetTextBox.Text.ToString(),
                    comboBoxRacas.SelectedItem.ToString(),
                    Convert.ToInt32(IdadePetTextBox.Text),
                    Convert.ToInt32(PesoPetTextBox.Text));

            }
            catch (Exception ex)
            {
                erroMenssagem.Text = ex.ToString();
            }

        }





        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var dados = repository.GetDadosAnimal();

        //    for (int i = 0; i < dados.Count(); i++)
        //    {
        //        dataGridView1.Rows.Add(dados[i].Nome, dados[i].Idade);

        //    }
        //}
    }
}
