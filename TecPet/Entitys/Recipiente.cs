using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecPet.Entitys
{
    public class Recipiente
    {
        public double Peso { get; set; }

        public Recipiente(double peso)
        {
            Peso = peso;
        }

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
