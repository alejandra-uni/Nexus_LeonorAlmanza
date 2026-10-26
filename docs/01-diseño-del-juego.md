# NEXUS — Diseño del videojuego

## 1. Visión del juego

NEXUS evolucionará desde la aplicación de consola desarrollada para H3 hacia un videojuego de escritorio en C# con Windows Forms. El jugador será un cadete explorador que se conecta al sistema, elige una realidad IRIS, recorre mapas, reúne recursos y administra su energía y estabilidad para completar misiones.

La propuesta conserva los elementos que ya existen en el código: el cadete principal y el de respaldo, las realidades IRIS-07, IRIS-12 e IRIS-21, los mapas en forma de matriz, los recursos, las anomalías, las reglas de conexión y la recuperación de energía. Las pantallas gráficas y la persistencia en SQL Server son una evolución propuesta; todavía no forman parte de la versión de consola.

La motivación del jugador será desbloquear y explorar las tres realidades, completar objetivos, conservar los recursos del cadete y consultar el progreso guardado entre sesiones.

## 2. Ciclo principal de juego

1. El jugador inicia NEXUS y crea o selecciona su perfil de cadete.
2. El sistema verifica los requisitos de conexión: edad mínima de 18 años, energía de al menos 40 y estabilidad de al menos 50, según la regla actual.
3. Desde el menú, el jugador selecciona una realidad y una misión disponible.
4. Explora el mapa, se desplaza por el terreno, recoge recursos y evita o analiza anomalías.
5. Cada acción actualiza energía y estabilidad y muestra una respuesta visible.
6. Al alcanzar el objetivo, la misión se marca como completada y se actualiza el progreso.
7. El jugador regresa al centro de operaciones para recuperar energía, revisar al cadete o elegir otra misión.
8. El sistema guarda el progreso en SQL Server en la futura versión gráfica y permite continuar en otra sesión.

El ciclo está representado también en [evidencias/diagramas.md](evidencias/diagramas.md).

## 3. Mecánicas y reglas

### Cadetes
- El cadete tiene nombre, edad, realidad, energía y estabilidad.
- En el código actual, la clase `Cadete` limita energía y estabilidad al rango de 0 a 100 mediante sus propiedades.
- `SistemaNexus` mantiene referencias al cadete principal y al cadete de respaldo.
- En la propuesta gráfica se mostrarán el perfil activo, los indicadores de energía y estabilidad y la opción de consultar el cadete de respaldo.

### Realidades y mapas
- IRIS-07: Valle de Cristal.
- IRIS-12: Sector Abisal.
- IRIS-21: Zona de Interferencia.
- Los mapas actuales son matrices de 6 filas por 8 columnas. Sus valores representan agua, terreno, base, recurso y anomalía.
- En la exploración de consola, el jugador se desplaza con las flechas. El agua impide el paso; los recursos pueden recogerse y las anomalías reducen estabilidad.
- En la versión gráfica, estas casillas se representarán mediante elementos visuales diferenciados y una leyenda visible.

### Energía y estabilidad
- La energía se consume al explorar o recoger recursos y puede recuperarse desde la opción de recuperación.
- La estabilidad disminuye al encontrar anomalías y puede aumentar al analizar anomalías según las reglas existentes.
- El sistema muestra advertencias cuando los valores son bajos y aplica una regla de alerta IRIS en condiciones críticas.
- La interfaz deberá mostrar los valores actualizados después de cada acción. La lógica se centralizará para evitar que las variables de la interfaz y el objeto Cadete tengan valores diferentes.

### Misiones y recursos
- El código actual incluye una meta de recoger tres recursos durante la exploración del mapa. No existe todavía un sistema general de misiones guardadas ni un inventario persistente.
- Propuesta: cada misión tendrá nombre, descripción, realidad, objetivo, recompensa y estado (disponible, en curso o completada).
- Propuesta: el inventario guardará los recursos recolectados y mostrará la cantidad de cada tipo. La misión solo se completará cuando se cumpla su objetivo.
- Las recompensas y el desbloqueo de nuevas misiones serán añadidos en una etapa posterior y no se presentan como funciones ya implementadas.

