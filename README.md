# Tp-Prog-VentaJuegosDigitales
Descripción del sistema:
El sistema consiste en una tienda virtual dedicada a la venta de videojuegos digitales.
La aplicación permite gestionar la venta de copias digitales de videojuegos, administrar clientes, proveedores, pedidos y formas de pago. Además, registra cada compra realizada para mantener un historial completo de las transacciones.

Entidades principales:
Cliente: representa a los usuarios que compran los videojuegos. Contiene datos personales como nombre, apellido, DNI, email, dirección y telefono.
Producto: son los videojuegos digitales disponibles para la venta. Cada producto tiene un nombre, precio, stock, clave digital y un proveedor asociado.
Proveedor: son las empresas o distribuidores que proveen los videojuegos al sistema. Incluye el nombre de la empresa, contacto y correo electrónico.
Pedido: representa la compra que realiza un cliente. Incluye una descripción del pedido, los productos comprados, la forma de pago utilizada y el cliente asociado a la compra.
FormaPago: define los métodos de pago disponibles en la tienda, como tarjeta, transferencia, etc.

Relaciones entre las entidades:
-Un cliente puede realizar muchos pedidos → (1 a N).
-Cada pedido pertenece a un solo cliente → (N a 1).
-Un pedido puede incluir muchos productos, y un producto puede estar en muchos pedidos → (N a N).
-Esta relación se resuelve mediante una entidad intermedia (DetallePedido o una lista de productos dentro de Pedido).
-Un pedido tiene una forma de pago → (N a 1).
-Una forma de pago puede aplicarse a muchos pedidos → (1 a N).
-Un producto pertenece a un proveedor → (N a 1).
-Un proveedor puede ofrecer muchos productos → (1 a N).

DER:
<img width="1062" height="656" alt="DER" src="https://github.com/user-attachments/assets/2ca8413d-782d-4270-bb18-8219eb4689d1" />


Doc drive:
https://docs.google.com/document/d/1GM5X5mPZlvRYGbJvCl9mWF3hcZ_So_T8BPoKl4t9tVU/edit?usp=sharing

Integracion de c/capa en la base de datos

-El usuario ingresa los datos en la capa de presentación.

-La capa de presentación envía la información a la capa de negocio.

-La capa de negocio valida los datos y llama a la capa de datos.

-La capa de datos guarda la información en la base de datos.

-La capa de presentación muestra un mensaje de confirmación al usuario.
