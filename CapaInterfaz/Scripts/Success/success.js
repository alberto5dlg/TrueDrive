$(document).ready(function () {
    var header = $(".headerWrap");
    var msg = $(".success");
    var url = window.location.href;
    var found = false;
    var op = "";

    for (var i = 0; i < url.length; i++) { //Get the op parameter
        if (url[i] == "=") {
            found = true;
        }
        else {
            if (found) {
                op += url[i];
            }
        }
    }

    var redirect = RedirectTo(op, header, msg);

    $(".successButton").click(function () {
        window.location.href = redirect;
    })

})

function RedirectTo(op, header, msg) {
    var redirect = "";
    switch (op) {
        case "updatedPassword":
            header.text("Cambio de Contraseña");
            msg.text("El cambio de su contraseña se ha realizado con éxito.");
            redirect = "/Pages/UserAccount.aspx";
            break;
        case "updatedUser":
            header.text("Información personal Actualizada");
            msg.text("El cambio de su información personal se ha realizado con éxito.");
            redirect = "/Pages/UserAccount.aspx";
            break;
        case "updatedAddress":
            header.text("Direcciones");
            msg.text("El cambio de sus direcciones se ha realizado con éxito.");
            redirect = "/Pages/UserAccount.aspx";
            break;
        case "passwordRecovered":
            header.text("Restablecimiento de contraseña");
            msg.text("El restablecimiento de su contraseña se ha realizado con éxito. Por favor, compruebe que puede acceder sin problemas con su nueva contraseña.");
            redirect = "/Pages/Login.aspx";
            break;
        case "recoveringPassword":
            header.text("Restablecimiento de contraseña");
            msg.text("Se le han enviado las instrucciones a su e-mail. Por favor, siga los pasos indicados para restablecer su contraseña.");
            redirect = "/Pages/Login.aspx";
            break;
        case "recoverFailed":
            header.text("Restablecimiento de contraseña");
            msg.text("El e-mail introducido no existe. Por favor, introduzca un e-mail que se encuentre registrado en Decor Hogar.");
            redirect = "/Pages/Login.aspx";
            break;
        case "userInserted":
            header.text("Registro completo");
            msg.text("Enhorabuena, ya se ha registrado correctamente en Decor Hogar. Por favor, compruebe que puede loguearse sin ningun problema.");
            redirect = "/Pages/Login.aspx";
            break;
        default:
            $(".successButton").hide();
            $(".successContainer").find("img").hide();
            header.text("Sin acceso");
            msg.text("No tiene permiso para acceder a la funcionalidad.");          
            window.location.href = "/Pages/Home.aspx";
            break;
    }
    return redirect;
}