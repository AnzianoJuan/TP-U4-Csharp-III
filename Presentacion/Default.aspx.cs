using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Presentacion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ListaDirecciones"] == null)
            {
                DireccionNegocio negocio = new DireccionNegocio();
                Session.Add("ListaDirecciones", negocio.listar());
            }

            DataGridViewDireccion.DataSource = Session["ListaAutos"];
            DataGridViewDireccion.DataBind();
        }
    }
}