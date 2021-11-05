using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Model;
using static TecPet.Model.Modelo;

namespace TecPet.Entitys
{
    class Relatorio : Dispositivo
    {
        public override string ToString()
        {
            return $"Motor:  { Motor} " +
                $"Agendamento {Agendamento}" +
                $"Nivel Reservatorio {NivelReservatorio}" +
                $"Nivel Recipiente {NivelRecipiente}";
        }

    }
}
