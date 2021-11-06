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
using static TecPet.Model.Modelo;

namespace TecPet
{
       
    public partial class ListaPets : Form
    {


        BaseConection.Repository repository = new BaseConection.Repository();
        List<AnimalModel> Animais = new List<AnimalModel>();
        AnimalModel SelectedAnimal = new AnimalModel();

        public ListaPets()
        {

            InitializeComponent();
            try
            {
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


        public void tabelaMeusPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedAnimal.Id = Convert.ToInt32( tabelaMeusPets.Rows[e.RowIndex].Cells[0].Value);
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
            if (!SelectedAnimal.Id.Equals(null))
            {
                repository.DeletePet(SelectedAnimal.Id);
                MessageBox.Show("Pet Deletado");
            }
            else
                MessageBox.Show("Clique na Linha duas Vezes");

        }
    }
}
