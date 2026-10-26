# Análisis técnico de la evolución de NEXUS

## 1. Punto de partida

El repositorio actual contiene una aplicación de consola C# en `NEXUS/Nexus/Nexus/Program.cs` y el proyecto `NEXUS/Nexus/Nexus/Nexus.csproj`, configurado para .NET 10. Las clases `Cadete` y `SistemaNexus` ya representan conceptos reutilizables, pero la clase `Nexus` concentra la interfaz de consola, las reglas, los mapas y el módulo TCP.

La consigna solicita orientar la evolución a una aplicación de escritorio en C# con Windows Forms y SQL Server. La propuesta debe mantener las reglas y contenidos de H3 y distinguir lo que existe de lo que falta implementar.

## 2. Alternativas evaluadas

### Interfaz de usuario

**Alternativa A: mantener la consola**
- Ventaja: conserva el código y requiere pocos cambios.
- Desventaja: no satisface la experiencia gráfica solicitada; los controles, mapas y navegación dependen del texto y del teclado.

**Alternativa B: Windows Forms**
- Ventajas: permite formularios, botones, paneles, listas, indicadores y eventos; es adecuada para una aplicación de escritorio de alcance académico y se integra con C#.
- Desventajas: hay que adaptar el punto de entrada, diseñar formularios y separar la lógica de los controles. Un mapa con muchas casillas necesita planificación visual.
- Decisión: recomendada porque coincide con la consigna.

**Alternativa C: motor de videojuegos**
- Ventajas: un motor como Unity está orientado a escenas, animación y gráficos de videojuego.
- Desventajas: introduce otra plataforma y una curva de aprendizaje mayor; no coincide con el objetivo concreto de construir una aplicación de escritorio con Windows Forms.
- Decisión: no priorizarlo en esta etapa. Se podría reconsiderar solo si el alcance cambia y el docente lo autoriza.

### Acceso a datos

**Alternativa A: guardar solo en memoria**
- Ventaja: simple para el prototipo.
- Desventaja: el progreso se pierde al cerrar el programa.
- Decisión: sirve para pruebas tempranas, no para la entrega final.

**Alternativa B: archivos locales**
- Ventaja: permite guardar datos sin servidor de base de datos.
- Desventaja: requiere diseñar formato, validación, actualización y recuperación; no cumple el requisito de SQL Server como persistencia objetivo.
- Decisión: no será la persistencia principal.

**Alternativa C: SQL Server mediante ADO.NET**
- Ventajas: usa SQL Server como pide la consigna; permite consultas parametrizadas y control explícito de conexiones y transacciones; es apropiado para aprender la relación entre C# y SQL.
- Desventajas: requiere configurar el servidor, diseñar tablas, gestionar errores y preparar una cadena de conexión.
- Decisión: recomendada para la primera versión persistente.

**Alternativa D: Entity Framework Core**
- Ventajas: facilita el mapeo entre objetos y tablas y puede reducir consultas repetitivas.
- Desventajas: añade una capa de abstracción y conceptos de configuración y migraciones; puede distraer del objetivo de aprender ADO.NET si ese es el contenido esperado por la asignatura.
- Decisión: opción alternativa que debe confirmarse con el docente. Para esta propuesta se prioriza ADO.NET.

### Organización del código

**Alternativa A: mantener toda la lógica en `Main()`**
- Ventaja: evita una refactorización inicial.
- Desventaja: mezcla interfaz, reglas, mapas y conexiones; complica probar y reutilizar la lógica.
- Decisión: no recomendada a largo plazo.

**Alternativa B: formularios, servicios, modelos y repositorios**
- Ventajas: cada parte tiene una responsabilidad; la lógica se puede probar sin abrir formularios; la persistencia puede cambiar sin rehacer la interfaz.
- Desventajas: requiere crear archivos y clases adicionales y definir contratos entre capas.
- Decisión: recomendada, implementada por etapas.

## 3. Decisiones técnicas recomendadas

