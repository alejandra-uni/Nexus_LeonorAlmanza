# 04. Colecciones y LINQ

## Arreglo utilizado en NEXUS

En Program.cs se utiliza un arreglo de texto para guardar las realidades disponibles: IRIS-07, IRIS-12 e IRIS-21. Un arreglo tiene una cantidad de posiciones definida al crearse.

En la parte del código revisada no se identificó una lista List<Cadete> ni consultas LINQ. Los conceptos siguientes sirven para estudiar esos temas.

## Listas genéricas

Una lista genérica puede aumentar o disminuir de tamaño. Por ejemplo, una lista de tipo List<Cadete> podría almacenar varios objetos Cadete.

La operación Add agrega un objeto a la lista y Remove permite quitarlo. Un ciclo foreach recorre los elementos uno por uno; por ejemplo, puede consultar el nombre de cada cadete.

## Expresiones lambda y LINQ

LINQ permite consultar colecciones mediante operaciones para filtrar, ordenar y seleccionar datos. Una expresión lambda es una forma breve de indicar una condición o acción que se aplica a cada elemento.

- **Where** filtra y conserva los elementos que cumplen una condición, por ejemplo, cadetes con energía igual o superior a 50.
- **Select** selecciona un dato de cada elemento, por ejemplo, el nombre de cada cadete.
- **OrderBy** ordena los elementos según un criterio, como el nombre.
- **FirstOrDefault** devuelve el primer resultado o el valor predeterminado cuando no hay coincidencias.

## Ejemplo explicado

Si se tuviera una lista de cadetes, se podría filtrar a quienes tienen energía suficiente, ordenar los resultados por nombre y mostrar solamente sus nombres. Primero se realiza el filtro, después el ordenamiento y finalmente se selecciona el dato que se quiere mostrar.

Una alternativa es recorrer la lista con foreach y comprobar cada elemento mediante una condición. LINQ permite expresar las operaciones de forma más compacta, pero ambas formas pueden resolver la misma tarea.