using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueva_2
{
    public abstract class OperadorBinario
    {
        protected int operando1;
        protected int operando2;

        public OperadorBinario(int operando1, int operando2) 
        {
            this.operando1 = operando1;
            this.operando2 = operando2;
        }

        public abstract double Operacion();
    }
}
