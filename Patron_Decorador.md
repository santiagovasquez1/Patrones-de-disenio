# Patron decorador

  * Provee un mecanismo para colocar un nuevo comportamiento y/o estado a un objeto.
  * El objeto no sabe que esta siendo decorador.
  * Tiene una instancia de la clase original y tambien desciende de ella
  * No se necesita una superclase con todas las caracteristicas.
  * Cada decoracion es independiente de las demas.
  * Podemos colocarlas según las necesitamos
  * No depende de la herencia para adicionar nuevos comportamientos.
  * Uso de interfaces o clases abstractas.

### Partes importantes

  * **Componente**: Clase original que esta siendo decorada y a la que se le adcionan o mejoran comportamientos.
  * **IComponente (interfaz)**: La interfaz que identifica a los objetos que pueden ser decorados.
  * **Opercacion**: La Opercacion en Componente que puede ser reemplazada
  * **Decorador**: La clase que implementa a IComponente y adiciona el estado o comportamiento.

>Decorador desde clase abstractas

  ![Decorador_Clase_abstracta](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Decorador.PNG)

  >Decorador desde interfaz

  ![Decorador_Clase_interfaz](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Decorador_Interfaz.PNG)

### Cuando usarlo

  * Tenemos una clase a la que se necesita adicionar comportamientos, pero no es posible/recomendable hacer herencia.
  * Se desea adicionar comportamientos de forma dinamica.
  * Hacer cambios a un objeto de la clase sin modificar a otros de la misma clase.
  * Deseamos evitar hacer clase hijas, pues acabariamos con muchas clases.

## Desventajas

  * El decorador y el objeto al que envuelve no son del mismo tipo.
  * Podemos acabar con muchos objetos en memoria
  * Si se usa indiscriminadamente, puede complicar el mantenimiento.

> ***Nota***: Podria evitar el uso del deepclone en los programas
