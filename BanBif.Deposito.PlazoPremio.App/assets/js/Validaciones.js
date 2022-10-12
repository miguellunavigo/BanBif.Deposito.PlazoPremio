function ValidateDNI(e) {
    if ($(e.currentTarget).attr("maxlength") == $(e.currentTarget).val().length) {
        $("#spanErrorDNI").html("");

    } else {
        $("#spanErrorDNI").html("Ingrese un DNI válido");
    }
}

function ValidateCelular(e) {
    if ($(e.currentTarget).attr("maxlength") == $(e.currentTarget).val().length) {
        $("#spanErrorCelular").html("");

    } else {
        $("#spanErrorCelular").html("Ingrese un Celular válido");
    } 
}


function ValidateEmail(e) {
    var email = document.getElementById("Email").value;
    var spanError = document.getElementById("spanErrorEmail");
    var expr = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
    if (!expr.test(email)) {
        spanError.innerHTML = "Ingrese un correo válido";
    } else {
        spanError.innerHTML = "";
    }
}

function soloLetras(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    letras = " áéíóúabcdefghijklmnñopqrstuvwxyz";
    especiales = "8-37-39-46";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (letras.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}
function soloNumeros(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    letras = "0123456789";
    especiales = "8-37-39-46";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (letras.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}



