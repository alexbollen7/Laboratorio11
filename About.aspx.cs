﻿using Newtonsoft.Json;
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
            Archivo archivo = new Archivo();
            List<Universidad> universidades = new List<Universidad>();
            universidades = archivo.Leer();

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

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            List<Universidad> universidades = new List<Universidad>();
            universidades = archivo.Leer();
            Universidad universidad = universidades.Find(a => a.NombreUniversiad == LabelUniversidad.Text);
            universidades.Remove(universidad);
            Response.Write("<script>alert('Universidad eliminada')</script>");
            archivo.Grabar(universidades);
        }
    }
}