# Arquitectura actual de NEXUS H3

## 1. Alcance de esta descripción

Este documento describe la versión de consola que existe en el repositorio, principalmente en `NEXUS/Nexus/Nexus/Program.cs`. No describe funciones futuras como si ya estuvieran implementadas.

El archivo de proyecto `NEXUS/Nexus/Nexus/Nexus.csproj` define una aplicación ejecutable de consola con `TargetFramework net10.0`, `ImplicitUsings enable` y `Nullable enable`. No es todavía un proyecto Windows Forms y no contiene configuración de conexión a SQL Server.

## 2. Clases y responsabilidades reales

### Clase `Cadete`
Representa los datos de un explorador. Contiene campos privados para nombre, edad, energía, estabilidad y realidad, propiedades públicas para acceder a ellos y un constructor que inicializa esos datos.

Sus métodos actuales son:
- `RecuperarEnergia()`: aumenta energía en 20, con máximo 100.
- `GastarEnergia(int cantidad)`: resta energía y evita que quede por debajo de cero.
- `AumentarEstabilidad(int cantidad)`: aumenta estabilidad hasta 100.
- `ReducirEstabilidad(int cantidad)`: reduce estabilidad sin bajar de cero.
- `MostrarEstado()`: imprime los datos en la consola.

Las propiedades de energía y estabilidad limitan sus valores al rango de 0 a 100.

### Clase `SistemaNexus`
Recibe por constructor dos objetos `Cadete`: el cadete principal y el de respaldo. Permite mostrar sus nombres y obtener una referencia a cada uno. Es una relación entre objetos; no es un servicio de base de datos.

### Clase `Nexus`
Contiene `Main()`, el punto de entrada y la mayor parte del flujo del programa. Solicita los datos iniciales, crea los objetos, comprueba los requisitos de conexión, muestra un menú y ejecuta las operaciones mediante un ciclo `while` y un `switch`.

En el mismo método se encuentran la interacción por consola, reglas del juego, creación de matrices, movimiento, recolección de recursos, cartografía y conexiones TCP. Esto hace que la lógica esté concentrada y dificulta reutilizarla directamente desde formularios gráficos.

## 3. Funcionalidades implementadas

- Inicio y mensajes de carga por consola.
- Registro inicial de nombre, edad, realidad, energía y estabilidad.
- Creación del cadete principal y de un cadete de respaldo.
- Validación de conexión: edad igual o superior a 18, energía igual o superior a 40 y estabilidad igual o superior a 50.
- Menú de ocho opciones: explorar realidad, analizar anomalía, consultar estado, recuperar energía, desconectar, seleccionar mapas, probar conexión TCP y consultar cadetes.
- Tres realidades: IRIS-07, IRIS-12 e IRIS-21.
- Mapas representados con matrices de 6 por 8 posiciones.
- Movimiento por teclado con flechas, bloqueo del agua, recolección de recursos y penalización por anomalías.
- Objetivo de recoger tres recursos en el modo de mapa.
- Visualización de cartografía, cantidad de recursos y anomalías detectadas.
- Reglas de estado, advertencias de recursos bajos y alerta de interferencia IRIS.
- Prueba de conexión TCP mediante `TcpListener` y `TcpClient`.

## 4. Flujo actual

1. Se inicia la consola.
2. Se solicitan los datos del cadete.
3. Se crean los objetos `Cadete` y `SistemaNexus`.
4. Se evalúan los requisitos de conexión.
5. Si la conexión es autorizada, se muestra el menú dentro del ciclo principal.
6. Cada opción ejecuta una operación.
7. Al final de la iteración se evalúan las reglas de energía y estabilidad.
8. La sesión termina si el jugador se desconecta o si una regla crítica finaliza la conexión.

## 5. Limitaciones reales identificadas

- La interfaz depende de `Console.WriteLine`, `Console.ReadLine`, `Console.ReadKey`, colores y movimiento del cursor. Estos elementos no son controles gráficos reutilizables de Windows Forms.
- La lógica del juego está concentrada en `Main()`, en vez de estar distribuida en servicios y clases especializadas.
- Las variables locales `energía` y `estabilidad` coexisten con `cadete1.Energia` y `cadete1.Estabilidad`. No todas las operaciones usan siempre una única fuente de verdad; se deberá corregir al separar la lógica.
- La validación inicial comprueba que energía y estabilidad no sean negativas, pero no rechaza explícitamente valores superiores a 100 pese a que el mensaje pide valores entre 0 y 100.
- La selección inicial de realidad se guarda como texto; el flujo de mapas cambia la realidad al seleccionar una de las tres opciones. La validación de nombres y selección debe fortalecerse.
- No hay clases separadas para mapa, misión, inventario o persistencia. Las matrices y reglas de mapa están escritas dentro del flujo de consola.
- El objetivo de tres recursos está codificado como constante local en el modo de mapa; no hay catálogo general de misiones ni progreso persistente.
- El inventario como colección de objetos no existe.
- No hay acceso a SQL Server, tablas ni guardado/carga de partidas.
- La conexión TCP solo intenta establecer comunicación y después cierra el cliente; no sincroniza el estado del juego ni constituye un modo multijugador completo.
- El código del proyecto no incluye pruebas automatizadas descritas en esta documentación.

## 6. Relación con los archivos del repositorio

| Archivo | Responsabilidad actual |
|---|---|
| `NEXUS/Nexus/Nexus/Program.cs` | Clases `Cadete`, `SistemaNexus`, clase `Nexus`, menú, reglas y mapas. |
| `NEXUS/Nexus/Nexus/Nexus.csproj` | Configuración del proyecto de consola C# para .NET 10. |
| `NEXUS/Nexus/Nexus/Nexus.slnx` | Archivo de solución que agrupa el proyecto. |
| `Manual Técnico de Programación II/` | Documentación de estudio del examen H3, independiente de la nueva documentación de diseño. |

## 7. Consecuencia para la evolución

No se recomienda reescribir todo sin aprovechar el código existente. Primero deben extraerse las reglas de cadete, energía, estabilidad y exploración a clases que no dependan de la consola. Después se podrá construir una interfaz Windows Forms que invoque esa lógica y un repositorio de datos para guardar el progreso. La arquitectura propuesta se detalla en [arquitectura-propuesta.md](arquitectura-propuesta.md).
