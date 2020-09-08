using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulsaciones
{
    class Pulsacion
    {

        public void CalculaPulso()
        {

            Persona p = new Persona();
            Console.WriteLine("\t\t            Bienvenid@\n\n");
            Console.WriteLine("\t\t     _Calcule Sus Pulsaciones_\n");
            Console.WriteLine("\t\t Se necesita que ingrese dos Datos: ");
            Console.WriteLine("\n #1 Edad: ");
            p.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\t\t Oprima la Tecla [_F_] Femenino ");
            Console.WriteLine("\n\t\t Oprima la Tecla [_M_] Masculino");
            Console.WriteLine("\n #2 Sexo: ");
            p.sexo = Convert.ToChar(Console.ReadLine());

            mensaje(p.edad, p.sexo);

            Console.ReadLine();

        }

        private void mensaje(int edad, char sexo) {

            if (sexo.Equals('f'))
            {
                Console.WriteLine("\nSu Pulsacion Cada 10 segundos son: " + (220 - edad) / 10);
            }
            else
            {
                Console.WriteLine("Su Pulsacion cada 10 segundos son: " + (210 - edad) / 10);
            }

        }

    }
}
