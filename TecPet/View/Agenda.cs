using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecPet.Repository;
using static TecPet.Model.Modelo;

namespace TecPet.View
{
    public partial class Agenda : Form
    {
        AgendaModel agendaModel = new AgendaModel();

        BaseConection.Repository repository = new BaseConection.Repository();

        public Agenda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gravarBtn_Click(object sender, EventArgs e)
        {

            try
            {

                agendaModel.Data = agendaCalendar.SelectionStart.Date;

                if (radioUmidaBtn.Checked == true)
                {
                    agendaModel.Umida = true;
                }
                else
                {
                    agendaModel.Umida = false;
                }

                if (quantidadeTextBox.Text == "")
                {
                    throw new Exception("Digite um valor em gramas");
                }
                else
                {
                    agendaModel.QuantidadeRacao = double.Parse(quantidadeTextBox.Text);
                }


                if (horaTextBox.Text != "" && minTextBox.Text != "")
                {
                    DateTime HoraMinuto = DateTime.ParseExact($"{horaTextBox.Text}:{minTextBox.Text}", "HH:mm", CultureInfo.InvariantCulture);
                    agendaModel.Horario = HoraMinuto;

                }
                else
                {
                    throw new Exception("Digite as horas para disparar o mecanismo");
                }

                repository.AgendarData(agendaModel);
                AtualizaAgenda();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public void AtualizaAgenda()
        {
            var agendamentos = repository.GetAgendamentos();
            tabelaAgenda.Rows.Clear();

            for (int i = 0; i < agendamentos.Count; i++)
            {

                tabelaAgenda.Rows.Add(
                    agendamentos[i].Data.ToString("dd/MM/yyyy"),
                    agendamentos[i].Horario.ToString("HH:mm:ss"),
                    agendamentos[i].QuantidadeRacao,
                    agendamentos[i].Umida
                    );
            }

        }

        private void quantidadeTextBox_TextChanged(object sender, EventArgs e)
        {

            Regex regex = new Regex(@"\D");
            string replaced = regex.Replace(quantidadeTextBox.Text , "");
            quantidadeTextBox.Text = replaced;
            

        }

        private void horaTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\D");
            string replaced = regex.Replace(horaTextBox.Text, "");
            horaTextBox.Text = replaced;

        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\D");
            string replaced = regex.Replace(minTextBox.Text, "");
            minTextBox.Text = replaced;

        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            repository.LimparAgenda();
            AtualizaAgenda();
        }
    }




}
