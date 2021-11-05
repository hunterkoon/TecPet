using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Entitys;

namespace TecPet.Model
{
    public class Error
    {
        public string ErroMenssagem { get; set; }
    }
    public class Modelo : Error
    {
    
        public class DispositivoModel 
        {

            public bool? Motor { get; set; }
            public double Deposito { get; set; }
            public double Consumo { get; set; }
            public int NivelReservatorio { get; set; }
            public int NivelRecipiente { get; set; }
        }
        public class AnimalModel
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Raca { get; set; }
            public int Idade { get; set; }
            public double Peso { get; set; }

        }

        public class AgendaModel
        {
            public int Id { get; set; }
            public DateTime DiaSemana { get; set; }
            public DateTime Horario { get; set; }
            public double QuantidadeRacao { get; set; }

        }
        public class RelatorioModel : DispositivoModel
        {
            public int Id { get; set; }
            public DateTime DiaSemana { get; set; }
        }


    }

}
