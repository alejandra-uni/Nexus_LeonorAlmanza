# 01. Arquitectura y programación orientada a objetos

## Propósito de NEXUS

NEXUS es una aplicación de consola desarrollada en C#. Simula un sistema de entrenamiento y exploración de realidades. Solicita los datos de un cadete, comprueba si cumple los requisitos para conectarse y, si se autoriza la conexión, muestra un menú con distintas operaciones.

## Archivo principal y responsabilidades

- **Program.cs:** contiene las clases principales y la lógica del programa.
- **Cadete:** guarda el nombre, la edad, la realidad, la energía y la estabilidad. Sus métodos permiten recuperar o gastar energía, modificar la estabilidad y mostrar el estado del cadete.
- **SistemaNexus:** recibe el cadete principal y el cadete de respaldo, guarda las referencias a ambos y permite consultarlos.
- **Nexus:** contiene el punto de inicio del programa. Solicita los datos, crea los objetos, comprueba la autorización y administra el menú.
- **Nexus.csproj:** contiene la configuración del proyecto de C#.

## Relación entre las clases

La clase Nexus crea dos objetos Cadete y se los entrega a SistemaNexus. Esta última clase guarda la referencia del cadete principal y la del cadete de respaldo. Nexus coordina el menú y las operaciones.

SistemaNexus no deriva de Cadete. La relación consiste en que SistemaNexus utiliza y conserva referencias a objetos creados a partir de Cadete; no es una relación de herencia.

## Programación estructurada y programación orientada a objetos

La programación estructurada se observa en las instrucciones, las variables, las condiciones y los ciclos. Por ejemplo, el programa comprueba los requisitos de conexión y repite el menú mientras la conexión continúe activa.

La programación orientada a objetos organiza los datos y las operaciones en clases. Cadete reúne la información del cadete y las acciones que pueden cambiar su energía o estabilidad.

## Condiciones de conexión

Para autorizar la conexión, el cadete debe cumplir simultáneamente estos tres requisitos:

1. Tener 18 años o más.
2. Tener energía igual o superior a 40.
3. Tener estabilidad igual o superior a 50.

Si una de las condiciones no se cumple, se rechaza la conexión.