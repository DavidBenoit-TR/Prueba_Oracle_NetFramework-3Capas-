using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class Dal_Cliente
    {
        public static List<Cliente_VO> GetCLientes()
        {
            List<Cliente_VO> list = new List<Cliente_VO>();
            try
            {
                DataSet ds = metodos_datos.execute_DataSet("SELECT * FROM Cliente");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    list.Add(new Cliente_VO(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}