using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio11
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Universidad> universidades = Leer();

            Universidad universidad = universidades.Find(a => a.NombreUniversiad == TextBoxNombreUni.Text);

            if (universidad != null)
            {
                Response.Write("<script>alert('Universidad encontrada')</script>");
                LabelUniversidad.Text = universidad.NombreUniversiad;
                Button2.Enabled = true;
            }
            else
                Response.Write("<script>alert('Universidad no existe')</script>");
        }

        private List<Universidad> Leer()
        {
            List<Universidad> lista = new List<Universidad>();
            string archivo = Server.MapPath("Datos.json");
            StreamReader jsonStream = File.OpenText(archivo);

            string json = jsonStream.ReadToEnd();

            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Universidad>>(json);
            return lista;
        }

        private void Grabar(List<Universidad> universidades)
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Datos.json");

            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<Universidad> universidades = Leer();
            Universidad universidad = universidades.Find(a => a.NombreUniversiad == LabelUniversidad.Text);
            universidades.Remove(universidad);
        }
    }
}