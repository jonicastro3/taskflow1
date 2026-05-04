using System;
using System.Collections.Generic;

namespace TaskFlow
{
    // 1. Creamos la estructura de la tarea
    class Tarea
    {
        public string Nombre { get; set; }
        public string Estado { get; set; } = "Pendiente"; 
    }

    class Program
    {
        // 2. Creamos la lista de tareas
        static List<Tarea> listaTareas = new List<Tarea>();

        // 3. El único método Main que ejecuta el programa
        static void Main(string[] args)
        {
            // --- AVANCE 2: Carga de datos ---
            listaTareas.Add(new Tarea { Nombre = "Aprender Git", Estado = "Completada" });
            listaTareas.Add(new Tarea { Nombre = "Terminar Actividad 4" }); // Nace Pendiente
            
            Console.WriteLine("Datos cargados en el sistema...");

            // --- AVANCE 3: Visualización funcional ---
            Console.WriteLine("\n--- TaskFlow: Monitoreo de Estados ---");
            foreach (var t in listaTareas)
            {
                string icono = t.Estado == "Completada" ? "[X]" : "[ ]";
                Console.WriteLine($"{icono} {t.Nombre} | Estado: {t.Estado}");
            }
        }
    }
}