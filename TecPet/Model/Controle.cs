using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Entitys;

namespace TecPet.Model
{
    public class Controle 
    {

        public DateTime Agendamento { get; set; }
        public bool? Motor { get; set; }
        public float NivelRecipiente { get; set; }
        public string Relatorio { get; set; }
        public double Peso { get; set; }
        public string DadosRelatorio { get; set; }
        public double QtdDepositada { get; set; }
        public double QtdConsumida { get; set; }
        public int NivelReservatorio { get; set; }
        public double PesoDesejado { get; set; }
        public double PesoAual { get; set; }


    }
}