### Conexión en red
- El programa H3 contiene un módulo TCP para intentar establecer una conexión con otro explorador.
- La conexión actual es una prueba de comunicación; no sincroniza mapas, inventarios ni partidas.
- La experiencia principal se diseñará para un solo jugador. El modo cooperativo queda como funcionalidad opcional futura.

## 4. Diseño de pantallas (wireframes)

Los siguientes bocetos son esquemáticos; muestran la distribución propuesta, no interfaces funcionales.

### Pantalla 1. Menú principal

```text
+----------------------------------------------------------------+
| NEXUS — CENTRO DE OPERACIONES                     [Perfil]      |
+----------------------+-----------------------------------------+
| NEXUS                | Bienvenida, Cadete                       |
|                      |                                         |
| [Continuar partida]  | Realidad actual: IRIS-07                |
| [Nueva partida]      | Energía     [##########------] 65/100    |
| [Explorar realidades]| Estabilidad [############----] 80/100    |
| [Misiones]           |                                         |
| [Cadetes e inventario]| Último objetivo / progreso               |
| [Configuración]      |                                         |
| [Salir]              | [Continuar]                             |
+----------------------+-----------------------------------------+
| Mensaje del sistema / resultado de la última acción             |
+----------------------------------------------------------------+
```

**Elementos y navegación:** el menú lateral lleva a exploración, misiones y perfil. “Continuar partida” carga el progreso guardado si existe. Si no existe, se ofrece crear una partida. Los valores del dibujo son ilustrativos, no datos guardados reales.

### Pantalla 2. Exploración / mapa

```text
+----------------------------------------------------------------+
| EXPLORACIÓN — IRIS-07: VALLE DE CRISTAL        [Pausa] [Volver]  |
+----------------------------+-----------------------------------+
| MAPA                       | ESTADO DEL CADETE                  |
|  ≈  ■  ■  *  ■  ■  ≈  ≈   | Energía     [########------] 60    |
|  ■  ■  ■  ■  ■  !  ■  ≈   | Estabilidad [##########----] 75    |
|  ■  *  ■  ⌂  ■  ≈  ≈  ≈   | Recursos: 1 / 3                     |
|  ■  ■  ■  ■  *  ■  ≈  ≈   | Objetivo: recoger 3 recursos       |
|                            | [Analizar anomalía]                 |
+----------------------------+-----------------------------------+
| Leyenda: ≈ Agua | ■ Terreno | ⌂ Base | * Recurso | ! Anomalía |
+----------------------------------------------------------------+
| Mensajes: recurso recogido / no puedes cruzar / energía baja    |
+----------------------------------------------------------------+
```

**Elementos y navegación:** el mapa ocupa el área principal; el panel lateral muestra recursos y estado. Al seleccionar una casilla o usar controles de movimiento, el sistema valida el desplazamiento, aplica el coste correspondiente y comunica el resultado. El boceto ilustra el concepto y no copia exactamente una de las matrices actuales.

### Pantalla 3. Misiones

```text
+----------------------------------------------------------------+
| MISIONES                                      [Volver al menú]  |
+---------------------------+------------------------------------+
| DISPONIBLES               | DETALLE DE MISIÓN                  |
| > Recolección de recursos | Realidad: IRIS-07                  |
|   Inspección de anomalía  | Objetivo: recoger 3 recursos       |
|   Reconocimiento          | Progreso: 1 / 3                    |
|                           | Estado: En curso                   |
| COMPLETADAS               | Recompensa: por definir            |
|   (se mostrarán aquí)     |                                    |
|                           | [Iniciar / Continuar misión]       |
+---------------------------+------------------------------------+
| Mensaje: el progreso se guardará al completar una acción         |
+----------------------------------------------------------------+
```

