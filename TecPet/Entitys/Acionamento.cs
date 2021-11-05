using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Model;
using static TecPet.Model.Modelo;

namespace TecPet.Entitys
{


    class Acionamento : DispositivoModel
    {


        public bool VerificaAciona()
        {
            if (NivelReservatorio < 1)
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
                return $"Operação realizada com sucesso, peso restante { NivelReservatorio - Consumo }";
            }

        }

        public string Parada()
        {
            if (NivelReservatorio == 0)
                return "Abasteça o reservatorio";

            else
                return $"Reservatório com { NivelReservatorio} %";

        }


    }
}
