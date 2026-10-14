# 02. Fundamentos: clases y objetos

## Clase y objeto

Una clase es una definición que indica qué datos y operaciones tendrá un tipo de objeto. Un objeto es una instancia concreta de esa clase.

En NEXUS, `Cadete` es la clase. Durante el inicio se crean dos objetos: el cadete principal, con los datos ingresados por el usuario, y el cadete de respaldo, que comienza con nombre “Cadete de respaldo”, edad 20, realidad “IRIS-12”, energía 80 y estabilidad 80.

## Campos y propiedades

Los campos privados de `Cadete` guardan nombre, edad, energía, estabilidad y realidad. Al ser privados, no se accede a ellos directamente desde cualquier clase.

Las propiedades públicas `Nombre`, `Edad`, `Energia`, `Estabilidad` y `Realidad` permiten consultar o cambiar los datos. Las propiedades de energía y estabilidad limitan los valores al rango de 0 a 100. Por ejemplo, si se asigna 130 a la energía mediante la propiedad, el valor queda en 100; si se asigna un número negativo, queda en 0.

## Constructor

El constructor de `Cadete` recibe cinco datos: nombre, edad, realidad, energía y estabilidad. Se ejecuta al crear un objeto y utiliza esos datos para inicializar sus propiedades.

`SistemaNexus` también tiene un constructor. Recibe las referencias de los dos objetos `Cadete` y las guarda para utilizarlas después.

En las clases principales revisadas se encontró un constructor por clase. No se observa sobrecarga de constructores en ellas. La sobrecarga ocurre cuando una misma clase declara varios constructores con diferentes listas de parámetros.

## Métodos de Cadete

- `RecuperarEnergia`: aumenta la energía en 20, sin superar 100.
- `GastarEnergia`: resta la cantidad indicada, sin bajar de 0.
- `AumentarEstabilidad`: aumenta la estabilidad sin superar 100.
- `ReducirEstabilidad`: disminuye la estabilidad sin bajar de 0.
- `MostrarEstado`: muestra los datos del cadete.

## Modificadores de acceso

`private` restringe el acceso al miembro a la clase donde está declarado. `public` permite utilizarlo desde otras partes del programa donde sea accesible. Esta combinación ayuda a proteger los campos y a controlar los cambios por medio de las propiedades.

## Uso de this y base

En el constructor de `SistemaNexus`, `this` identifica el campo del objeto actual. Así se distingue el campo que se guarda de un parámetro que tiene el mismo nombre.

`base` se usa para acceder a un constructor o miembro de una clase padre. No se utiliza en las clases principales actuales porque no se observa una relación de herencia entre ellas.
