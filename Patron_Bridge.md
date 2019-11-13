# Bridge (Puente)

* Desacopla la implementacion de la abstracción.
* Se usa cuando surge una nueva version del software pero la anterior aún se va a seguir usando con el cliente.
* Proteje de cambio al cliente, ya que su código no cambia, pues trabaja con una abstracción y no con un codigo concreto.
* El cliente indicará con que version va a trabajar.
* Una interfaz provee el mecanismo de entrada a las diferentes implementaciones de la abstracción.
* Hace que la interfaz de una o más clases parezcan que tienen la de una clase en particular.

## Ventajas

* permite que la interfaz del cliente permanezca constante sin importar los cambios que tenga la abstracción.
* Con esto evitamos recompilar al cliente, solo tenemos que recompilar el Bridge y las implementaciones necesarias.
* Esconde las implementaciones del cliente.

>> **Nota**: importante para trabajar con distintos dlls.

## Partes importantes

* **Abstracción**: La interfaz que cliente ve y conoce
* **operación**: El metodo que invoca el cliente.
* **IBridge**: La interfaz que muestra los comportamientos que pueden variar en la abstracción.
* **implementacion n**: Las diferentes implementaciones de la abstracción.
* **OperacionImp**: El metodo que implementa la operación.

![Bridge](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Bridge.PNG)
