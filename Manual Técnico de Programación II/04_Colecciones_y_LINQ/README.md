# 04. Colecciones y LINQ

## Arreglo utilizado en NEXUS

En Program.cs se utiliza un arreglo de texto para guardar las realidades disponibles: IRIS-07, IRIS-12 e IRIS-21. Un arreglo tiene una cantidad de posiciones definida al crearse.

En la parte del código revisada no se identificó una lista de objetos Cadete ni consultas LINQ. Por eso, los siguientes conceptos se explican como materia de estudio y no como funciones ya incorporadas al proyecto.

## Listas genéricas

Una lista genérica puede aumentar o disminuir de tamaño y almacenar elementos de un tipo determinado. Por ejemplo, una lista de cadetes podría guardar varios objetos Cadete.

La operación Add agrega un elemento a la lista y Remove permite quitarlo. Un recorrido con foreach permite revisar los elementos uno por uno; por ejemplo, para mostrar el nombre de cada cadete.

## Expresiones lambda y LINQ

LINQ permite consultar colecciones mediante operaciones que filtran, ordenan y seleccionan datos. Una expresión lambda es una forma breve de indicar una condición o acción que se aplica a cada elemento.

- Where filtra la colección y conserva los elementos que cumplen una condición, por ejemplo, los cadetes con energía igual o superior a 50.
- Select elige qué dato se quiere obtener de cada elemento, por ejemplo, el nombre de cada cadete.
- OrderBy ordena los elementos según un criterio, como el nombre.
- FirstOrDefault devuelve el primer resultado o, si no hay coincidencias, un valor predeterminado.

## Ejemplo explicado

Si se tuviera una lista de cadetes, primero se podría conservar a quienes tienen energía suficiente, después ordenar esos cadetes por nombre y finalmente mostrar solo sus nombres.

También se puede recorrer la lista y comprobar cada elemento mediante una condición. LINQ permite expresar el filtro, el ordenamiento y la selección de manera más compacta, pero ambas formas pueden resolver la misma tarea.