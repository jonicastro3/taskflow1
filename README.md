# TaskFlow

## Descripción del proyecto
TaskFlow es un sistema de gestión de tareas por consola desarrollado para NovaTech.

## Cómo ejecutarlo
1. Clonar el repositorio.
2. Ejecutar `dotnet run` en la consola.

## Tecnologías usadas
* C#
* .NET Console Application

## Integrantes del equipo
* [Tu Nombre]
* [Nombres de tus compañeros]
4. El Primer Commit y la subida a GitHub
Ahora que tenemos la aplicación de C#, el .gitignore y el README.md, vamos a "empaquetar" todo esto en un commit y mandarlo a la nube.

Ejecutá estos comandos uno por uno en tu terminal:

Bash
# 1. Agrega todos los archivos nuevos y modificados (el punto significa "todo")
git add .

# 2. Crea el paquete con el mensaje exacto que pide la consigna
git commit -m "feat: estructura inicial del proyecto TaskFlow"

# 3. Renombra la rama principal a "main" (buena práctica actual)
git branch -M main

# 4. Conecta tu carpeta local con el repo de GitHub (reemplazá la URL por la tuya)
git remote add origin https://github.com/tu-usuario/taskflow.git

# 5. Sube el código por primera vez
git push -u origin main