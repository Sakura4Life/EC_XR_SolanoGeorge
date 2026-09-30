# EC_XR_SolanoGeorge

## Datos del estudiante

- **Apellidos y nombres: Solano George
- **Código del estudiante: 2231890630
- **Curso:** Laboratorio de Realidad Extendida (XR) para Videojuegos
- **Docente:** Victor Alejandro Arroyo Castro

## Descripción del proyecto

Experiencia interactiva desarrollada en Unity 6 con URP que representa una sala de entrenamiento XR. El proyecto integra la configuración del entorno XR, la manipulación directa de objetos y la interacción a distancia mediante el XR Interaction Toolkit, aplicando los contenidos trabajados en las sesiones 1, 2 y 3.

La escena se denomina `EC_XR_SolanoGeorge` y se encuentra en `Assets/Scenes/`.

## Funcionalidades implementadas

### 1. Configuración del proyecto
- Unity 6.3 LTS con Universal Render Pipeline (URP).
- XR Interaction Toolkit 3.3.2 y XR Plugin Management 4.5.4.
- Mock HMD configurado como proveedor XR para pruebas sin visor físico.
- XR Device Simulator integrado para controlar cabeza y manos desde teclado y ratón.

### 2. Escenario XR
- Piso con superficie ampliada.
- Cuatro paredes que delimitan visualmente el área de entrenamiento.
- Iluminación direccional más una luz puntual interactiva.
- Mesa de trabajo y cinco objetos 3D con materiales diferenciados: cubo, esfera, cápsula, cilindro y una pieza tipo llave.

### 3. Manipulación de objetos
- Objetos equipados con `Rigidbody` y `XR Grab Interactable`.
- Movimiento por Velocity Tracking, lo que permite colisiones realistas con la mesa y el piso.
- Los objetos pueden tomarse, moverse, soltarse y responden a la gravedad.

### 4. Interacción a distancia
- Botón `botonLuz` ubicado en una pared, con componente `XR Simple Interactable`.
- Script propio `ToggleLuz.cs` que alterna el encendido y apagado de la luz puntual `LuzInteractiva`.
- El botón se activa apuntando con el rayo del interactor y seleccionando.

### 5. Funcionalidad adicional
- Sistema de teletransporte implementado con `Teleportation Area` sobre el piso y `Teleportation Provider` en el rig, permitiendo desplazarse por el escenario.

## Controles

Pruebas con XR Device Simulator (sin visor físico):

| Acción | Control |
|---|---|
| Mover la vista | Mouse |
| Desplazarse | W, A, S, D |
| Controlar mano izquierda | Mantener Shift izquierdo |
| Controlar mano derecha | Mantener Espacio |
| Agarrar / soltar objeto | G (grip) |
| Activar botón a distancia | T (trigger) |
| Teletransporte | Stick del controlador simulado |

Con visor físico se usan los controles estándar: grip para agarrar, trigger para seleccionar y stick para teletransportarse.

## Capturas de pantalla

### Vista general del escenario
![Vista general](docs/captura1_escenario.png)

### Configuración XR en el Inspector
![Inspector XR](docs/captura2_inspector.png)

### Interacción funcionando
![Interacción](docs/captura3_interaccion.png)

## Video demostrativo

[Ver video (máximo 1 minuto)]([pega aquí el enlace de tu video])

## Tecnologías y paquetes utilizados

- Unity 6.3 LTS (6000.3.10f1)
- Universal Render Pipeline (URP)
- XR Interaction Toolkit 3.3.2
- XR Plugin Management 4.5.4
- Mock HMD XR Plugin
- Input System (nuevo sistema de entrada)
- XR Interaction Toolkit Starter Assets y XR Device Simulator
- C# para los scripts personalizados
