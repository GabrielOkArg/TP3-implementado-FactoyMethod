using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Disco
    {
        protected string _nombre;
        protected string _capacidad;
        protected string _precio;
        protected string _tipo;

        public void Render()
        {
            Console.WriteLine(String.Format("Disco: {0} tipo: {1} capacidad: {2} precio: {3}", _nombre, _tipo, _capacidad, _precio));
        }
    }
}
