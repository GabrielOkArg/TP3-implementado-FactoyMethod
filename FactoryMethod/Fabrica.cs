using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Fabrica
    {
        public abstract Disco Creardisco(string _tipo);
        //public abstract Disco Creardisco(string _nombre, string _tipo, string _capacidad, string precio);
    }
}
