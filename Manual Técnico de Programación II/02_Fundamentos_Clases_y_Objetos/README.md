# 02. Fundamentos de clases y objetos

## Clase y objeto

Una clase define los datos y las operaciones que tendrá un tipo de objeto. Un objeto es una instancia concreta creada a partir de esa definición.

En NEXUS, Cadete es la clase. Al iniciar, el programa crea un cadete principal con los datos ingresados y un cadete de respaldo que comienza con nombre “Cadete de respaldo”, edad 20, realidad IRIS-12, energía 80 y estabilidad 80.

## Campos y propiedades

Los campos guardan la información interna de un objeto. En Cadete, los campos privados almacenan el nombre, la edad, la energía, la estabilidad y la realidad.

Las propiedades públicas permiten consultar o modificar esos datos de forma controlada. Las propiedades de energía y estabilidad limitan sus valores al rango de 0 a 100. Si se intenta asignar energía 130 a través de la propiedad, el valor queda en 100; si se asigna un número negativo, queda en 0.

## Métodos

Los métodos representan acciones que puede realizar un objeto Cadete:

- **RecuperarEnergia:** aumenta la energía en 20 sin superar 100.
- **GastarEnergia:** resta la cantidad indicada sin bajar de 0.
- **AumentarEstabilidad:** aumenta la estabilidad sin superar 100.
- **ReducirEstabilidad:** disminuye la estabilidad sin bajar de 0.
- **MostrarEstado:** muestra los datos del cadete.

## Constructores y sobrecarga

El constructor de Cadete recibe cinco datos: nombre, edad, realidad, energía y estabilidad. Se ejecuta al crear el objeto y utiliza esos datos para inicializarlo.

El constructor de SistemaNexus recibe los objetos del cadete principal y del cadete de respaldo y guarda sus referencias. En las clases principales revisadas no se observa sobrecarga de constructores. La sobrecarga ocurre cuando una clase tiene varios constructores con diferentes listas de parámetros.

## Modificadores de acceso y encapsulamiento

El encapsulamiento protege los datos internos y controla cómo se consultan o modifican. **private** limita el acceso al miembro a la clase donde está declarado. **public** permite utilizarlo desde otras partes del programa donde sea accesible.

En Cadete, los campos privados y las propiedades públicas ayudan a controlar los cambios de energía y estabilidad.

## Uso de this y base

En el constructor de SistemaNexus, **this** identifica el campo del objeto actual y permite distinguirlo del parámetro recibido.

**base** permite acceder a un constructor o miembro de una clase padre. No se utiliza en las clases principales revisadas porque no se observa una relación de herencia entre ellas.