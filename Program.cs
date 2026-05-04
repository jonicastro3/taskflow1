static void Main(string[] args)
{
    Console.WriteLine("--- Sistema TaskFlow: Crear Tarea ---");
    Console.Write("Ingrese el nombre de la tarea: ");
    
    // 1. Primero leemos lo que escribe el usuario
    string nombreTarea = Console.ReadLine();

    // 2. Luego verificamos si está vacío
    if (string.IsNullOrEmpty(nombreTarea))
    {
        Console.WriteLine("Error: El nombre no puede estar vacío.");
    }
    else 
    {
        Console.WriteLine($"Tarea '{nombreTarea}' capturada correctamente.");
        
        // 3. ACÁ VA EL ÚLTIMO PASO: Simular el guardado
        Console.WriteLine("Guardando tarea en el sistema de NovaTech...");
        Console.WriteLine("¡Tarea guardada con éxito!");
    }
}