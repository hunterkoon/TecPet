using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Model;

namespace TecPet.Entitys
{
    class Reservatorio : Controle
    {
      
        private  Reservatorio()
        {
            var pesoInt = Convert.ToInt32(Math.Floor(PesoAual));            
            NivelReservatorio = pesoInt / 100;
        }

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