**Elementos y navegación:** una lista separa misiones disponibles y completadas. Al elegir una misión se muestra su realidad, objetivo y progreso. El catálogo general y las recompensas son parte de la propuesta futura; el objetivo de recoger tres recursos sí procede del código actual.

### Pantalla 4. Exploradores e inventario

```text
+----------------------------------------------------------------+
| EXPLORADORES E INVENTARIO                     [Volver al menú]  |
+-----------------------------+----------------------------------+
| CADETES                     | INVENTARIO                       |
| [Cadete principal]          | Recursos de cristal       x 2    |
| Nombre: nombre del jugador  | Muestras de anomalía      x 0    |
| Realidad: IRIS-07            | Otros recursos             x 0    |
| Energía: 60 / 100           |                                  |
| Estabilidad: 75 / 100       | [Usar] [Ver detalles]             |
|                             |                                  |
| [Ver cadete de respaldo]    |                                  |
+-----------------------------+----------------------------------+
| [Recuperar energía] [Guardar progreso] [Volver a explorar]      |
+----------------------------------------------------------------+
```

**Elementos y navegación:** permite revisar los datos del cadete y consultar los recursos. El botón de recuperación reutilizará la regla existente de recuperar 20 puntos, con el límite máximo de 100. El inventario con cantidades, el guardado y el uso de objetos se implementarán en etapas posteriores; no existen todavía como inventario persistente.

## 5. Experiencia de usuario

- **Legibilidad:** textos claros, tamaños suficientes y contraste entre fondo y contenido.
- **Jerarquía visual:** título de pantalla, objetivo, estado del cadete y acciones principales en ese orden.
- **Consistencia:** mismos colores, nombres de botones, iconos y ubicación de navegación en todas las pantallas.
- **Navegación:** acceso al menú principal desde cada módulo y confirmación antes de abandonar una misión en curso.
- **Retroalimentación:** mensajes visibles para movimiento bloqueado, recurso recogido, energía baja, misión completada, error de guardado o conexión fallida.
- **Accesibilidad básica:** no comunicar el estado únicamente mediante color; acompañar los indicadores con texto y números.
- **Prevención de errores:** validar valores introducidos, desactivar acciones que no se pueden ejecutar y confirmar antes de descartar progreso.
- **Persistencia:** informar si el progreso se guardó correctamente o si ocurrió un error.

## 6. Alcance y restricciones

### Prioridad alta
1. Mantener las reglas centrales del cadete y las tres realidades.
2. Crear la interfaz Windows Forms: menú, exploración, misiones y exploradores/inventario.
3. Separar la lógica del juego de los formularios.
4. Mostrar energía, estabilidad, mapa, recursos y mensajes.
5. Guardar y recuperar perfiles, partidas y progreso mediante SQL Server.
6. Validar entradas y manejar errores de base de datos.

### Prioridad media
- Historial de misiones completadas.
- Recompensas sencillas e inventario con cantidades.
- Pantalla de configuración y registro de acciones.
- Mejoras visuales del mapa e iconos.

### Opcional / futuro
- Cooperativo real por red.
- Animaciones avanzadas, efectos de sonido y nuevas realidades.
- Editor de mapas y misiones personalizadas.

### Restricciones
- El punto de partida es el código de H3, no un proyecto nuevo sin relación.
- La aplicación objetivo es de escritorio, en C# con Windows Forms y SQL Server.
- Los bocetos son propuestas y no implican que esas pantallas ya estén programadas.
- No se afirmará que existe guardado SQL, inventario persistente o modo cooperativo completo hasta que se implemente y pruebe.
- La lógica actual debe revisarse antes de migrarla: hay variables locales de energía y estabilidad junto con propiedades del objeto Cadete, y deben unificarse para evitar diferencias.
- La versión H3 usa una aplicación de consola con `OutputType` de tipo `Exe`; convertirla en Windows Forms requerirá una evolución del proyecto y no solo cambiar el aspecto visual.
