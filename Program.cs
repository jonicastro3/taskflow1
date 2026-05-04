using System;
using System.Collections.Generic;

namespace TaskFlow
static void Main(string[] args)
        {
            listaTareas.Add(new Tarea { Nombre = "Aprender Git", Estado = "Completada" });
            listaTareas.Add(new Tarea { Nombre = "Terminar Actividad 4" }); // Nace Pendiente
            
            Console.WriteLine("Datos cargados en el sistema...");
        }
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