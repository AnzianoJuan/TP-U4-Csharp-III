using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class DireccionForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());

                List<Direccion> temporal = (List<Direccion>)Session["ListaDireccion"];
                Direccion seleccionado = temporal.Find(x => x.Id == id);

                TextBoxCalle.Text = seleccionado.Calle;
                TextBoxId.Text = seleccionado.Id.ToString();
                TextBoxAltura.Text = seleccionado.Altura.ToString();
                TextBoxId.ReadOnly = true;
                ButtonAgregarDireccion.Enabled = false;
            }
            else if (Request.QueryString["id"] == null)
            {
                ButtonModificarDireccion.Enabled = false;
            }
        }

        protected void ButtonAgregarDireccion_Click(object sender, EventArgs e)
        {
            Direccion direccion = new Direccion();

            direccion.Id = int.Parse(TextBoxId.Text);
            direccion.Calle = TextBoxCalle.Text;
            direccion.Altura = int.Parse(TextBoxAltura.Text);

            ((List<Direccion>)Session["ListaDireccion"]).Add(direccion);

            Response.Redirect("Default.aspx");

        }

        protected void ButtonModificarAuto_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxId.Text);

            // Obtener la lista de direcciones de la sesión
            List<Direccion> temporal = (List<Direccion>)Session["ListaDireccion"];

            // Encontrar la dirección a modificar
            Direccion seleccionado = temporal.Find(x => x.Id == id);

            if (seleccionado != null)
            {
                // Actualizar los valores de la dirección
                seleccionado.Calle = TextBoxCalle.Text;
                seleccionado.Altura = int.Parse(TextBoxAltura.Text);

                // Guardar la lista actualizada en la sesión
                Session["ListaDireccion"] = temporal;

                // Redirigir a la página principal
                Response.Redirect("Default.aspx");
            }
          
        }
    }
}