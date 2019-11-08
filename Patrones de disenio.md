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
>Un ejemplo en particular es la implementacion de un Programa de operaciones aritmeticas
>> ***Nota***:Tratar de usar en la clase seccion en el programa de columnas

  ![Estrategia](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Estrategia.PNG)

## Patron decorador

  * Provee un mecanismo para colocar un nuevo comportamiento y/o estado a un objeto.
  * El objeto no sabe que esta siendo decorador.
  * Tiene una instancia de la clase original y tambien desciende de ella
  * No se necesita una superclase con todas las caracteristicas.
  * Cada decoracion es independiente de las demas.
  * Podemos colocarlas según las necesitamos
  * No depende de la herencia para adicionar nuevos comportamientos.
  * Uso de interfaces o clases abstractas.

#### Partes importantes

  * **Componente**: Clase original que esta siendo decorada y a la que se le adcionan o mejoran comportamientos.
  * **IComponente (interfaz)**: La interfaz que identifica a los objetos que pueden ser decorados.
  * **Opercacion**: La Opercacion en Componente que puede ser reemplazada
  * **Decorador**: La clase que implementa a IComponente y adiciona el estado o comportamiento.

>Decorador desde clase abstractas

  ![Decorador_Clase_abstracta](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Decorador.PNG)

  >Decorador desde interfaz

  ![Decorador_Clase_interfaz](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Decorador_Interfaz.PNG)

#### Cuando usarlo

  * Tenemos una clase a la que se necesita adicionar comportamientos, pero no es posible/recomendable hacer herencia.
  * Se desea adicionar comportamientos de forma dinamica.
  * Hacer cambios a un objeto de la clase sin modificar a otros de la misma clase.
  * Deseamos evitar hacer clase hijas, pues acabariamos con muchas clases.

### Desventajas

  * El decorador y el objeto al que envuelve no son del mismo tipo.
  * Podemos acabar con muchos objetos en memoria
  * Si se usa indiscriminadamente, puede complicar el mantenimiento.

> ***Nota***: Podria evitar el uso del deepclone en los programas
