`…or create a new repository on the command line`
- echo "# CTIC_DesarrolloDotNET7" >> README.md
- git init
- git add README.md
- git commit -m "first commit"
- git branch -M main
- git remote add origin git@github.com:jBenitoLopez/CTIC_DesarrolloDotNET7.git
- git push -u origin main

`…or push an existing repository from the command line`
- git remote add origin git@github.com:jBenitoLopez/CTIC_DesarrolloDotNET7.git
- git branch -M main
- git push -u origin main
- …or import code from another repository

You can initialize this repository with code from a Subversion, Mercurial, or TFS project.


==============================================
Comandos:
> ls (lista archivos y carpetas)
> type .\global.json (muestra en contenido del archivo)

> dotnet (mustra las opciones disponibles)
> dotnet --info (lista SDKs instalados)
> dotnet -h (siempre nos dara la ayuda del comando)

> dotnet new console -h (muestra opciones disponible)
> dotnet new (nos muestras un lista de las plantillas de dotnet disponibles)
> dotnet new list (muestra las plantillas instaladas)
> dotnet new console (creo un proyecto nuevo de tipo console)
> dotnet new console --output AppConsole (creo un proyecto nuevo de tipo console con el nombre AppConsole)
> dotnet new console -o AppConsole
> dotnet new console -f net6.0 (Crea proyecto para la version NET6)
> dotnet new console -f net6.0 --use-program-main -o AppConsoleName
> dotnet run (ejecuta el proyecto)
> dotnet build  (compla el proyecto)
> ...\bin\Debug\net5.0> .\VariasVersiones.exe (ejecuta el ejecutable)


--------------------------------------------------------------------------------------------------------
Principales funciones de dotnet
--------------------------------------------------------------------------------------------------------
 - new		Permite crear un nuevo proyecto
 - restore	Lleva a cabo la restauración de las dependencias
 - build	Compila el proyecto
 - publish	Copia a una carpeta el resultado de la compilación del proyecto, lista para distribuir
 - run		Compila y ejecuta el proyecto
 - test		Ejecuta las pruebas unitarias especificadas en el proyecto
 - pack		Crea un paquete NuGet para poder publicarlo
 - nuget	Permite gestionar la publicación del paquete NuGet en un servidor
 - clean	Limpia las carpetas de compilación del proyecto
 - add		Permite añadir paquetes NuGet y referencias al proyecto
 - remove	Permite eliminar paquetes NuGet y referencias al proyecto
--------------------------------------------------------------------------------------------------------






