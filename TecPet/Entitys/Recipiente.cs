using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Model;

namespace TecPet.Entitys
{
    public class Recipiente : Controle
    {
   
        public double ConsultarRecipiente()
        {
            return Peso;
        }

        public double EditarRecipiente(double subAdd)
        {
            if (subAdd < 0)
            {
                return Peso - subAdd;
            }
            else
            {
                return Peso + subAdd;
            }
        }
    }


}
