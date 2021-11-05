using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Entitys;

namespace TecPet.Model
{
    public class Modelo
    {
        public class Dispositivo
        {
            public DateTime Agendamento { get; set; }
            public bool? Motor { get; set; }
            public string Relatorio { get; set; }
            public double QtdDepositada { get; set; }
            public double QtdConsumida { get; set; }
            public int NivelReservatorio { get; set; }
            public int NivelRecipiente { get; set; }
        }
        public class Animal
        {
            public int Id { get; set; }
            public string NomePet { get; set; }
            public string Raca { get; set; }
            public int Idade { get; set; }
            public double Peso { get; set; }
        }

    }

}
