
function MostrarPaso1() {
    //$("#Contendor1").css("display", "block");
    //$("#Contendor2").css("display", "none");
    //$("#Contendor3").css("display", "none");
    $("#Contendor1").show(400);
    $("#Contendor2").hide(400);
    $("#Contendor3").hide(400);
}

function MostrarPaso2() {
    $("#Contendor1").hide(400);
    $("#Contendor2").show(400);
    $("#Contendor3").hide(400);
}

function MostrarPaso3() {
    $("#Contendor1").hide(400);
    $("#Contendor2").hide(400);
    $("#Contendor3").show(400);
}

//$("#TipoPaquete").change(function () {
//    var seleccion = $("#TipoPaquete").val();
//    var t = 0;
//});

function VerificarTipoPaquete() {

    var seleccion = $("#TipoPaquete").val();
    var t = 0;

    if (seleccion == "Paquete") {
        $("#mostrarAltoProducto").show(400);
        $("#mostrarAnchoProducto").show(400);
        $("#mostrarLargoProducto").show(400);
    }
    else {
        $("#mostrarAltoProducto").hide(400);
        $("#mostrarAnchoProducto").hide(400);
        $("#mostrarLargoProducto").hide(400);
    }

}

function GuardarEnvio() {
    var ListaClientes = [];
    var ListaProductos = [];

    var cliente = {

        IDENTIFICACION: $("#IdentificacionEnvia").val(),
        NOMBRES: $("#NombreEnvia").val(),
        APELLIDOS: $("#ApellidoEnvia").val(),
        DIRECCION: $("#DireccionEnvia").val(),
        TELEFONO: $("#TelefonoEnvia").val(),
        TIPO: "Remitente",
    }

    ListaClientes.push(cliente);

    var cliente = {

        IDENTIFICACION: $("#IdentificacionRecibe").val(),
        NOMBRES: $("#NombreRecibe").val(),
        APELLIDOS: $("#ApellidoRecibe").val(),
        DIRECCION: $("#DireccionRecibe").val(),
        TELEFONO: $("#TelefonoRecibe").val(),
        TIPO: "Destinatario",
    }

    ListaClientes.push(cliente);

    var FacturaDTO = {

        PESO: $("#PesoProducto").val(),
        ALTO: $("#AltoProducto").val(),
        ANCHO: $("#AnchoProducto").val(),
        LARGO: $("#LargoProducto").val(),
        DESCRIPCION: $("#DescripcionProducto").val(),
        ListaClientes: ListaClientes
    }

    var valorFactura = 0;
    var valorFacturaDecimal = 0;

    if ($("#PesoProducto").val() <= 2 && $("#TipoPaquete").val() == "Documento") {
        valorFactura = valorFactura + 8000;
    }

    else if ($("#TipoPaquete").val() == "Paquete") {
        valorFactura = valorFactura + ($("#PesoProducto").val() * 4000);
        valorFactura = valorFactura + (($("#AltoProducto").val() * $("#AnchoProducto").val() * $("#LargoProducto").val()) * 200);
    }

    valorFacturaDecimal = formatNumberES(valorFactura);
    FacturaDTO.VALOR = valorFactura;

    Swal.fire({
        title: 'Valor factura: $' + valorFactura,
        text: "¿Desea continuar con el envío?",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: 'green',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Aceptar',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {

            var data = { FacturaDTO };

            $.post("GuardarEnvio/Home", data).done(function () {

                Swal.fire(
                    'Enviado!',
                    'Su registro ha sido guardado',
                    'success'
                ).then(() => {
                    window.location = "ListadoEnvios";
                });

            }).fail();
        }
    })
}

const formatNumberES = (n, d = 0) => {
    n = new Intl.NumberFormat("es-ES").format(parseFloat(n).toFixed(d))
    if (d > 0) {
        // Obtenemos la cantidad de decimales que tiene el numero
        const decimals = n.indexOf(",") > -1 ? n.length - 1 - n.indexOf(",") : 0;

        // añadimos los ceros necesios al numero
        n = (decimals == 0) ? n + "," + "0".repeat(d) : n + "0".repeat(d - decimals);
    }
    return n;
}