1. Conservar las reglas existentes de cadete, energía, estabilidad y realidades como punto de partida.
2. Centralizar los valores del cadete en un solo modelo para evitar diferencias entre variables locales y propiedades.
3. Extraer el movimiento, la recolección y los efectos de anomalías de `Main()` a servicios.
4. Construir Windows Forms después de estabilizar las reglas principales.
5. Usar ADO.NET con consultas parametrizadas para SQL Server.
6. Guardar cadetes, partidas, progreso de misiones e inventario.
7. Dejar el modo cooperativo como opción futura: el módulo TCP actual no sincroniza el estado de juego.
8. Mantener el repositorio público sin binarios de compilación, archivos temporales ni secretos.

## 4. Viabilidad y experiencia del jugador

El alcance prioritario es viable si se implementa en etapas: primero una interfaz con menú y estado del cadete; luego el mapa y la misión de recolección; finalmente el guardado y la recuperación. Intentar añadir simultáneamente multijugador, animaciones avanzadas, muchas misiones y una base de datos completa aumentaría el riesgo.

La experiencia debe ofrecer mensajes claros cuando una acción no se puede realizar, indicadores numéricos de energía y estabilidad, navegación consistente y confirmación del guardado. Las pantallas no deben contener las reglas principales; deben invocar servicios y presentar sus resultados.

## 5. Fuentes técnicas de referencia

Las siguientes fuentes son documentación técnica oficial que se debe consultar durante la implementación. Los enlaces identifican la documentación recomendada; no significan que la aplicación ya esté implementada ni que todas las opciones se hayan probado dentro de este repositorio.

1. Microsoft Learn — Windows Forms overview:  
   https://learn.microsoft.com/dotnet/desktop/winforms/overview/
2. Microsoft Learn — Create a Windows Forms app with C#:  
   https://learn.microsoft.com/dotnet/desktop/winforms/get-started/create-app-visual-studio
3. Microsoft Learn — ADO.NET overview:  
   https://learn.microsoft.com/dotnet/framework/data/adonet/ado-net-overview
4. Microsoft Learn — SQL Server, ADO.NET y parámetros de comandos:  
   https://learn.microsoft.com/dotnet/framework/data/adonet/configuring-parameters-and-parameter-data-types
5. Microsoft Learn — SQL Server documentation:  
   https://learn.microsoft.com/sql/sql-server/
6. Microsoft Learn — Arquitectura de aplicaciones .NET (conceptos de capas y mantenibilidad):  
   https://learn.microsoft.com/dotnet/architecture/

## 6. Verificación de información obtenida con IA

La IA puede ayudar a organizar alternativas, proponer entidades o explicar conceptos, pero no se tomará su respuesta como prueba suficiente. Para verificar la propuesta:

1. Comparar cada afirmación sobre Windows Forms, ADO.NET y SQL Server con la documentación oficial de Microsoft enlazada arriba.
2. Comparar las funciones atribuidas a H3 con `Program.cs` y `Nexus.csproj` del repositorio.
3. Distinguir explícitamente las funciones actuales de las funciones propuestas.
4. Revisar los diagramas y nombres de entidades para comprobar que las relaciones tengan sentido y las claves foráneas apunten a entidades existentes.
5. Al implementar, compilar y probar cada etapa en Visual Studio; registrar los errores y corregir el documento si la solución real difiere.
6. No presentar como verificado un enlace, una consulta SQL o una función que no se haya comprobado.

## 7. Riesgos y medidas

| Riesgo | Medida |
|---|---|
| La lógica depende de consola | Extraer las reglas antes de crear todos los formularios. |
| Energía y estabilidad quedan desincronizadas | Mantener un modelo único y probar cada acción. |
| Error de conexión SQL | Capturar excepciones y mostrar estado del guardado. |
| Pérdida de progreso | Guardar cambios importantes y probar recuperación al reiniciar. |
| Exposición de credenciales | No subir contraseñas ni cadenas de conexión secretas. |
| Alcance excesivo | Priorizar mapa, misión principal, perfil y persistencia antes de extras. |
| Documentación desactualizada | Actualizarla junto con cada cambio relevante y usar commits descriptivos. |

## 8. Conclusión de diseño técnico

La ruta recomendada es Windows Forms + servicios de lógica de juego + modelos C# + repositorios ADO.NET + SQL Server. Esta combinación cumple la dirección tecnológica de la consigna y permite evolucionar las clases reales de H3 sin confundir el diseño futuro con las funciones ya disponibles.
