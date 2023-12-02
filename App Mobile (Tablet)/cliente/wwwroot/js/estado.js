function verificarActualizaciones() {
    var pedidoId = localStorage.getItem('ordenPedidoId');
    if (pedidoId) { 
        $.ajax({
            url: `/Reserva/VerificarActualizacion?pedidoId=${pedidoId}`,
            type: 'GET',
            success: function (response) {
                if (response.estado !== $('#estado-actual').text()) {
                    $('#estado-actual').text(response.estado);

                    var progressBarWidth = getProgressBarWidth(response.estado);
                    $('.progress-bar').css('width', progressBarWidth + '%');
                }
            },
            error: function (error) {
                console.error('Error al verificar actualizaciones:', error);
            }
        });
    } else {
        console.error('No se encontró el ID del pedido en localStorage.');
    }
}

function getProgressBarWidth(estado) {
    switch (estado) {
        case 'pendiente':
            return 30;
        case 'cocinando':
            return 60;
        case 'sirviendo':
            return 90;
        default:
            return 0;
    }
}

setInterval(verificarActualizaciones, 3000); 


function limpiarPrecio(precio) {
    return precio.replace(/[^0-9.]+/g, "");
}

var tasaDeCambio = 871; 

function convertirCLPaUSD(precioEnCLP) {
    return precioEnCLP / tasaDeCambio;
}

function calcularTotalEnUSD() {
    var totalEnCLP = 0;
    document.querySelectorAll('li[data-precio]').forEach(function (item) {
        var precioLimpio = limpiarPrecio(item.getAttribute('data-precio'));
        totalEnCLP += parseFloat(precioLimpio);
    });

    var propina = parseFloat(document.getElementById('propina').value) || 0;

    totalEnCLP += propina; 

    var totalEnUSD = convertirCLPaUSD(totalEnCLP);
    return totalEnUSD.toFixed(2); 
}


function calcularTotalEnCLP() {
    var totalEnCLP = 0;
    document.querySelectorAll('li[data-precio]').forEach(function (item) {
        var precio = item.getAttribute('data-precio');
        
        var precioLimpio = limpiarPrecio(precio);
        totalEnCLP += parseFloat(precioLimpio);
    });
    return totalEnCLP; 
}


function initPayPalButton() {
    paypal.Buttons({
        
        createOrder: function (data, actions) {
            var total = calcularTotalEnUSD(); 

            return actions.order.create({
                purchase_units: [{
                    description: "Total de tu pedido",
                    amount: {
                        currency_code: "USD",
                        value: total 
                    }
                }]
            });
        },
        onApprove: function (data, actions) {
            return actions.order.capture().then(function (orderData) {
                console.log('Order captured:', orderData);

                var totalCLP = calcularTotalEnCLP();
                var propina = parseFloat(document.getElementById('propina').value) || 0; 
                var storedOrdenPedidoId = localStorage.getItem('ordenPedidoId');

                $.post('/Reserva/CrearBoleta', {
                    ordenPedidoId: storedOrdenPedidoId,
                    totalEnCLP: totalCLP,
                    propina: propina  

                })
                    .done(function (data) {
                        console.log('Boleta creada:', data);
                        window.location.href = '/Reserva/Gracias';
                    })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                        console.error('Error al crear la boleta:', textStatus, errorThrown);
                        alert('Error al crear la boleta: ' + textStatus);
                    });
            });
        },
        onError: function (err) {
            console.error('Error during payment:', err);
            alert('Ocurrió un error durante el proceso de pago. Por favor, intenta de nuevo.');

        }
    }).render('#paypal-button-container');
}
initPayPalButton();