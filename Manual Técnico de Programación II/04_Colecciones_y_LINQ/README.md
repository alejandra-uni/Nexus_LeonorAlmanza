# 04. Colecciones y LINQ

## Arreglo utilizado en NEXUS

En `Program.cs` hay un arreglo de texto que guarda las realidades disponibles: IRIS-07, IRIS-12 e IRIS-21. Un arreglo tiene una cantidad de posiciones definida cuando se crea.

En la parte revisada no se identificó una colección `List<Cadete>` ni consultas LINQ. Los apartados siguientes son ejemplos complementarios para estudiar esos temas.

## List<T>

`List<T>` es una lista genérica que puede aumentar o disminuir de tamaño. La letra T representa el tipo de dato que guardará. Por ejemplo, una lista de tipo `List<Cadete>` puede almacenar varios objetos `Cadete`.

El método `Add` agrega un objeto a la lista. Un ciclo `foreach` permite recorrer los elementos uno por uno y consultar, por ejemplo, el nombre de cada cadete.

## Expresiones lambda y LINQ

LINQ permite consultar colecciones mediante operaciones como filtrar, ordenar y seleccionar datos. Una expresión lambda es una forma breve de describir una operación o condición para cada elemento.

- `Where` filtra y conserva los elementos que cumplen una condición.
- `Select` selecciona o transforma cada elemento en el dato que interesa.
- `OrderBy` ordena los resultados según un criterio.
- `FirstOrDefault` obtiene el primer resultado o el valor predeterminado si no hay coincidencias.

## Ejemplo explicado

Si se tiene una lista de cadetes, se puede filtrar a quienes tienen energía de 50 o más, ordenar esos cadetes por nombre y mostrar solo sus nombres. Primero se aplica el filtro de energía, luego el orden alfabético y finalmente se selecciona el nombre para mostrarlo.

Una alternativa sin LINQ es recorrer la lista con `foreach` y comprobar cada energía mediante una condición. LINQ reúne las operaciones en una consulta más compacta, pero ambos enfoques pueden servir para resolver la misma tarea.

Para utilizar estas herramientas en C#, normalmente se importan los espacios de nombres de colecciones genéricas y LINQ.
