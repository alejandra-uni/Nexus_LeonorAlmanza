# 01. Arquitectura y programación orientada a objetos

## Propósito de NEXUS

NEXUS es una aplicación de consola desarrollada en C#. Simula un sistema de entrenamiento y exploración de realidades. Solicita datos de un cadete, revisa si cumple las condiciones para conectarse y, si se autoriza la conexión, muestra un menú con distintas operaciones.

## Archivo principal y responsabilidades

- `NEXUS/Nexus/Nexus/Program.cs`: contiene las tres clases principales y la lógica del programa.
- `Cadete`: guarda el nombre, la edad, la realidad, la energía y la estabilidad de un cadete. Sus métodos permiten recuperar energía, gastar energía, modificar estabilidad y mostrar el estado.
- `SistemaNexus`: recibe un cadete principal y uno de respaldo, conserva sus referencias y permite consultar los cadetes.
- `Nexus`: contiene el método de inicio `Main`. Solicita los datos, crea los objetos, verifica la autorización y administra el menú.
- `NEXUS/Nexus/Nexus/Nexus.csproj`: contiene la configuración del proyecto de C#.

## Relación entre las clases

La clase `Nexus` crea dos objetos de tipo `Cadete` y los entrega al constructor de `SistemaNexus`. `SistemaNexus` guarda las referencias al cadete principal y al cadete de respaldo. La clase `Nexus` también coordina el uso del menú y las operaciones.

Esta relación no es herencia: `SistemaNexus` no deriva de `Cadete`; trabaja con objetos de ese tipo.

## Programación estructurada y programación orientada a objetos

La programación estructurada se observa en las instrucciones, variables, condiciones y ciclos de `Main`. Por ejemplo, la condición de autorización comprueba la edad, la energía y la estabilidad; el ciclo mantiene el menú activo mientras la conexión continúe.

La programación orientada a objetos se observa en las clases `Cadete` y `SistemaNexus`, que reúnen datos y operaciones relacionadas. Los objetos creados a partir de esas clases mantienen los datos de cada cadete.

## Condición de conexión

La conexión se autoriza únicamente si se cumplen las tres condiciones: la edad es de 18 años o más, la energía es de 40 o más y la estabilidad es de 50 o más. Si alguna condición no se cumple, se rechaza la inmersión.
