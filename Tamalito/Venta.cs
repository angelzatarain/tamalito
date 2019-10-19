using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamalito
{
    class Venta
    {
        public Int32 numPed { set; get; }
        public Int32 numProd { set; get; }
        public DateTime fechaPed { set; get; }
        public Int32 ganancia { set; get; }

        public Venta()
        {

        }
        public String toString()
        {
            return "" + numPed + "\t" + numProd + "\t" + fechaPed + "\t" + ganancia;
        }
    }
}
