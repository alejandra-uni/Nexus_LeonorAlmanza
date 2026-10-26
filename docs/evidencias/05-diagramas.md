# Evidencias de diseño y diagramas

Este archivo reúne diagramas textuales versionables para la propuesta. Los cuatro wireframes principales están en [../diseno-del-juego.md](../diseno-del-juego.md). Si se elaboran dibujos o capturas con una herramienta gráfica, deben guardarse en esta carpeta y enlazarse desde el documento de diseño.

## 1. Ciclo principal del juego

```mermaid
flowchart TD
    A[Iniciar NEXUS] --> B[Crear o seleccionar cadete]
    B --> C{¿Cumple requisitos de conexión?}
    C -- No --> D[Mostrar requisitos y permitir corregir datos]
    D --> B
    C -- Sí --> E[Menú principal]
    E --> F[Elegir realidad y misión]
    F --> G[Explorar mapa]
    G --> H[Recoger recursos / analizar anomalías]
    H --> I[Actualizar energía, estabilidad y progreso]
    I --> J{¿Objetivo cumplido?}
    J -- No --> G
    J -- Sí --> K[Marcar misión completada]
    K --> L[Guardar progreso en SQL Server]
    L --> M[Volver al centro de operaciones]
    M --> E
```

Nota: el guardado en SQL Server y el catálogo general de misiones pertenecen a la versión propuesta, no a la versión de consola H3.

## 2. Arquitectura propuesta

```mermaid
flowchart TD
    J[Jugador] --> WF[Windows Forms]
    WF --> S[Servicios del juego]
    S --> M[Modelos: Cadete, Mapa, Mision, Inventario]
    S --> I[Interfaces de repositorio]
    I --> R[Repositorio ADO.NET]
    R --> DB[(SQL Server)]
    R --> S
    S --> WF
```

## 3. Modelo de datos

```mermaid
erDiagram
    CADETE ||--o{ PARTIDA : juega
    REALIDAD ||--o{ MISION : contiene
    REALIDAD ||--o{ PARTIDA : seleccionada
    PARTIDA ||--o{ PROGRESOMISION : registra
    MISION ||--o{ PROGRESOMISION : progresa
    PARTIDA ||--o{ INVENTARIO : posee
    RECURSO ||--o{ INVENTARIO : contabiliza
```

## 4. Evidencias gráficas que se pueden añadir

Cuando se elaboren en una herramienta de dibujo o diseño, guardar aquí archivos con nombres claros, por ejemplo:
- `wireframe-menu-principal.png`
- `wireframe-exploracion.png`
- `wireframe-misiones.png`
- `wireframe-cadetes-inventario.png`

Los bocetos incluidos en `diseno-del-juego.md` ya sirven como wireframes iniciales. Las imágenes son una mejora visual opcional, salvo que el docente solicite expresamente dibujos gráficos.
