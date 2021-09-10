using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FabricaDvd : Fabrica
    {
        public override Disco Creardisco( string _tipo)
        {
           
                switch (_tipo)
                {
                    case "Simple Capa":
                        return new DVD(_tipo);
                        break;
                    case "Doble Capa":
                        return new DVD(_tipo);
                        break;
                    default:
                        break;
                }

               
            
            return null;
        }
    }
}
