using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace DAL
{
    internal class metodos_datos
    {
        public static DataSet execute_DataSet(string query)
        {
            //instanciamos un DS (DataSet) => Objeto de ADO
            DataSet ds = new DataSet();
            //obtenemos la cadena de conexión desde la clase configuración
            string cadenaConexion = Configuracion.CadenaConexion;
            //crear una conexión => SqlConnection Objeto de ADO 
            OracleConnection con = new OracleConnection(cadenaConexion);
            try
            {
                //verificamos si la conexión está abierta
                if (con.State == ConnectionState.Open)
                {
                    //cerramos la conexión
                    con.Close();
                }
                else
                {
                    //Comando para SQL(sp, conexión) => SqlCommand Objeto de ADO
                    OracleCommand cmd = new OracleCommand(query, con);
                    //definimo que el comando será ejecutado como un SP (Stored Proedure)
                    cmd.CommandType = CommandType.Text;
                    //pasamos el SP
                    cmd.CommandText = query;

                    //Abrimos la conexión
                    con.Open();
                    //ejecutamos el comando
                    //SqlDataAdapter => Objeto de ADO
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    //llenamos el ds
                    adapter.Fill(ds);
                    //cerramos la conexión
                    con.Close();
                }
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                //verificamos si la conexión está abierta
                if (con.State == ConnectionState.Open)
                {
                    //Cerramos la conexión
                    con.Close();
                }
            }
        }
    }
}
