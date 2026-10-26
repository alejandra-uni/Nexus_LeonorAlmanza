# NEXUS — Training System

## Descripción del proyecto

NEXUS es un proyecto académico desarrollado en C# para Programación II. La versión H3 es una aplicación de consola inspirada en la exploración de realidades. Permite registrar los datos de un cadete, comprobar si cumple los requisitos de conexión y realizar operaciones desde un menú.

El proyecto utiliza clases, objetos, constructores, campos, propiedades, métodos, condiciones, ciclos, matrices para los mapas y un módulo de prueba de conexión TCP.

## Objetivo

Comprender cómo se organiza una aplicación de C# mediante clases y objetos y utilizar el propio proyecto para repasar los temas de Programación II. La evolución propuesta consiste en transformar gradualmente la experiencia en una aplicación de escritorio con Windows Forms y persistencia en SQL Server, manteniendo como base las reglas y los elementos creados en H3.

## Funcionalidades implementadas en la versión H3

- Registro y validación inicial de datos del cadete.
- Gestión de energía y estabilidad.
- Cadete principal y cadete de respaldo.
- Selección de tres realidades: IRIS-07, IRIS-12 e IRIS-21.
- Exploración de mapas de 6 por 8 casillas, recolección de recursos y anomalías.
- Consulta de estado, recuperación de energía y reglas de advertencia.
- Prueba de conexión TCP.

La versión actual es de consola. Windows Forms, el inventario persistente, el catálogo general de misiones y el guardado en SQL Server son parte de la propuesta de evolución y todavía deben implementarse.

## Tecnologías actuales y propuestas

- **Actual:** C#, .NET 10 y aplicación de consola.
- **Propuesta:** C# con Windows Forms para la interfaz gráfica.
- **Propuesta:** SQL Server con ADO.NET para guardar y recuperar el progreso.

## Cómo ejecutar el proyecto actual

1. Clonar o descargar este repositorio.
2. Abrir la solución `NEXUS/Nexus/Nexus.slnx` en una versión de Visual Studio compatible con el proyecto.
3. Abrir el proyecto `NEXUS/Nexus/Nexus/Nexus.csproj`.
4. Ejecutar el proyecto desde Visual Studio.

El proyecto actual no requiere una base de datos SQL Server para ejecutarse. La configuración de SQL Server será documentada cuando se implemente la persistencia.

## Estructura del repositorio

La organización de los documentos de evolución sigue la estructura solicitada. Se conserva también, sin eliminar ni reemplazar su contenido, la carpeta del manual técnico de Programación II.

```text
NEXUS/
├── README.md
├── .gitignore
├── [solución y código existente]
├── docs/
│   ├── diseno-del-juego.md
│   ├── arquitectura-actual.md
│   ├── arquitectura-propuesta.md
│   ├── modelo-de-datos-propuesto.md
│   ├── analisis-tecnico.md
│   └── evidencias/
│       └── diagramas.md
├── Manual Técnico de Programación II/
│   ├── README.md
│   └── [secciones y archivos existentes del manual]
└── NEXUS/
    └── [solución y código fuente H3 existente]
```

La carpeta `Manual Técnico de Programación II/` se mantiene en la raíz del repositorio. La carpeta interna `NEXUS/` contiene la solución y el código C# que se desarrollaron para H3; no se reemplazan por los documentos de diseño.

## Documentación de la evolución

1. [Diseño del juego](docs/diseno-del-juego.md) — visión, ciclo de juego, reglas, cuatro wireframes, experiencia de usuario y alcance.
2. [Arquitectura actual](docs/arquitectura-actual.md) — descripción de las clases y funciones que existen en H3 y sus limitaciones.
3. [Arquitectura propuesta](docs/arquitectura-propuesta.md) — separación de Windows Forms, lógica del juego y acceso a datos.
4. [Modelo de datos propuesto](docs/modelo-de-datos-propuesto.md) — entidades, relaciones y estrategia de persistencia en SQL Server.
5. [Análisis técnico](docs/analisis-tecnico.md) — alternativas, decisiones, viabilidad, fuentes técnicas y verificación de información obtenida con IA.
6. [Diagramas y evidencias](docs/evidencias/diagramas.md) — ciclo principal, arquitectura y modelo de datos.

## Manual técnico para el H3

El manual está dividido en seis secciones: arquitectura y programación orientada a objetos; fundamentos de clases y objetos; herencia, polimorfismo e interfaces; colecciones y LINQ; análisis del funcionamiento; y un banco de preguntas de repaso.

[Consultar el índice del manual técnico](Manual%20T%C3%A9cnico%20de%20Programaci%C3%B3n%20II/README.md).

Los conceptos que no aparecen implementados directamente en el código se explican como materia de estudio y se diferencian de las funciones que sí tiene el proyecto.

## Autora

Leonor Alejandra Almanza Arroyo

Proyecto académico de Programación II. Universidad Privada Franz Tamayo (UNIFRANZ), Cochabamba, Bolivia.
