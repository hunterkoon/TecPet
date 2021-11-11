using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
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

            string selectedDate = agendaCalendar.SelectionStart.Date.ToString("dd/MM/yyyy");

            DateTime dt = DateTime.ParseExact(selectedDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            agendaModel.Data = dt;

            if (radioUmidaBtn.Checked == true)
            {
                agendaModel.Umida = true;
            }
            else
            {
                agendaModel.Umida = false;
            }


            repository.AgendarData(agendaModel);

            AtualizaAgenda();


        }



        public void AtualizaAgenda()
        {
            var agendamentos = repository.GetAgendamentos();
            tabelaAgenda.Rows.Clear();

            for (int i = 0; i < agendamentos.Count; i++)
            {

                tabelaAgenda.Rows.Add(
                    agendamentos[i].Data,
                    agendamentos[i].Horario,
                    agendamentos[i].QuantidadeRacao,
                    agendamentos[i].Umida
                    );
            }

        }

    }




}
