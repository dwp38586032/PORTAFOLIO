

function actualizarPedido(buttonElement) {
    var pedidoId = $(buttonElement).data('id');
    var updateUrl = $(buttonElement).data('update-url');

    $.ajax({
        url: updateUrl,
        type: 'POST',
        data: { id: pedidoId },
        success: function (response) {
            var progressBarWidth = getProgressBarWidth(response.nuevoEstado);
            $('#estado-' + pedidoId).text('Estado: ' + response.nuevoEstado);
            $('#pedido-' + pedidoId + ' .progress-bar-fill').width(progressBarWidth);
        },
        error: function (error) {
            console.error("Error al actualizar el pedido:", error);
        }
    });
}

function revertirPedido(buttonElement) {
    var pedidoId = $(buttonElement).data('id');
    var revertUrl = $(buttonElement).data('revert-url');

    $.ajax({
        url: revertUrl,
        type: 'POST',
        data: { id: pedidoId },
        success: function (response) {
            var progressBarWidth = getProgressBarWidth(response.nuevoEstado);
            $('#estado-' + pedidoId).text('Estado: ' + response.nuevoEstado);
            $('#pedido-' + pedidoId + ' .progress-bar-fill').width(progressBarWidth);
        },
        error: function (error) {
            console.error("Error al revertir el pedido:", error);
        }
    });
}

function getProgressBarWidth(estado) {
    switch (estado) {
        case "pendiente": return "30%";
        case "cocinando": return "60%";
        case "sirviendo": return "90%";
        default: return "0%";
    }
}






