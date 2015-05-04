
$(document).ready(function () {
    $(".checking").hide();
    $("#try_register").click(function () {
        if (check()) {
            var email = $("#registerList").find("#email").find("input").val();
            var pass = $("#registerList").find("#pass").find("input").val();
            var pass2 = $("#registerList").find("#pass2").find("input").val();
            var name = $("#registerList").find("#user_name_area").find("input").val();
            var surname = $("#registerList").find("#user_cogname_area").find("input").val();
            var phone = $("#registerList").find("#phone").find("input").val();
            insertUser(email, pass, pass2, name, surname, phone);
        }
    })
    $("#registerList").find("#email").find("input").keydown(function () {
        $("#registerList").find("#email").find(".label").text("");
        $("#registerList").find("#email").find("i").removeClass();
    })
    $("input").blur(function () {
        var icon = $(this).parent().find("i");
        var label = $(this).parent().find(".label");
        var id = $(this).parent().attr("id");
        var val = $(this).val();
        checkingBlur(id, val, icon, label);
    })

});

function check() {
    var emailValid = /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$/;
    var passValid = /(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})$/;
    var nameValid = /^[a-zA-ZáéíóúÁÉÍÓÚàèìòùÀÈÌÒÙ''-'\s]{1,40}$/;
    var phoneValid = /^[0-9]{2,3}-? ?[0-9]{6,7}$/;
    var blank = 0;
    var invalid = 0;
    $("#registerList").find("li").each(function () {
        var id = $(this).attr("id");
        if (!$(this).find("input").val() && id!= "leyenda") {
            $(this).find("i").removeClass();
            $(this).find("i").addClass("fa fa-times fieldFail")
            $(this).find(".label").text("Campo obligatorio")
            blank++;
        }
        else {
            var val = $(this).find("input").val();
            switch (id) {
                case "email":
                    if (emailValid.test(val)) {                        
                        $.ajax({
                            type: "POST",
                            url: "Register.aspx/isValidEmail",
                            data: "{email :'" + val + "'}",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (value) {
                                $(".checking").hide();
                                var available = value.d;
                                if (available == "Is not available") {
                                    $(this).find(".label").text("El e-mail ya está registrado")
                                    $(this).find("i").removeClass();
                                    $(this).find("i").addClass("fa fa-times fieldFail")
                                    invalid++;
                                }
                                else {
                                    $(this).find("i").removeClass();
                                    $(this).find("i").addClass("fa fa-check fieldOk");
                                    $(this).find(".label").text("")
                                }
                            }
                        })
                    }
                    else {
                        $(this).find(".label").text("El e-mail no es válido")
                        $(this).find("i").removeClass();
                        $(this).find("i").addClass("fa fa-times fieldFail")
                        invalid++;
                    }
                    break;
                case "pass":
                    if (passValid.test(val)) {
                        $(this).find("i").removeClass();
                        $(this).find("i").addClass("fa fa-check fieldOk");
                    }
                    else {
                        $(this).find(".label").text("La contraseña no es válida")
                        $(this).find("i").removeClass();
                        $(this).find("i").addClass("fa fa-times fieldFail")
                        invalid++;
                    }
                    break;
                case "pass2":
                    if (passValid.test(val)) {
                        if (val == $("#pass").find("input").val()) {
                            $(this).find("i").removeClass();
                            $(this).find("i").addClass("fa fa-check fieldOk");
                        }
                        else {
                            $(this).find(".label").text("Las contraseñas no coinciden")
                            $(this).find("i").removeClass();
                            $(this).find("i").addClass("fa fa-times fieldFail")
                            invalid++;
                        }
                    }
                    else {
                        $(this).find(".label").text("La contraseña no es válida")
                        $(this).find("i").removeClass();
                        $(this).find("i").addClass("fa fa-times fieldFail")
                        invalid++;
                    }
                    break;
                case "user_name_area":
                    if (nameValid.test(val)) {
                        $(this).find("i").removeClass();
                        $(this).find("i").addClass("fa fa-check fieldOk");
                    }
                    else {
                        $(this).find(".label").text("El nombre no es válido")
                        $(this).find("i").removeClass();
                        $(this).find("i").addClass("fa fa-times fieldFail")
                        invalid++;
                    }
                    break;
                case "user_cogname_area":
                    if (nameValid.test(val)) {
                        $(this).find("i").removeClass();
                        $(this).find("i").addClass("fa fa-check fieldOk");
                    }
                    else {
                        $(this).find(".label").text("Los apellidos no son válidos")
                        $(this).find("i").removeClass();
                        $(this).find("i").addClass("fa fa-times fieldFail")
                        invalid++;
                    }
                    break;
                case "phone":
                    if (phoneValid.test(val)) {
                        $(this).find("i").removeClass();
                        $(this).find("i").addClass("fa fa-check fieldOk");
                    }
                    else {
                        $(this).find(".label").text("El teléfono no es válido")
                        $(this).find("i").removeClass();
                        $(this).find("i").addClass("fa fa-times fieldFail")
                        invalid++;
                    }
                    break;

            }
        }
    })
    if (invalid == 0 && blank == 0)
        return true;
    else
        return false;
}

