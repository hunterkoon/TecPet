using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Model;
using static TecPet.Model.Modelo;

namespace TecPet.Entitys
{
    class Relatorio : RelatorioModel 
    {
        public override string ToString()
        {

            return $"Motor:  {Motor} " +
                $"Agendamento {DiaSemana}" +
                $"Nivel Reservatorio {NivelReservatorio}" +
                $"Nivel Recipiente {NivelRecipiente}";
        }

    }
}
