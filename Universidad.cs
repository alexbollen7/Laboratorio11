using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio11
{
    public class Universidad
    {
        string nombreUniversiad;
        List<Alumno> alumnos;

        public string NombreUniversiad { get => nombreUniversiad; set => nombreUniversiad = value; }
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }

        public Universidad()
        {
            alumnos = new List<Alumno>();
        }
    }
}