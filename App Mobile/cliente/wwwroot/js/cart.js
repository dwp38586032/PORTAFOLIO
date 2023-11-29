$(document).ready(function () {


    var cart = [];
    





    $('.add-to-cart-button').click(function () {
        var platoId = $(this).data('id');
        var platoNombre = $(this).data('nombre');
        var platoPrecio = $(this).data('precio');

        cart.push({ id: platoId, nombre: platoNombre, precio: platoPrecio });
        updateCartDisplay();
    });

    $('#cart-toggle').click(function () {
        $('#cart-container').toggle();
    });

    // Función para actualizar la visualización del carrito
    function updateCartDisplay() {
        var $cartItems = $('#cart-items');
        $cartItems.empty(); 
        var total = 0;

        cart.forEach(function (item, index) {
            total += item.precio;
            $cartItems.append(
                '<div class="cart-item">' +
                item.nombre + ' - ' + item.precio +
                '<button class="remove-item" data-index="' + index + '">Quitar</button>' +
                '</div>'
            );
        });

        $('#cart-total').text(total.toFixed(2));
        attachRemoveItemEvent(); 
    }

    // Función para adjuntar el evento de clic a los botones de quitar
    function attachRemoveItemEvent() {
        $('.remove-item').click(function () {
            var itemIndex = $(this).data('index');
            cart.splice(itemIndex, 1); 
            updateCartDisplay(); 
        });
    }
    $('#checkout-button').click(function () {
        var storedOrdenPedidoId = localStorage.getItem('ordenPedidoId');
        if (storedOrdenPedidoId && cart.length > 0) {
            var nombresPlatos = cart.map(function (item) {
                return item.nombre;
            });

            // Enviar los nombres de los platos al endpoint de checkout
            $.post('/Reserva/RealizarCheckout', { ordenPedidoId: storedOrdenPedidoId, nombresPlatos: nombresPlatos }, function (response) {
                if (response.success) {
                    alert('Checkout realizado con éxito.');
                    cart = [];
                    updateCartDisplay(); 
                } else {
                    alert('Hubo un problema al realizar el checkout.');
                }
            });
        } else {
            alert('No hay elementos en el carrito o no se ha verificado la reserva.');
        }
    });

    var ordenPedidoId = null;

    $('#verificar-reserva').click(function () {
        var codigoReserva = $('#codigo-reserva').val();

        $.post('/Reserva/VerificarYCrearOrdenPedido', { codigoReserva: codigoReserva }, function (data) {
            console.log(data); 

            if (data.ordenPedidoId) {
                localStorage.setItem('ordenPedidoId', data.ordenPedidoId);
                alert("Reserva verificada y orden de pedido creada.");
            } else if (data.Error) {
                alert(data.Error);
            }
        });
    });

    $('#estado-pedido').click(function () {
        var ordenPedidoId = localStorage.getItem('ordenPedidoId');
        if (ordenPedidoId) {
            window.location.href = '/Reserva'; 
        } else {
            alert('No se ha verificado una reserva.');
        }
    });

    $('#clear-order').click(function () {
        localStorage.removeItem('ordenPedidoId');
        alert('La información de la orden ha sido borrada.');
        
    });


});



