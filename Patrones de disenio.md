# Patrones de disenio

1. Los Patrones de disenio encapsulan formas comunes de resolver problemas
2. Solucion simple,reusable, facil mantenimiento y elegante
3. Son 23 patrones escensiales
4. Es un catalogo de soluciones que muestran las interacciones entre los objetos que los programadores encuentran utiles.


## Clasificacion

 **Creacion, estructura y comportamiento**
 1. **Creacion**: Crean los objetos, en lugar de instanciarlos. Dan flexibilidad sobre que objetos necesitamos en que comportamiento.
 2. **estructura**: Ayudan a agrupar los objetos en estructuras mas grandes.
 3. **comportamiento**: Ayudan a definir la comunicacion entre objetos y como se controla el flujo.


## Ventajas

* Mantiene las clases separadas
*  Hacen que el codigo sea mas facil de entender entre programadores


## Algunos principios de diseño

* Programar a una interfaz y no a una implementacion.
* Favorecer la composicion sobre la herencia.

## Patron de estrategia

* Se forma con una familia de algoritmos que están encapsulado
* El cliente selecciona que algoritmo utilizar
* El objetivo es hacer esos algoritmos intercambiables y usar el mejor para cada caso.
* Puede hacerse via herencia o con implementacion de interfaz.
* Cambios de algoritmo en tiempos de ejecucion.

### Casos de aplicacion

* Salvar un archivo en diferentes formatos
* Compresion con diferentes algoritmos
* Formas de presentar información

#### Partes importantes

  * **Contexto**: Una clase que contiene la información de Contexto sobre la cual trabajaran los algoritmos.
  * **IEstrategia (interfaz)**: Define una interfaz comun a todas las estrategias (algoritmos).
  * ***Estrategia n*** : implementacion de un algoritmo en particular.

  ![Estrategia](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Estrategia.PNG)
