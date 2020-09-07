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
            Console.WriteLine("             Bienvenid@");
            Console.WriteLine("     _Calcule Sus Pulsaciones_");
            Console.WriteLine(" Se necesita que ingrese dos Datos: ");
            Console.WriteLine("#1 Edad: ");
            p.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("#2 Sexo: ");
            p.sexo = Convert.ToChar(Console.ReadLine());

            if (p.sexo.Equals('f'))
            {
                Console.WriteLine("Su Pulsacion Cada 10 segundos es: " + (220 - p.edad) / 10);
            }
            else
            {
               Console.WriteLine ("Su Pulsacion cada 10 segundo es: " + (210 - p.edad) / 10);
            }

            Console.ReadLine();



        }

    }
}
