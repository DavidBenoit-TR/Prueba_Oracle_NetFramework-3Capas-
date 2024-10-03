using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace BLL
{
    public class BLL_Cliente
    {
        public static List<Cliente_VO> GetCLientes()
        {
            return Dal_Cliente.GetCLientes();
        }
    }
}
