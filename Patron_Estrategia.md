# Patron de estrategia

* Se forma con una familia de algoritmos que están encapsulado
* El cliente selecciona que algoritmo utilizar
* El objetivo es hacer esos algoritmos intercambiables y usar el mejor para cada caso.
* Puede hacerse via herencia o con implementacion de interfaz.
* Cambios de algoritmo en tiempos de ejecucion.

## Casos de aplicacion

* Salvar un archivo en diferentes formatos
* Compresion con diferentes algoritmos
* Formas de presentar información

### Partes importantes

  * **Contexto**: Una clase que contiene la información de Contexto sobre la cual trabajaran los algoritmos.
  * **IEstrategia (interfaz)**: Define una interfaz comun a todas las estrategias (algoritmos).
  * ***Estrategia n*** : implementacion de un algoritmo en particular.
>Un ejemplo en particular es la implementacion de un Programa de operaciones aritmeticas
>> ***Nota***:Tratar de usar en la clase seccion en el programa de columnas

  ![Estrategia](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Estrategia.PNG)
