using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueva_2
{
    public class Suma : OperadorBinario
    {
        public Suma(int operador1, int operador2) : base(operador1, operador2) { }
        public override double Operacion()
        {
            return operando1 + operando2;
        }
    }

    public class Resta : OperadorBinario
    {
        public Resta(int operador1, int operador2) : base(operador1, operador2) { }
        public override double Operacion()
        {
            return operando1 - operando2;
        }
    }

    public class Multiplicacion : OperadorBinario
    {
        public Multiplicacion(int operador1, int operador2) : base(operador1, operador2) { }
        public override double Operacion()
        {
            return operando1 * operando2;
        }
    }

    public class Division : OperadorBinario
    {
        public Division(int operador1, int operador2) : base(operador1, operador2) { }
        public override double Operacion()
        {
            return operando1 / operando2;
        }
    }

    public class Raiz : OperadorBinario
    {
        public Raiz(int operador1, int operador2) : base(operador1, operador2) { }
        public override double Operacion()
        {
            return Math.Sqrt(operando1 + operando2);
        }
    }

    public class Potencia : OperadorBinario
    {
        public Potencia(int operador1, int operador2) : base(operador1, operador2) { }
        public override double Operacion()
        {
            return Math.Pow(operando1, operando2);
        }
    }
}
