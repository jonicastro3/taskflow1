using System;
using System.Collections.Generic;

namespace TaskFlow
{
    class Tarea
    {
        public string Nombre { get; set; }
        public string Estado { get; set; } = "Pendiente"; 
    }

    class Program
    {
        static List<Tarea> listaTareas = new List<Tarea>();
        static void Main(string[] args) { }
    }
}