# 03. Herencia, polimorfismo e interfaces

## Qué aparece en el proyecto

En la versión revisada de Program.cs, las clases principales son Cadete, SistemaNexus y Nexus. No se observa que una de estas clases herede de otra ni que implementen una interfaz. Tampoco se identifican métodos virtual, override o abstract en estas clases. Por eso, los conceptos siguientes se explican como materia de estudio, no como funciones ya incorporadas a NEXUS.

## Herencia

La herencia permite crear una clase nueva a partir de una clase base. La clase derivada puede reutilizar las características comunes y añadir o especializar acciones.

Como ejemplo de estudio, podría existir un robot explorador general y una clase RobotMedico derivada de él. El robot médico conservaría las características comunes y añadiría una acción para revisar el estado del cadete.

## virtual y override

La palabra virtual indica que un método puede tener una versión especializada en una clase derivada. La palabra override declara esa versión especializada. En el ejemplo del robot, el método general podría mostrar que el robot explora, mientras que la versión especializada del robot médico indicaría que revisa al cadete.

## Polimorfismo

El polimorfismo permite utilizar una referencia del tipo base para trabajar con distintos objetos derivados. Cuando se solicita un método sobrescrito, se ejecuta la versión correspondiente al tipo real del objeto. Así se puede trabajar con varios tipos de objetos de manera común sin perder sus acciones especializadas.

## Clases y métodos abstractos

Una clase abstracta sirve como base para otras clases y no se puede instanciar directamente. Un método abstracto declara una operación que las clases derivadas deben implementar. Este mecanismo no aparece en las clases principales revisadas de NEXUS.

## Interfaces

Una interfaz define un contrato: indica qué operaciones debe ofrecer una clase que la implemente. Como ejemplo de estudio, una interfaz de notificaciones podría exigir que cada notificador indique su canal de origen y tenga una operación para enviar un mensaje. Un notificador por correo y otro por SMS podrían cumplir el mismo contrato.

## Diferencias principales

- **Herencia:** una clase deriva de otra y reutiliza o especializa sus características.
- **Polimorfismo:** una referencia común permite ejecutar acciones diferentes según el objeto real.
- **Interfaz:** establece un contrato de operaciones que una clase debe cumplir.
- **Relación entre objetos en NEXUS:** SistemaNexus conserva referencias a dos objetos Cadete. Esto no es herencia.