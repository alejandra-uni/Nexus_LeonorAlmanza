# 05. Análisis del funcionamiento

## Inicio y autorización

El programa solicita el nombre, la edad, la realidad, la energía y la estabilidad del cadete. Después crea el objeto del cadete principal, crea el cadete de respaldo y prepara el objeto SistemaNexus.

Para autorizar la conexión deben cumplirse simultáneamente tres condiciones:

1. Edad de 18 años o más.
2. Energía igual o superior a 40.
3. Estabilidad igual o superior a 50.

Si se cumplen las tres, el programa activa la conexión y muestra el menú. Si alguna falla, rechaza la conexión. Mientras la conexión permanezca activa, el menú se repite y se procesa la opción elegida. La opción de desconexión permite salir del ciclo.

## Seguimiento del estado de Cadete

Si un cadete comienza con energía 70 y estabilidad 80 y se ejecuta la recuperación de energía, la energía aumenta en 20 y queda en 90. La estabilidad no cambia y continúa en 80.

Si la energía inicial es 95, la suma de 20 daría 115, pero la propiedad limita el resultado a 100. De forma similar, los métodos y propiedades revisados evitan que la energía y la estabilidad queden por debajo de 0.

## Predicción de resultados

Para predecir el resultado de una operación:

1. Anotar los valores iniciales.
2. Identificar la operación que se ejecuta.
3. Aplicar los cambios en el orden en que ocurren.
4. Comprobar los límites de las propiedades.
5. Explicar el resultado esperado.

Por ejemplo, si la energía comienza en 95 y se recupera energía, el resultado final es 100, no 115, porque la propiedad limita el valor máximo.

## Cambio de una condición

Si el requisito mínimo de energía para conectarse cambiara de 40 a 60, un cadete de 20 años, con energía 50 y estabilidad 70 ya no podría conectarse. Antes del cambio cumplía los tres requisitos; después, la condición de energía dejaría de cumplirse.

## Efecto de quitar una validación

Si se quitara el límite máximo de la propiedad de energía y la recuperación tampoco controlara el resultado, un cadete que comienza con energía 95 podría terminar con energía 115. Ese valor estaría fuera del rango previsto de 0 a 100. Este ejemplo muestra por qué las validaciones forman parte del comportamiento de la clase.