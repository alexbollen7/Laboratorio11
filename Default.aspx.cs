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
    public partial class _Default : Page
    {
        List<Universidad> universidades = new List<Universidad>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Leer();
        }

        protected void ButtonRegistroAlumno_Click(object sender, EventArgs e)
        {

            if (universidades == null)
            {
                universidades = new List<Universidad>();
            }
            else
            {
                Universidad universidadExiste = universidades.Find(u => u.NombreUniversiad == DropDownList1.SelectedValue);

                if (universidadExiste == null)
                {
                    Universidad universidadNueva = new Universidad();

                    universidadNueva.NombreUniversiad = DropDownList1.SelectedValue;

                    Alumno alumnoNuevo = new Alumno();
                    alumnoNuevo.Nombre = TextBoxNombreAlumno.Text;
                    alumnoNuevo.Carne = TextBoxCarne.Text;
                    alumnoNuevo.FechaNacimiento = TextBoxFechaNacimiento.Text;
                    alumnoNuevo.Direccion = TextBoxDireccion.Text;

                    Curso cursoNuevo = new Curso();
                    cursoNuevo.NombreCurso = TextBoxNombreCurso.Text;
                    cursoNuevo.Nota = Convert.ToInt32(TextBoxNota.Text);

                    alumnoNuevo.Cursos.Add(cursoNuevo);

                    universidadNueva.Alumnos.Add(alumnoNuevo);

                    universidades.Add(universidadNueva);
                }
            }

            Grabar();

        }

        private void Leer()
        {
            List<Universidad> lista = new List<Universidad>();
            string archivo = Server.MapPath("Datos.json");
            StreamReader jsonStream = File.OpenText(archivo);

            string json = jsonStream.ReadToEnd();

            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Universidad>>(json);
            if (lista != null)
                universidades = lista.ToList();
        }

        private void Grabar()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Datos.json");

            System.IO.File.WriteAllText(archivo, json);
        }
    }
}