ProductController.cs: CRUD de produtos

CartController.cs: adicionar/remover itens, ver carrinho

OrderController.cs: criar pedidos, listar, cancelar

ProductController

GET /api/store/products?category=camisetas&sort=price_desc

GET /api/store/products/{id}/reviews

POST /api/store/products/{id}/rate – avaliação de produto

CartController

POST /api/store/cart/checkout – simulação de compra

POST /api/store/cart/apply-coupon

OrderController

GET /api/store/orders/history – pedidos do user logado