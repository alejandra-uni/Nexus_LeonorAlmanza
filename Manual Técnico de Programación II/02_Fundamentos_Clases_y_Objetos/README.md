# 02. Fundamentos de clases y objetos

## Clase y objeto

Una clase define qué datos y acciones tendrá un tipo de objeto. Un objeto es un ejemplo concreto creado a partir de esa clase.

En NEXUS, Cadete es la clase. El programa crea un cadete principal con los datos ingresados por el usuario y otro de respaldo con nombre “Cadete de respaldo”, edad 20, realidad IRIS-12, energía 80 y estabilidad 80.

## Campos y propiedades

Los campos guardan la información interna del objeto. En Cadete, estos datos son el nombre, la edad, la energía, la estabilidad y la realidad.

Las propiedades permiten consultar o cambiar los datos de forma controlada. En NEXUS, las propiedades de energía y estabilidad mantienen sus valores entre 0 y 100. Por ejemplo, si se intenta asignar energía 130, el valor queda en 100; si se asigna un número negativo, queda en 0.

## Métodos

Los métodos son acciones que puede realizar un objeto Cadete:

- RecuperarEnergia aumenta la energía en 20, sin superar 100.
- GastarEnergia resta la cantidad indicada, sin bajar de 0.
- AumentarEstabilidad aumenta la estabilidad, sin superar 100.
- ReducirEstabilidad disminuye la estabilidad, sin bajar de 0.
- MostrarEstado presenta los datos del cadete.

## Constructores y sobrecarga

El constructor de Cadete recibe cinco datos: nombre, edad, realidad, energía y estabilidad. Se ejecuta cuando se crea el objeto y utiliza esos datos para inicializarlo.

El constructor de SistemaNexus recibe el cadete principal y el cadete de respaldo y guarda las referencias a ambos. En las clases principales revisadas no se observa que haya varios constructores de una misma clase. La sobrecarga ocurre cuando una clase tiene más de un constructor con diferentes parámetros.

## Modificadores de acceso y encapsulamiento

El encapsulamiento protege la información interna y controla cómo se consulta o modifica. El modificador private limita el acceso a un dato o acción a la clase donde se declaró. El modificador public permite utilizarlo desde otras partes del programa donde sea accesible.

En Cadete, los campos privados y las propiedades públicas ayudan a controlar los cambios de energía y estabilidad.

## Uso de this y base

En el constructor de SistemaNexus, this se refiere al objeto actual. Permite distinguir el campo donde se guarda el cadete del dato recibido como parámetro.

La palabra base permite acceder al constructor o a los miembros de una clase padre. No se utiliza en las clases principales revisadas porque no se observa una relación de herencia entre ellas.