using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Model;

namespace TecPet.Entitys
{

    class Acionamento : Controle
    {

      
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
            if (VerificaAciona() == false)
            {
                Motor = true;
                return "Não há ração suficiente para esta operação";

            }

            else
            {
                Motor = false;
                return $"Operação realizada com sucesso, peso restante { PesoAual - PesoDesejado }";
            }

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
