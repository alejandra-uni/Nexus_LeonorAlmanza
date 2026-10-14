# 06. Preparación para el examen H3

## 1. ¿Por qué Cadete es una clase y el cadete principal es un objeto?

Respuesta: Cadete describe los datos y las acciones que tendrá un cadete. El cadete principal es un objeto concreto creado con valores determinados, como nombre, edad, realidad, energía y estabilidad.

## 2. ¿Qué pasaría si se intenta asignar energía 130?

Respuesta: La propiedad de energía limita el valor a 100. Si se asigna un número negativo, lo limita a 0. De esta forma, la energía se mantiene dentro del rango de 0 a 100.

## 3. ¿Para qué sirve el constructor de SistemaNexus?

Respuesta: Recibe dos objetos Cadete y conserva una referencia al cadete principal y otra al cadete de respaldo. Así, el sistema puede consultarlos mediante sus métodos.

## 4. ¿Qué diferencia hay entre herencia y composición?

Respuesta: Con herencia, una clase deriva de otra y reutiliza o especializa sus características. Con composición o contención, un objeto guarda o utiliza otros objetos. SistemaNexus utiliza dos objetos Cadete, pero no hereda de Cadete.

## 5. ¿Cómo funciona el polimorfismo?

Respuesta: Una clase derivada puede proporcionar una versión especializada de una acción. Si una referencia de tipo general guarda un objeto derivado, al solicitar esa acción se ejecuta la versión que corresponde al objeto real.

## 6. ¿Qué aporta una interfaz?

Respuesta: Define un contrato de acciones o datos que una clase se compromete a ofrecer. Por ejemplo, un notificador por correo y otro por SMS podrían cumplir el mismo contrato de envío de mensajes.

## 7. ¿Qué hace Where en una consulta LINQ?

Respuesta: Filtra una colección y conserva los elementos que cumplen una condición. Por ejemplo, permite quedarse con los cadetes que tienen energía de 50 o más.

## 8. ¿Qué ocurre al recuperar energía cuando el cadete tiene 85?

Respuesta: La acción suma 20, lo que daría 105. Sin embargo, la propiedad limita la energía a 100, por lo que ese es el valor final.

## 9. ¿Qué condiciones debe cumplir un cadete para conectarse?

Respuesta: Debe tener 18 años o más, energía de 40 o más y estabilidad de 50 o más. Las tres condiciones deben cumplirse al mismo tiempo; si una falla, se rechaza la conexión.

## 10. ¿Qué sucede si el requisito mínimo de energía cambia de 40 a 60?

Respuesta: Un cadete con energía 50 dejaría de cumplir el requisito. Aunque tenga edad y estabilidad suficientes, la conexión se rechazaría porque también debe cumplir la condición de energía.