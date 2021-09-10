using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
   public class BluRay : Disco
    {


        public BluRay(string _tipo)
        {
            if (_tipo == "Simple Capa")
            {
                base._precio = "u$s 20";
                base._capacidad = "25 GB";
                base._tipo = _tipo;
            }
            else
            {
                base._precio = "u$s 40";
                base._capacidad = "50 GB";
                base._tipo = _tipo;
            }
            base._nombre = "BluRay";
        }
    }
}
