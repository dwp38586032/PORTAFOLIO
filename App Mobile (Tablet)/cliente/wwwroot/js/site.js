// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('.order-button').click(function () {
    var productId = $(this).data('product-id'); 
    var productName = $(this).data('product-name'); 
    var price = $(this).data('price'); 

    $.ajax({
        url: '/api/PedidosApi/crear',
        method: 'POST',
        contentType: 'application/json',
        data: JSON.stringify({ ProductoId: productId, ProductoNombre: productName, Precio: price }),
        success: function (response) {
            alert('Pedido realizado con éxito!');
        },
        error: function () {
            alert('Hubo un error al realizar el pedido.');
        }
    });
});
