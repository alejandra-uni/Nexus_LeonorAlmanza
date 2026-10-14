# 03. Herencia, polimorfismo e interfaces

## Qué aparece en el proyecto

En la versión revisada de Program.cs, las clases principales son Cadete, SistemaNexus y Nexus. No se observa que una de estas clases herede de otra ni que implementen una interfaz. Tampoco se identifican métodos virtual, override o abstract en estas clases. Por eso, esta sección explica conceptos de estudio, no funciones que ya estén incorporadas a NEXUS.

## Herencia

La herencia permite crear una clase nueva a partir de otra. La clase nueva puede reutilizar los datos y las acciones comunes y añadir o modificar comportamientos.

Como ejemplo de estudio, podría existir un robot explorador y un robot médico derivado de él. El robot médico conservaría las características generales y añadiría una acción para revisar el estado del cadete.

## virtual y override

La palabra virtual indica que una acción puede tener una versión especializada en una clase derivada. La palabra override indica que la clase derivada proporciona esa versión propia. En el ejemplo del robot, el explorador tendría una acción general y el robot médico mostraría una acción distinta para revisar al cadete.

## Polimorfismo

El polimorfismo permite utilizar una referencia de tipo general para trabajar con distintos objetos derivados. Cuando se solicita una acción que fue especializada, se ejecuta la versión que corresponde al objeto real. Así se puede trabajar de manera común con diferentes tipos de objetos sin perder sus acciones específicas.

## Clases y métodos abstractos

Una clase abstracta sirve como base para otras clases, pero no se puede crear un objeto directamente a partir de ella. Un método abstracto declara una acción que las clases derivadas deben completar. Este mecanismo no aparece en las clases principales revisadas de NEXUS.

## Interfaces

Una interfaz establece un contrato: indica qué acciones o datos debe ofrecer una clase que la implemente. Como ejemplo de estudio, una interfaz de notificaciones podría exigir que cada notificador indique su canal de origen y permita enviar un mensaje. Un notificador por correo y otro por SMS podrían cumplir el mismo contrato.

## Diferencias principales

- Herencia: una clase se crea a partir de otra y reutiliza o especializa sus características.
- Polimorfismo: una referencia general permite ejecutar la acción que corresponde al objeto concreto.
- Interfaz: establece las acciones que una clase se compromete a ofrecer.
- Relación entre objetos en NEXUS: SistemaNexus conserva referencias al cadete principal y al cadete de respaldo. Esto no es herencia.