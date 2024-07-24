# Patrones de Diseño

Los patrones de diseño son soluciones habituales a problemas que ocurren con frecuencia en el diseño de software. Son como planos prefabricados que se pueden personalizar para resolver un problema de diseño recurrente en tu código.

No se puede elegir un patrón y copiarlo en el programa como si se tratara de funciones o bibliotecas ya preparadas. El patrón no es una porción específica de código, sino un concepto general para resolver un problema particular. Puedes seguir los detalles del patrón e implementar una solución que encaje con las realidades de tu propio programa.

A menudo los patrones se confunden con algoritmos porque ambos conceptos describen soluciones típicas a problemas conocidos. Mientras que un algoritmo siempre define un grupo claro de acciones para lograr un objetivo, un patrón es una descripción de más alto nivel de una solución. El código del mismo patrón aplicado a dos programas distintos puede ser diferente.

Una analogía de un algoritmo sería una receta de cocina: ambos cuentan con pasos claros para alcanzar una meta. Por su parte, un patrón es más similar a un plano, ya que puedes observar cómo son su resultado y sus funciones, pero el orden exacto de la implementación depende de ti.

## Descripción de los patrones de diseño

Para cada patrón se presentan los siguientes elementos:

- El nombre del patrón.
- La descripción del patrón.
- Un ejemplo describiendo el problema y la solución basada en el patrón descrito mediante un diagrama de clases UML.
- La estructura genérica del patrón:
  - Su esquema, extraído de cualquier contexto particular, bajo la forma de un diagrama de clases UML.
  - La lista de participantes del patrón.
  - Las colaboraciones en el patrón.
- Los dominios de la aplicación del patrón.
- Un ejemplo.

## Caso de Estudio - Venta Online de Vehículos

El sistema que vamos a diseñar es un sitio web de venta online de vehículos como, por ejemplo, automóviles o motocicletas. 
Este sistema autoriza distintas operaciones como la visualización de un catálogo, la recogida de un pedido, la gestión y el seguimiento de los clientes. Además estará accesible bajo la forma de un servicio web.

### Dominio

El sitio permite visualizar un catálogo de vehículos puestos a la venta, realizar búsquedas en el catálogo, realizar el pedido de un vehículo, seleccionar las opciones para el mismo mediante un sistema de carro de la compra virtual. Las opciones incompatibles también deben estar gestionadas (por ejemplo "asientos deportivos" y "asientos en cuero" son opciones incompatibles). También es posible volver a un estado anterior del carro de la compra.

El sistema debe administrar los pedidos. Debe ser capaz de calcular los impuestos en función del país de entrega del vehículo. También debe gestionar los pedidos pagados al contado y aquellos que están ligados a una petición de crédito. Para ello, se tendrá en
cuenta las peticiones de crédito. El sistema administra los estados del pedido: en curso, validado y entregado.

Al realizar el pedido de un vehículo, el sistema construye el conjunto de documentos necesarios como la solicitud de matriculación, el certificado de cesión y la orden de pedido. Estos documentos estarán disponibles en formato PDF o en formato HTML.

El sistema también permite rebajar los vehículos de difícil venta, como por ejemplo aquellos que se encuentran en stock pasado un tiempo.

También permite realizar una gestión de los clientes, en particular de empresas que poseen filiales para proporcionarles, por ejemplo, la compra de una flota de vehículos.

Tras la virtualización del catálogo, es posible visualizar animaciones asociadas a un vehículo. El catálogo puede presentarse con uno o tres vehículos por cada línea de resultados.

La búsqueda en el catálogo puede realizarse con ayuda de palabras clave y de operadores lógicos (y, o).

Es posible acceder al sistema mediante una interfaz web clásica o a través de un sistema de servicios web.

## Clasificación de los patrones

- **Los patrones creacionales** proporcionan mecanismos de creación de objetos que incrementan la flexibilidad y la reutilización de código existente.

- **Los patrones estructurales** explican cómo ensamblar objetos y clases en estructuras más grandes a la vez que se mantiene la flexibilidad y eficiencia de la estructura.

- **Los patrones de comportamiento** se encargan de una comunicación efectiva y la asignación de responsabilidades entre objetos.