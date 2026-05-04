using System;

namespace TaskFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sistema TaskFlow: Crear Tarea ---");
            Console.Write("Ingrese el nombre de la tarea: ");
            if (string.IsNullOrEmpty(nombreTarea))
            {
                Console.WriteLine("Error: El nombre no puede estar vacío.");
            }
            else 
            {
                Console.WriteLine($"Tarea '{nombreTarea}' capturada correctamente.");
            }
            string nombreTarea = Console.ReadLine();
            
            // TODO: Agregar validaciones y guardado
        }
    }
}