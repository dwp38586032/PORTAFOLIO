function verificarActualizaciones() {
    var pedidoId = localStorage.getItem('ordenPedidoId');
    if (pedidoId) { // Asegúrate de que existe un pedidoId antes de hacer la llamada
        $.ajax({
            url: `/Reserva/VerificarActualizacion?pedidoId=${pedidoId}`,
            type: 'GET',
            success: function (response) {
                // Suponiendo que 'response' es un objeto que contiene el estado.
                if (response.estado !== $('#estado-actual').text()) {
                    $('#estado-actual').text(response.estado);
                    // Actualiza la barra de progreso si es necesario
                    // Por ejemplo:
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

// Convertir el estado a un valor de ancho para la barra de progreso
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

// Iniciar el polling
setInterval(verificarActualizaciones, 3000); // 30 segundos


function limpiarPrecio(precio) {
    // Elimina el símbolo del dólar y cualquier otro carácter que no sea número o punto decimal
    return precio.replace(/[^0-9.]+/g, "");
}

var tasaDeCambio = 871; // Este valor debe ser actualizado con la tasa de cambio actual

function convertirCLPaUSD(precioEnCLP) {
    return precioEnCLP / tasaDeCambio;
}

function calcularTotalEnUSD() {
    var totalEnCLP = 0;
    document.querySelectorAll('li[data-precio]').forEach(function (item) {
        var precioLimpio = limpiarPrecio(item.getAttribute('data-precio'));
        totalEnCLP += parseFloat(precioLimpio);
    });
    var totalEnUSD = convertirCLPaUSD(totalEnCLP);
    return totalEnUSD.toFixed(2); // Formatea el total a dos decimales en USD
}

function initPayPalButton() {
    paypal.Buttons({
        // ... configuración del botón ...
        createOrder: function (data, actions) {
            var total = calcularTotalEnUSD(); // Calcular el total de la orden

            return actions.order.create({
                purchase_units: [{
                    description: "Total de tu pedido",
                    amount: {
                        currency_code: "USD",
                        value: total // Usar el total calculado para la orden
                    }
                }]
            });
        },
        onApprove: function (data, actions) {
            return actions.order.capture().then(function (orderData) {
                // Aquí podrías hacer cosas como:
                // - Mostrar una confirmación en la página
                console.log('Order captured:', orderData);

                // - Registrar la transacción en tu base de datos
                // - Enviar al usuario a una página de agradecimiento
                window.location.href = '/plato/';

                // - Enviar un correo electrónico de confirmación (esto normalmente se haría en el servidor)
            });
        },

        onError: function (err) {
            // Aquí podrías hacer cosas como:
            // - Mostrar un mensaje de error al usuario
            console.error('Error during payment:', err);
            alert('Ocurrió un error durante el proceso de pago. Por favor, intenta de nuevo.');

            // - Registrar el error en algún lado para su revisión posterior
        }
    }).render('#paypal-button-container');
}
initPayPalButton();