using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod;

namespace TP3_Silva_FactoryMethod
{
    static class fabricacion
    {

        public static void Main()
        {
            string _opcion ="";

            List<Disco> dvds = new List<Disco>();
            List<Disco> blurays = new List<Disco>();
            Fabrica fabrica;
            Disco disco;

            //inicio de programa con menu
            while (_opcion !="0")
            {
                Console.WriteLine("Fabricacion de DVD y BluRay");
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1 - Fabricar dvd simple capa");
                Console.WriteLine("2 - Fabricar dvd doble capa");
                Console.WriteLine("3 - Fabricar BluRay simple capa");
                Console.WriteLine("4 - Fabricar BluRay doble capa");
                Console.WriteLine("0 - terminar");
                _opcion = Console.ReadLine();
                switch (_opcion)
                {
                    case "1":
                        fabrica = new FabricaDvd();
                        disco = fabrica.Creardisco("Simple Capa");
                        dvds.Add(disco);
                        break;
                    case "2":
                        fabrica = new FabricaDvd();
                        disco = fabrica.Creardisco("Doble Capa");
                        dvds.Add(disco);
                        break;
                    case "3":
                        fabrica = new FabricaBluRay();
                        disco = fabrica.Creardisco("Simple Capa");
                        blurays.Add(disco);
                        break;
                    case "4":
                        fabrica = new FabricaBluRay();
                        disco = fabrica.Creardisco("Doble Capa");
                        blurays.Add(disco);
                        break;
                    default:
                        break;
                }
                Console.Clear();

            }
            Console.Clear();
            Console.WriteLine("Fabricacion de DVD total: " + dvds.Count.ToString());
            foreach (var item in dvds)
            {
                item.Render();
            }
            Console.WriteLine("Fabricacion de BluRay total: " + blurays.Count.ToString());
            foreach (var item in blurays)
            {
                item.Render();
            }
            // fin de programa con menu


            // sin menu para mostarar que crea los elementos

            //fabrica = new FabricaDvd();

            //disco = fabrica.Creardisco("Simple Capa");
            //disco.Render();
            //disco = fabrica.Creardisco("Doble Capa");
            //disco.Render();

            //fabrica = new FabricaBluRay();
            //disco = fabrica.Creardisco("Simple Capa");
            //disco.Render();
            //disco = fabrica.Creardisco("Doble Capa");
            //disco.Render();

            Console.ReadLine();
        }
    }
}
