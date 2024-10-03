using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Configuracion
    {
        // Cambiamos la cadena de conexión para que apunte a Oracle
        static string _cadenaConexion = @"User Id=SYSTEM;
                                      Password=0r4cl3l1nux;
                                      Data Source=10.10.10.13:1521/xe";
        public static string CadenaConexion //Encapsulamiento
        {
            get { return _cadenaConexion; }
        }
    }

}
