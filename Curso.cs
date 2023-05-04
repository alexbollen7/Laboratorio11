using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio11
{
    public class Curso
    {
        string nombreCurso;
        int nota;

        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}