function checkingBlur(id, val, icon, label) {
    var emailValid = /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$/;
    var passValid = /(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})$/;
    var nameValid = /^[a-zA-ZáéíóúÁÉÍÓÚàèìòùÀÈÌÒÙ''-'\s]{1,40}$/;
    var phoneValid = /^[0-9]{2,3}-? ?[0-9]{6,7}$/;
    var invalid = 0;
    if (val != "") {
        switch (id) {
            case "email":
                if (emailValid.test(val)) {
                    label.text("");
                    $(".checking").show();
                    $.ajax({
                        type: "POST",
                        url: "Register.aspx/isValidEmail",
                        data: "{email :'" + val + "'}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (value) {
                            $(".checking").hide();
                            var available = value.d;
                            if (available == "Is not available") {
                                label.text("El e-mail ya está registrado")
                                icon.removeClass();
                                icon.addClass("fa fa-times fieldFail")
                                invalid++;
                            }
                            else {
                                label.text("");
                                icon.removeClass();
                                icon.addClass("fa fa-check fieldOk");
                            }
                        }
                    })
                }
                else {
                    label.text("El e-mail no es válido")
                    icon.removeClass();
                    icon.addClass("fa fa-times fieldFail")
                    invalid++;
                }
                break;
            case "pass":
                if (passValid.test(val)) {
                    icon.removeClass();
                    icon.addClass("fa fa-check fieldOk");
                    label.text("");
                }
                else {
                    label.text("La contraseña no es válida")
                    icon.removeClass();
                    icon.addClass("fa fa-times fieldFail")
                    invalid++;
                }
                break;
            case "pass2":
                if (passValid.test(val)) {
                    if (val == $("#pass").find("input").val()) {
                        icon.removeClass();
                        icon.addClass("fa fa-check fieldOk");
                        label.text("");
                    }
                    else {
                        label.text("Las contraseñas no coinciden")
                        icon.removeClass();
                        icon.addClass("fa fa-times fieldFail")
                        invalid++;
                    }
                }
                else {
                    label.text("La contraseña no es válida")
                    icon.removeClass();
                    icon.addClass("fa fa-times fieldFail")
                    invalid++;
                }
                break;
            case "user_name_area":
                if (nameValid.test(val)) {
                    icon.removeClass();
                    icon.addClass("fa fa-check fieldOk");
                    label.text("");
                }
                else {
                    label.text("El nombre no es válido")
                    icon.removeClass();
                    icon.addClass("fa fa-times fieldFail")
                    invalid++;
                }
                break;
            case "user_cogname_area":
                if (nameValid.test(val)) {
                    icon.removeClass();
                    icon.addClass("fa fa-check fieldOk");
                    label.text("");
                }
                else {
                    label.text("Los apellidos no son válidos")
                    icon.removeClass();
                    icon.addClass("fa fa-times fieldFail")
                    invalid++;
                }
                break;
            case "phone":
                if (phoneValid.test(val)) {
                    icon.removeClass();
                    icon.addClass("fa fa-check fieldOk");
                    label.text("");
                }
                else {
                    label.text("El teléfono no es válido")
                    icon.removeClass();
                    icon.addClass("fa fa-times fieldFail")
                    invalid++;
                }
                break;

        }
    }
}

function insertUser(e, p, p2, n, surn, phon) {
    var data = JSON.stringify({ email: e, pass: p, pass2: p2, name: n, cognames: surn, phone: phon });
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