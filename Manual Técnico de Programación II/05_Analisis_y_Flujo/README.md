# 05. Análisis y flujo del programa

## Inicio y autorización

El programa muestra la pantalla de bienvenida y solicita el nombre, la edad, la realidad, la energía y la estabilidad del cadete. Después crea el objeto del cadete principal, crea el cadete de respaldo y prepara el objeto `SistemaNexus`.

Para autorizar la conexión deben cumplirse simultáneamente estas condiciones:

1. Edad de 18 años o más.
2. Energía de 40 o más.
3. Estabilidad de 50 o más.

Si se cumplen las tres, el programa activa la conexión y muestra el menú. Si falla una, rechaza la inmersión. Mientras la conexión permanezca activa, el menú se repite y el programa procesa la opción elegida. La opción de desconexión permite salir del ciclo.

## Seguimiento del estado de Cadete

Si un cadete comienza con energía 70 y estabilidad 80 y se ejecuta la recuperación de energía, la energía aumenta en 20 y queda en 90. La estabilidad no cambia, por lo que sigue en 80.

Si la energía inicial es 95, la operación de recuperación no deja el resultado en 115. La propiedad limita el valor máximo a 100. De forma similar, la energía y la estabilidad no deben quedar por debajo de 0 mediante los métodos y propiedades revisados.

## Predicción de resultados

Para resolver una pregunta de predicción, se recomienda seguir estos pasos:

1. Anotar los valores iniciales.
2. Identificar qué método se ejecuta.
3. Aplicar las operaciones en el orden en que aparecen.
4. Revisar las condiciones y los límites de las propiedades.
5. Escribir el resultado esperado y justificarlo.

La consigna de esta carpeta menciona una salida de ejemplo “30 40 50”. Esa salida no aparece en el código publicado de NEXUS que se revisó. Para justificar exactamente esos tres valores hace falta el fragmento de código de ese ejercicio; no se atribuye ese resultado al programa actual.

## Cambio de una condición

Si el requisito de energía para conectarse cambiara de 40 a 60, un cadete de 20 años, con energía 50 y estabilidad 70 dejaría de cumplir la condición de conexión. Antes del cambio sí cumplía los tres requisitos; después, la energía sería insuficiente.

## Clases abstractas y MapExploration

La consigna también menciona declarar `MapExploration` como abstract. Esa clase no aparece en el `Program.cs` revisado. En un ejercicio independiente, declarar una clase como abstract impediría crear directamente un objeto de esa clase; se tendría que crear una clase derivada concreta. Este análisis es teórico y no describe una modificación ya hecha en NEXUS.
