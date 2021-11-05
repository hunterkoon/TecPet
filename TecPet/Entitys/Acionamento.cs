using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecPet.Entitys
{
    class Acionamento
    {

        public double PesoDesejado { get; set; }
        public double PesoAual { get; set; }

        public Acionamento(double pesoDesejado, Reservatorio reservatorio)
        {
            PesoDesejado = pesoDesejado;
            PesoAual = reservatorio.Nivel;
        }

        public double ConsultarAcionamento()
        {
            return PesoAual;
        }

        public bool VerificaAciona()
        {
            if (PesoDesejado < PesoAual)
                return false;

            else
                return true;

        }

        public string Aciona()
        {
            if(VerificaAciona() == false)            
                return "Não há ração suficiente para esta operação";    
            
            else            
                return $"Operação realizada com sucesso, peso restante { PesoAual - PesoDesejado }";            
             
        }

        public string Parada()
        {
            if (PesoAual == 0)
                return "Abasteça o reservatorio";

            else
                return $"Reservatório com { PesoAual} gramas";

        }





    }
}
