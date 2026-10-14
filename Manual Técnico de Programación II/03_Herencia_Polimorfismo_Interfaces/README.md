# 03. Herencia, polimorfismo e interfaces

## Qué aparece en el proyecto

En la versión revisada de `Program.cs`, las clases principales son `Cadete`, `SistemaNexus` y `Nexus`. No se observa que una de estas clases herede de otra. Tampoco se identifican métodos `virtual`, `override` o `abstract`, ni una interfaz implementada por estas clases. Por eso, los ejemplos de esta sección son complementarios y no funciones que ya tenga el NEXUS publicado.

## Herencia

La herencia permite definir una clase nueva a partir de una clase base. La clase derivada recibe los miembros accesibles de la base y puede añadir o especializar comportamientos.

Ejemplo complementario: una clase llamada `RobotExplorador` puede tener una acción general para explorar. Una clase llamada `RobotMedico` puede derivar de ella y especializar esa acción para revisar el estado de un cadete. Los dos puntos en la declaración de la clase derivada expresan la relación de herencia.

## virtual y override

`virtual` indica que un método puede tener una versión especializada en una clase derivada. `override` declara esa nueva versión. En el ejemplo anterior, al ejecutar la acción de un objeto `RobotMedico`, se mostraría el mensaje específico de revisión médica en lugar del mensaje general de exploración.

## Polimorfismo

El polimorfismo permite utilizar una referencia de tipo base para trabajar con distintos objetos derivados. Cuando se llama a un método sobrescrito, se ejecuta la versión correspondiente al tipo real del objeto. Esto permite tratar de forma común a varios objetos que comparten una base, sin perder sus comportamientos especializados.

## Clases y métodos abstract

Una clase abstracta sirve como base para otras clases y no se puede instanciar directamente. Un método abstracto declara una operación que debe completarse en las clases derivadas. Este mecanismo no aparece implementado en las clases principales de la versión revisada de NEXUS.

## Interfaces

Una interfaz define un contrato: indica qué propiedades o métodos debe ofrecer una clase que la implemente. Como ejemplo de estudio, una interfaz `INotificableNEXUS` podría exigir que cada notificador indique su canal de origen y tenga una operación para enviar un mensaje. Las clases de notificación por correo y por SMS podrían cumplir ese contrato.

## Comparación de conceptos

- **Herencia:** una clase deriva de otra y reutiliza o especializa sus miembros.
- **Polimorfismo:** una referencia común puede ejecutar comportamientos distintos según el objeto real.
- **Interfaz:** una clase se compromete a ofrecer las operaciones definidas por un contrato.
- **Relación entre objetos en NEXUS:** `SistemaNexus` conserva referencias a dos objetos `Cadete`; esto no es herencia.
