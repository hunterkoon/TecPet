using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Model;
using static TecPet.Model.Modelo;

namespace TecPet.Entitys
{
    public class Recipiente : Dispositivo
    {
   
        public double ConsultarRecipiente()
        {
            return NivelRecipiente;
        }

        public double EditarRecipiente(double subAdd)
        {
            if (subAdd < 0)
            {
                return NivelRecipiente - subAdd;
            }
            else
            {
                return NivelRecipiente + subAdd;
            }
        }
    }


}
