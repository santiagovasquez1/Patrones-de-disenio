# Composite(Compuesto)

* Nos permite crear jerarquias estructuradas con componentes sencillos o grupos de componentes, a los que se les pueden aplicar las mismas operaciones.
* El componente puede se un objeto sencillo o una coleccion de otros componentes.
* Las opreciones más comunes son : adicionar, remover, agrupar, buscar.
* Se utiliza donde necesitamos tener a los elementos de forma organizada o jerárquica.
* Ambos tipos de elementos tienen una interfaz común.

>***Nota***: Util para hacer el software de control de backup

![Arbol](https://oscarblancarteblog.com/wp-content/uploads/2014/08/arbolvslineal.png)

## Ventajas y usos.

* permite adicionar nuevos tipos de componentes siempre y cuando implementan a la interfaz.
* Los reproductores de audio o video que nos permiten organizar en álbum o listas de reproducción.
* Se utilia en **Model-View-Controller**.
* En **WinForms** es utilizado, el Form es un contenedor de otros controles.

## Variaciones.

* **Orden**: Los elementos son organizados.
* **Cache**: Si un valor se calcula constantemente a partir de los hijos, puede guardarse en el padre para no qtener que calcularlo constantemente (optimizacion de codigo).

## Elementos principales

* **IComponente**: interfaz que representa a los comportamientos que serán comunes a todos los objetos de la composición.
* **operación** : Método que lleva a cabo la operación que esperamos en un elemento de la composición.
* **Componente**: Representa un objeto sencillo que no se puede descomponer más e implementa las operaciones según su caso.
* **Compuesto**: Implementa las operaciones trabajando con una coleccion de componentes.

![Composite](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Composite.PNG)
