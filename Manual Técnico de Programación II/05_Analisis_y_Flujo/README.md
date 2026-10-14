# 05. Análisis del funcionamiento

## Inicio y autorización

El programa solicita el nombre, la edad, la realidad, la energía y la estabilidad del cadete. Después crea el cadete principal, crea el cadete de respaldo y prepara el objeto SistemaNexus.

Para autorizar la conexión deben cumplirse al mismo tiempo tres condiciones:

1. Edad de 18 años o más.
2. Energía igual o superior a 40.
3. Estabilidad igual o superior a 50.

Si se cumplen las tres condiciones, el programa activa la conexión y muestra el menú. Si falla alguna, rechaza la conexión. Mientras la conexión permanezca activa, el menú se repite y se procesa la opción elegida. La opción de desconexión termina ese ciclo.

## Seguimiento del estado de Cadete

Si un cadete comienza con energía 70 y estabilidad 80 y recupera energía, su energía aumenta en 20 y queda en 90. La estabilidad no cambia y continúa en 80.

Si la energía inicial es 95, al sumar 20 se obtendría 115. Sin embargo, la propiedad limita el resultado a 100. Los métodos y propiedades revisados también evitan que la energía y la estabilidad bajen de 0.

## Predicción de resultados

Para predecir el resultado de una operación:

1. Anotar los valores iniciales.
2. Identificar qué acción se va a realizar.
3. Aplicar los cambios en el orden en que ocurren.
4. Comprobar los límites de las propiedades.
5. Explicar el resultado esperado.

Por ejemplo, si la energía comienza en 95 y el cadete la recupera, el resultado final es 100, no 115, porque la propiedad limita el valor máximo.

## Cambio de una condición

Si el requisito mínimo de energía para conectarse cambiara de 40 a 60, un cadete de 20 años, con energía 50 y estabilidad 70, ya no podría conectarse. Antes del cambio cumplía los tres requisitos; después, dejaría de cumplir el requisito de energía.

## Efecto de quitar una validación

Si se quitara el límite máximo de la propiedad de energía y la acción de recuperar energía tampoco controlara el resultado, un cadete que comienza con energía 95 podría terminar con energía 115. Ese valor estaría fuera del rango previsto de 0 a 100. Este ejemplo muestra por qué las validaciones son importantes para mantener los valores dentro de los límites establecidos.