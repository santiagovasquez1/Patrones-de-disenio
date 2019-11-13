# Proxy

* El patron da soporte a objetos que controlan la creacion y el acceso a otros objetos.
* Un ejemplo de Proxy puede ser el mecanismo para registrarse y hacer login a un sitio web. No se tiene acceso a determinados objetos hasta que el usuario no este registrado y lleve a cabo el login de forma correcte.
* Otro ejemplo se usa para representar  a un objeto que toma tiempo en crearse, de esta forma el cliente piensa que esta comunicado con el objeto.
* Con ADO.NET hace uso de proxy para llevar a cabo la conectividad con la base de datos.

>> ***Nota*** Usar para el login de los usuarios en los programas de fc

## Partes importantes

* **ISujeto**: Interfaz comun de los proxy y sujetos. Esto permite usarlos e intercambiarlos cuando sea necesario.
* **Sujeto**: La clase que es representada por el proxy, la clase que se desea usar una vez el proxy lo permita.
* **Proxy**: LA clase que crea, controla y da acceso al sujeto.
* **Peticion**: Una operación en el sujeto que enviada via el proxy.

![Proxy](https://github.com/santiagovasquez1/Patrones-de-disenio/blob/master/Proxy.PNG)

## Tipos de proxy

* **Virtual**: Da la creación de un objeto a otro.
* **Autentificación**: Verifica que los permisos de acceso sean los adecuados.
* **Remoto**: Codifica las peticiones y las envia por la red.
* **Smart**: Adiciona o modifica las peticiones antes de eniarlas.
