using System;
using System.Collections.Generic;

namespace TaskFlow
{
    class Program
    {
        // Simulamos una base de datos de tareas en memoria
        static List<string> listaTareas = new List<string>();

        static void Main(string[] args)
        {
            // Agregamos un par de tareas de prueba para que el listado no esté vacío
            listaTareas.Add("Configurar el repositorio en GitHub");
            listaTareas.Add("Aprender a hacer merges y resolver conflictos");

            Console.WriteLine("--- Sistema TaskFlow: Listado de Tareas ---");
            Console.WriteLine("-------------------------------------------");
            
            if (listaTareas.Count == 0)
            {
                Console.WriteLine("No hay tareas registradas en el sistema.");
            }
            else
            {
                for (int i = 0; i < listaTareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaTareas[i]}");
                }
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}