using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecPet.Entitys
{
    class Reservatorio 
    {
        public int Nivel { get; set; }

        public Reservatorio(int nivel)
        {
            nivel = 100;
            Nivel = nivel;
        }

        public int ConsultarNivel()
        {
            return Nivel;

        } 
        
        public int EditarNivel(int subAdd)
        {
            if(subAdd < 0)
            {
                return Nivel - subAdd;
            }
            else
            {
                return Nivel + subAdd;
            }
            

        }
    }
}
