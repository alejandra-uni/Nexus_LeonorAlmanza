# 01. Arquitectura y programación orientada a objetos

## Propósito de NEXUS

NEXUS es una aplicación de consola desarrollada en C#. Simula un sistema de entrenamiento y exploración de realidades. Primero solicita los datos de un cadete y comprueba si cumple los requisitos para conectarse. Si se autoriza la conexión, muestra un menú con distintas operaciones.

## Archivo principal y responsabilidades

- Program.cs: reúne las clases principales y la lógica del programa.
- Cadete: guarda el nombre, la edad, la realidad, la energía y la estabilidad. También contiene acciones para recuperar o gastar energía, cambiar la estabilidad y mostrar el estado del cadete.
- SistemaNexus: recibe el cadete principal y el cadete de respaldo y conserva la referencia a cada uno para poder consultarlos.
- Nexus: inicia el programa, solicita los datos, crea los objetos, comprueba la autorización y administra el menú.
- Nexus.csproj: contiene la configuración del proyecto de C#.

## Relación entre las clases

Nexus crea dos objetos a partir de Cadete y los entrega a SistemaNexus. Esta última clase conserva una referencia al cadete principal y otra al cadete de respaldo. Nexus coordina el menú y las operaciones que el usuario elige.

SistemaNexus no es una clase derivada de Cadete. Simplemente recibe y utiliza objetos Cadete. Esta relación entre objetos no es herencia.

## Programación estructurada y programación orientada a objetos

La programación estructurada organiza las instrucciones mediante variables, condiciones y ciclos. En NEXUS se observa cuando se comprueban los requisitos de conexión y cuando el menú se repite mientras la conexión sigue activa.

La programación orientada a objetos organiza los datos y las acciones en clases. Por ejemplo, Cadete reúne la información del cadete y las acciones que permiten modificar su energía o estabilidad.

## Condiciones de conexión

Para autorizar la conexión deben cumplirse al mismo tiempo estos tres requisitos:

1. Tener 18 años o más.
2. Tener energía igual o superior a 40.
3. Tener estabilidad igual o superior a 50.

Si no se cumple uno de los requisitos, la conexión se rechaza.