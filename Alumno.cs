using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio11
{
    public class Alumno
    {
        string nombre;
        string carne;
        string fechaNacimiento;
        string direccion;
        List<Curso> cursos;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Carne { get => carne; set => carne = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Curso> Cursos { get => cursos; set => cursos = value; }

        public Alumno()
        {
            cursos = new List<Curso>();
        }
    }
}