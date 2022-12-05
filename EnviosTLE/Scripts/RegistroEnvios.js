
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
    var ListaClientes = []
    var FacturaDTO = {

        
        IDENTIFICACION: $("#IdentificacionEnvia").val(),
         
        NOMBRES: $("#NombreEnvia").val(),
        APELLIDOS: $("#ApellidoEnvia").val(),
        DIRECCION: $("#DireccionEnvia").val(),
        TELEFONO: $("#TelefonoEnvia").val(),
        TIPO: $("#TipoEnvia").val(),
        ID_FACTURA

    }

}