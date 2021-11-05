using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Model;
using static TecPet.Model.Modelo;

namespace TecPet.Entitys
{
    class Reservatorio : DispositivoModel
    {

        public int ConsultarNivel()
        {
            return NivelReservatorio;

        } 
        
        public int EditarNivel(int subAdd)
        {
            if(subAdd < 0)
            {
                return NivelReservatorio - subAdd;
            }
            else
            {
                return NivelReservatorio + subAdd;
            }
            

        }
    }
}
