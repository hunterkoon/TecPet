using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Entitys;

namespace TecPet.Model
{

    public class Modelo 
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
            public byte[] Imagem { get; set; }
            public string TipoPet { get;set; }

        }

        public class AgendaModel
        {
            public int Id { get; set; }
            public DateTime Data { get; set; }
            public DateTime Horario { get; set; }
            public double QuantidadeRacao { get; set; }
            public bool? Umida { get; set; }

        }
        public class RelatorioModel : DispositivoModel
        {
            public int Id { get; set; }
            public DateTime DiaSemana { get; set; }
        }


    }

}
