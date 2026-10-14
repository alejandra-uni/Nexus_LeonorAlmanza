# 06. Banco de preguntas para el examen

## 1. ¿Cuál es la diferencia entre una clase y un objeto?

**Respuesta:** Una clase define los datos y las operaciones que tendrá un tipo. Un objeto es una instancia concreta creada a partir de esa definición. En NEXUS, Cadete es la clase y el cadete principal y el de respaldo son objetos.

## 2. ¿Para qué sirven las propiedades de energía y estabilidad?

**Respuesta:** Permiten consultar y modificar esos valores de forma controlada. En NEXUS los mantienen entre 0 y 100. Si se intenta asignar energía 130 mediante la propiedad, el valor final queda en 100.

## 3. ¿Qué responsabilidad tiene SistemaNexus?

**Respuesta:** Recibe dos objetos Cadete y guarda sus referencias: una para el cadete principal y otra para el de respaldo. Permite consultar esos objetos. No hereda de Cadete; trabaja con objetos de esa clase.

## 4. ¿Qué diferencia hay entre herencia y polimorfismo?

**Respuesta:** La herencia permite crear una clase derivada a partir de una clase base. El polimorfismo permite utilizar una referencia común y ejecutar el comportamiento correspondiente al objeto real. En las clases principales revisadas de NEXUS estos conceptos no aparecen implementados.

## 5. ¿Qué aporta una interfaz?

**Respuesta:** Define un contrato de operaciones que las clases que la implementan deben ofrecer. Si distintos notificadores implementan la misma interfaz, el resto del programa puede utilizarlos de manera uniforme.

## 6. ¿Qué diferencia hay entre un arreglo y List<T>?

**Respuesta:** El arreglo de realidades de NEXUS tiene una cantidad de posiciones definida al crearse. Una lista genérica puede cambiar de tamaño y permite agregar o quitar elementos.

## 7. ¿Qué hace Where en LINQ?

**Respuesta:** Filtra una colección y conserva los elementos que cumplen una condición. Por ejemplo, se puede utilizar para quedarse con los cadetes que tienen energía igual o superior a 50.

## 8. ¿Qué ocurre al recuperar energía cuando el cadete tiene 85?

**Respuesta:** El método suma 20, lo que daría 105. Sin embargo, la propiedad limita la energía a 100, por lo que ese es el valor final.

## 9. ¿Qué condiciones debe cumplir un cadete para conectarse?

**Respuesta:** Debe tener 18 años o más, energía de 40 o más y estabilidad de 50 o más. Las tres condiciones deben cumplirse; si una falla, se rechaza la conexión.

## 10. ¿Qué sucede si el requisito mínimo de energía cambia de 40 a 60?

**Respuesta:** Un cadete con energía 50 dejaría de cumplir el requisito. Aunque tenga edad y estabilidad suficientes, la conexión se rechazaría porque también debe cumplir la condición de energía.