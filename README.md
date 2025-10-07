# Tp-Prog-VentaJuegosDigitales
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
