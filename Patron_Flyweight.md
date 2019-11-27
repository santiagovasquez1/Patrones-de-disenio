# Patrón Flyweight

* Permite comparir información que se encuentra en pequeños objetos que existen en grandes cantidades.
* Ayuda a reducir las necesidades de almacenamiento.
* Evita tener objetos duplicados.

## Estados del Patrón Flyweight

* **Intrinseco**: Se puede compartir a gran escala, disminuye el almacenamiento.
* **Extrinseco**: El estado se calcula en el momento.

* >El estado no compartido (unshared) es el conjunto de grupos a los que pertenece.

### Partes importantes

* **Cliente**: Es el que mantiene el estado no compartido y colecicones de flyweights.
* **Iflyweights**: La interfaz por medio de la cual los flyweights pueden recibir o actuar sobre un estado Intrinseco.
* **FlyweightFactory**: Administra a los objetos flyweight y garantiza que solo un valor es creado.
* **Flyweight** : Guarda el estado Intrinseco que se comparte a todos los objetos.

![Flyweight](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Patron_Flyweight.PNG)
