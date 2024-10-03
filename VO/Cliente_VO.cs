using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Cliente_VO
    {
        private int _CLIENTE_ID;
        private string _NOMBRE;
        private string _CLAVE;
        private string _MAIL;
        private string _ESTATUS;

        public int CLIENTE_ID { get => _CLIENTE_ID; set => _CLIENTE_ID = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string CLAVE { get => _CLAVE; set => _CLAVE = value; }
        public string MAIL { get => _MAIL; set => _MAIL = value; }
        public string ESTATUS { get => _ESTATUS; set => _ESTATUS = value; }

        public Cliente_VO()
        {
            _CLIENTE_ID = 0;
            _NOMBRE = "";
            _CLAVE = "";
            _MAIL = "";
            _ESTATUS = "";
        }

        public Cliente_VO(DataRow dr)
        {
            _CLIENTE_ID = int.Parse(dr["CLIENTE_ID"].ToString());
            _NOMBRE = dr["NOMBRE"].ToString();
            _CLAVE = dr["CLAVE"].ToString();
            _MAIL = dr["MAIL"].ToString();
            _ESTATUS = dr["ESTATUS"].ToString();
        }
    }
}
