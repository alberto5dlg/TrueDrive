$(document).ready(function () {
    $(".logginList").find("label").hide();

    $("#loginButton").click(function () {
        var email = $(".logginList").find("#emailM").find("input").val();
        var pass = $(".logginList").find("#passM").find("input").val();
        checkBlank();
        if(email!="" && pass!="")
            checkUser(email, pass);
    })

    $("#registerUser").click(function () {
        if (chechkRegisterBlank()) {
            if (checkRegister()) {                
                if (checkEmail($("#rEmail").find("input").val())) {
                    var email = $("#rEmail").find("input").val();
                    var pass = $("#rPass").find("input").val();
                    var pass2 = $("#rPass2").find("input").val();
                    var name = $("#rName").find("input").val(); 
                    var surnames = $("#rSurnames").find("input").val();
                    var phone = $("#rPhone").find("input").val();
                    insertUser(email, pass, pass2, name, surnames, phone);
                }
            }
        }
    })

});


function checkBlank() {
    $(".logginList").find("li").each(function () {
        if (!$(this).find("input").val()) {
            if ($(this).attr("id") == "emailM") {
                $(this).find("label").text("Introduce el e-mail");
                $(this).find("label").show();
            }
            else {
                $(this).find("label").text("Introduce la contraseña");
                $(this).find("label").show();
            }
        }
    })
}

function chechkRegisterBlank() {
    var blank = 0;
    $(".registerList").find("li").each(function () {
        if (!$(this).find("input").val()) {
            blank++;
            var id = $(this).attr("id");
            switch (id) {
                case "rEmail":
                    $(this).find("label").text("Introduce el e-mail");
                    break;
                case "rPass":
                    $(this).find("label").text("Introduce la contraseña");
                    break;
                case "rPass2":
                    $(this).find("label").text("Introduce la contraseña");
                    break;
                case "rName":
                    $(this).find("label").text("Introduce el nombre");
                    break;
                case "rSurnames":
                    $(this).find("label").text("Introduce los apellidos");
                    break;
                case "rPhone":
                    $(this).find("label").text("Introduce el teléfono");
                    break;
            }
        }
        else 
            $(this).find("label").text("");
    })

    if (blank > 0)
        return false;
    else
        return true;
}

function checkRegister() {
    var emailValid = /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$/;
    var passValid = /(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})$/;
    var nameValid = /^[a-zA-ZáéíóúÁÉÍÓÚàèìòùÀÈÌÒÙ''-'\s]{1,40}$/;
    var phoneValid = /^[0-9]{2,3}-? ?[0-9]{6,7}$/;

    var invalid = 0;
    $(".registerList").find("li").each(function () {
        var id = $(this).attr("id");
        var val = $(this).find("input").val();
        switch (id) {
            case "rEmail":
                if (emailValid.test(val)) {
                    $(this).find("label").text("");
                }
                else {
                    $(this).find("label").text("E-mail no válido");
                    invalid++;
                }
                break;
            case "rPass":
                if (!passValid.test(val)) {
                    $(this).find("label").text("La contraseña no es válida");
                    invalid++;
                }
                else
                    $(this).find("label").text("");
                break;
            case "rPass2":
                if (!passValid.test(val)) {
                    $(this).find("label").text("La contraseña no es válida");
                    invalid++;
                }
                else {
                    if (val != $("#rPass").find("input").val()) {
                        $(this).find("label").text("Las contraseñas no coinciden");
                        invalid++;
                    }
                    else
                        $(this).find("label").text("");
                }                   
                break;
            case "rName":
                if (!nameValid.test(val)) {
                    $(this).find("label").text("Nombre no válido");
                    invalid++;
                }
                else
                    $(this).find("label").text("");
                break;
            case "rSurnames":
                if (!nameValid.test(val)) {
                    $(this).find("label").text("Apellidos no válidos");
                    invalid++;
                }
                else
                    $(this).find("label").text("");
                break;
            case "rPhone":
                if (!phoneValid.test(val)) {
                    $(this).find("label").text("Teléfono no válido");
                    invalid++;
                }
                else
                    $(this).find("label").text("");
                break;
        }
    })

    if (invalid > 0)
        return false;
    else
        return true;
}

function checkEmail(val) {
    var invalid = 0;
    $.ajax({
        type: "POST",
        url: "Register.aspx/isValidEmail",
        data: "{email :'" + val + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (value) {
            var available = value.d;
            if (available == "Is not available") {
                $("#rEmail").find("label").text("E-mail ya registrado");
                invalid++;
            }
            else {
                $("#rEmail").find("label").text("");
            }
        }
    })
    if (invalid > 0)
        return false;
    else
        return true;
}

function checkUser(e, p) {
    var data = JSON.stringify({email: e, pass: p});
    $.ajax({
        type: "POST",
        url: "Login.aspx/loginMobile",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (value) {
            if (value.d == "Pass") {
                $(".logginList").find("#emailM").find("label").hide();
                $(".logginList").find("#passM").find("label").text("La contraseña no es correcta");
                $(".logginList").find("#passM").find("label").show();
            }
            else if (value.d == "Email") {
                $(".logginList").find("#passM").find("label").hide();
                $(".logginList").find("#emailM").find("label").text("El e-mail introducido no es correcto");
                $(".logginList").find("#emailM").find("label").show();
            }
            else if (value.d == "Ok") {
                window.location.href = "http://decorhogar.net/";
            }
        }
    })
}

function insertUser(e, p, p2, n, surn, phon) {
    var data = JSON.stringify({email: e, pass: p, pass2: p2, name: n, cognames:surn, phone: phon});
    $.ajax({
        type: "POST",
        url: "Login.aspx/insertUser",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.d == "inserted")
                window.location.href = "/Pages/Success.aspx?op=userInserted";
        },
        error: function () {
            alert("An error ocurred");
        }
    })
}