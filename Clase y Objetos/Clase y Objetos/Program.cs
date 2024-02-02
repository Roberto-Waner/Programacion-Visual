using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_y_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; //creacion de objeto de tipo circulo. Variable/objeto de tipo circulo
            miCirculo = new Circulo(); //Inicializacion de variable/objeto de tipo circulo. Instanciar una clase
            //instanciacion. Ejemplarizacion. Creacion de ejemplar de clase

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.calculoArea(10));

            Console.ReadKey();
        }
    }

    class Circulo
    {
        private const double pi = 3.1416; //propiedad de la clase Circulo. campos de clases
        
        public double calculoArea(int radio) //metodo de clase. Que pueden hacer los objetos de tipo circulo?
        {
            return pi * radio * radio;
        }
    }
}
