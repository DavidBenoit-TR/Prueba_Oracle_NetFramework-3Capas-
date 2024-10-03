using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba_Oracle_NetFramework.Catálogos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cargar_Grid();
            }
        }

        protected void Cargar_Grid()
        {
            GVClientes.DataSource = BLL_Cliente.GetCLientes();
            GVClientes.DataBind();
        }
    }
}