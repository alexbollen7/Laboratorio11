using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio11
{
    public partial class Actualiza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            List<Universidad> universidades = new List<Universidad>();
            universidades = archivo.Leer();

            Universidad universidad = universidades.Find(a => a.NombreUniversiad == TextBoxNombreUniversidad.Text);

            if (universidad != null)
            {
                Response.Write("<script>alert('Universidad encontrada')</script>");
                LabelUniversidad.Text = universidad.NombreUniversiad;
                ButtonActualizar.Enabled = true;
            }
            else
                Response.Write("<script>alert('Universidad no existe')</script>");
        }

        protected void ButtonActualizar_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            List<Universidad> universidades = new List<Universidad>();
            universidades = archivo.Leer();
            Universidad universidad = universidades.Find(a => a.NombreUniversiad == LabelUniversidad.Text);
            universidad.NombreUniversiad = TextBoxNuevoNombre.Text;
            Response.Write("<script>alert('Nombre de universidad actualizada')</script>");
            archivo.Grabar(universidades);
        }
    }
}