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
            if (!IsPostBack)
            {
                if (Session["ListaDireccion"] == null)
                {
                    DireccionNegocio negocio = new DireccionNegocio();
                    Session.Add("ListaDireccion", negocio.listar());
                }

                // Verifica que la lista no sea null antes de enlazarla
                if (Session["ListaDireccion"] != null)
                {
                    GridViewDireccion.DataSource = Session["ListaDireccion"];
                    GridViewDireccion.DataBind();
                }
            }
        }
        protected void GridViewDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GridViewDireccion.SelectedDataKey.Value.ToString();
            Response.Redirect("DireccionForm.aspx?id=" + id);
        }
    }
}