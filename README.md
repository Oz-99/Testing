# 🚀 Repositorio de Pruebas y Experimentos (.NET & CI/CD)

[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![Estado del Build (Jenkins)](https://img.shields.io/badge/Jenkins-En%20Construcción-yellow.svg)](URL_DE_JENKINS) 
## 📝 Descripción

Este repositorio sirve como un **espacio de trabajo y pruebas** para la exploración de conceptos de desarrollo de software.

Principalmente, contiene proyectos basados en **C# (.NET)** y configuraciones para la **automatización de la construcción y despliegue** mediante un pipeline de Integración Continua (CI/CD).

Puedes utilizarlo para:

* Probar nuevas características de C# o .NET.
* Experimentar con diferentes estructuras de proyectos.
* Desarrollar y validar scripts de CI/CD (Jenkins).

## 🛠️ Tecnologías Utilizadas

* **Lenguaje de Programación:** C#
* **Framework:** .NET (o .NET Core / .NET Framework, net 8.0)
* **Gestor de Soluciones:** Visual Studio Solution (`.sln`)
* **Integración Continua:** Jenkins (`Jenkinsfile`)
* **Entorno de Desarrollo:** Visual Studio Code o Visual Studio (sugerido por el directorio `.vscode`)

## 📂 Estructura del Proyecto

La estructura actual del repositorio incluye:
├── .vscode/ # Configuración del editor (Visual Studio Code) 
├── ConsoleApp1/ # Proyecto principal de la aplicación de consola C# 
├── test/ # Directorio para pruebas y ejemplos experimentales 
(1) ├── test2/ # Directorio para pruebas y ejemplos experimentales 
(2) ├── test3/ # Directorio para pruebas y ejemplos experimentales 
(3) ├── ConsoleApp1.sln # Archivo de solución de Visual Studio └── Jenkinsfile # Script de pipeline para Jenkins (definición del CI/CD)

## ⚙️ Instalación y Ejecución Local

Para ejecutar el proyecto localmente, necesitas tener instalado el SDK de .NET.

1.  **Clona el repositorio:**
    ```bash
    git clone [https://github.com/Oz-99/Testing.git](https://github.com/Oz-99/Testing.git)
    cd Testing
    ```

2.  **Restaura las dependencias:**
    ```bash
    dotnet restore ConsoleApp1.sln
    ```

3.  **Compila y ejecuta el proyecto principal (`ConsoleApp1`):**
    ```bash
    dotnet run --project ./ConsoleApp1/ConsoleApp1.csproj
    ```

4.  **Abre en tu IDE:**
    Simplemente abre el archivo `ConsoleApp1.sln` con Visual Studio o abre el directorio completo con Visual Studio Code.

## 🤖 Integración Continua (CI/CD)

Este repositorio incluye un `Jenkinsfile` que define un pipeline de CI/CD. Este pipeline está configurado para:

1.  Obtener el código.
2.  Restaurar las dependencias de NuGet.
3.  Compilar la solución.

Para poner en marcha el CI/CD, este repositorio debe estar conectado a una instancia de Jenkins.

## 🤝 Contribución

Siéntete libre de clonar, bifurcar y usar este repositorio para tus propias pruebas. Si deseas contribuir o sugerir mejoras a la plantilla de pruebas o al `Jenkinsfile`, sigue estos pasos:

1.  Haz un "Fork" del repositorio.
2.  Crea una nueva rama (`git checkout -b feature/nombre-caracteristica`).
3.  Realiza tus cambios y haz "commit" de ellos (`git commit -m 'feat: Agregada nueva prueba X'`).
4.  Sube tus cambios a la rama (`git push origin feature/nombre-caracteristica`).
5.  Abre un "Pull Request".



