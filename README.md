# Tp-Prog-VentaJuegosDigitales
Tienda Virtual de Venta de juegos digitales
La pagina debe poder vender copias de juegos (de formato digital) para multiples plataformas de videojuegos. Debera gestionar multiples pedidos de juegos, generar facturas y cargarlas a una base de datos para tener registro de las compras.

Entidades principales:
-Cliente → los usuarios que compran juegos
-Juego → los productos digitales a la venta
-Pedido → la compra que hace un cliente
-DetallePedido → qué juegos incluye cada pedido
-MétodoPago → cómo paga el cliente (tarjeta, PayPal, etc.)
-Plataforma → en qué plataforma se puede usar el juego (Steam, PlayStation, Xbox, etc.)

Relaciones:
-Un cliente puede hacer muchos pedidos → (1 a N)
-Un pedido pertenece a un cliente → (N a 1)
-Un pedido puede tener muchos juegos → (N a N, resuelto con DetallePedido)
-Un juego puede estar en muchos pedidos
-Un pedido tiene un método de pago → (N a 1)
-Un juego pertenece a una plataforma → (N a 1)

DER:
<img width="935" height="618" alt="image" src="https://github.com/user-attachments/assets/9d3a9791-a52c-4ad9-a2a4-36e142131805" />

Doc drive:
https://docs.google.com/document/d/1GM5X5mPZlvRYGbJvCl9mWF3hcZ_So_T8BPoKl4t9tVU/edit?usp=sharing

Integracion de c/capa en la base de datos

-El usuario ingresa los datos en la capa de presentación.

-La capa de presentación envía la información a la capa de negocio.

-La capa de negocio valida los datos y llama a la capa de datos.

-La capa de datos guarda la información en la base de datos.

-La capa de presentación muestra un mensaje de confirmación al usuario.
