using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DVD : Disco
    {
        
        public DVD(string _tipo)
        {
            if (_tipo == "Simple Capa")
            {
                base._precio = "u$s 5";
                base._capacidad = "4.7 GB";
                base._tipo = _tipo;
            }
            else
            {
                base._precio = "u$s 8";
                base._capacidad = "8.5 GB";
                base._tipo = _tipo;
            }
            base._nombre = "DVD";
        }
        
    }
}
