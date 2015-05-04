$(document).ready(function () {
    getAuthenticatedUser();    
    $(":button").click(function () {        
        if ($(this).attr('id') == "modify") {
            if (checkRequired()) {
                var n = $(".userName").val();
                var e = $(".userEmail").val();
                var sur = $(".userSurnames").val();
                var p = $(".userPhone").val();
                var d = $(".userNIF").val();
                var data = JSON.stringify({ name: n, email: e, surnames: sur, phone: p, dni: d });
                var method = "updateUser"
                update(data, method);
            }
        }
        else if ($(this).attr('id') == "modifyAddress") {
            if (checkAddress()) {
                var addr = $("#user_address").val();
                var pro = $("option:selected", "#provincias").text();
                var z = $("#zip").val();
                var countr = $("#country").val();
                var em = $(".userEmail").val();
                var data = JSON.stringify({ address: addr, province: pro, country: countr, zip: z, email: em });
                var method = "updateAddress"
                update(data, method);
            }
        }
        else if ($(this).attr('id') == "modifyPass") {
            if (checkPass()) {
                var p = $("#pass").val();
                var p2 = $("#pass2").val();
                var em = $(".userEmail").val();
                var data = JSON.stringify({pass: p, pass2: p2, email: em});
                var method = "updatePass"
                update(data, method);
            }
        }
    })
})

function checkRequired() {
    var valid_name = /^[a-zA-ZáéíóúÁÉÍÓÚàèìòùÀÈÌÒÙ''-'\s]{1,40}$/;
    var valid_phone = /^[0-9]{2,3}-? ?[0-9]{6,7}$/;
    var valid_nif = /^(X(-|\.)?0?\d{7}(-|\.)?[A-Z]|[A-Z](-|\.)?\d{7}(-|\.)?[0-9A-Z]|\d{8}(-|\.)?[A-Z])$/;
    var blank = 0;
    var not_valid = 0;
    $(".required").each(function () {
        if (!$(this).val()) {
            $("label[for='" + $(this).attr("id") + "']").text("Campo obligatorio");
            $("label[for='" + $(this).attr("id") + "']").show();
            $(".error").show();
            blank++;
        }
        else
            $("label[for='" + $(this).attr("id") + "']").hide();
    })

    $(":text").each(function () {
        if ($(this).val() != "") {
            if ($(this).attr("id") == "userName") {
                var value = $(this).val();
                if (!valid_name.test(value)) {
                    $("label[for='" + $(this).attr("id") + "']").text("El nombre introducido no es correcto");
                    $("label[for='" + $(this).attr("id") + "']").show();
                    $(".error").show();
                    not_valid++;
                }
                else {
                    $("label[for='" + $(this).attr("id") + "']").hide();
                }
            }
            else if ($(this).attr("id") == "userSurnames") {
                var value = $(this).val();
                if (!valid_name.test(value)) {
                    $("label[for='" + $(this).attr("id") + "']").text("Los apellidos introducidos no son correctos");
                    $("label[for='" + $(this).attr("id") + "']").show();
                    not_valid++;
                }
                else {
                    $("label[for='" + $(this).attr("id") + "']").hide();
                }
            }
            else if ($(this).attr("id") == "userPhone") {
                var value = $(this).val();
                if (!valid_phone.test(value)) {
                    $("label[for='" + $(this).attr("id") + "']").text("El teléfono introducido no es correcto");
                    $("label[for='" + $(this).attr("id") + "']").show();
                    not_valid++;
                }
                else {
                    $("label[for='" + $(this).attr("id") + "']").hide();
                }
            }
            else if ($(this).attr("id") == "NIF") {
                var value = $(this).val();
                if (!valid_nif.test(value)) {
                    $("label[for='" + $(this).attr("id") + "']").text("El NIF no es correcto");
                    $("label[for='" + $(this).attr("id") + "']").show();
                    not_valid++;
                }
                else {
                    $("label[for='" + $(this).attr("id") + "']").hide();
                }
            }
        }
        
    })
    if (blank > 0 || not_valid > 0)
        return false;
    else
        return true;
}

function checkAddress() {
    var valid_zip = /^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$/;
    var value = $("#zip").val();
    if (!valid_zip.test(value)) {
        $("label[for='zip']").text("El código postal no es correcto");
        $("label[for='zip']").show();
        return false;
    }
    else {
        $("label[for='zip']").hide();
        return true;
    }
   
}

function checkPass() {
    var blank = 0;
    var not_valid = 0;
    var valid_pass = /(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})$/;
    $("#changePass").find(":password").each(function () {
        if (!$(this).val()) {
            $("label[for='" + $(this).attr("id") + "']").text("Campo obligatorio");
            $("label[for='" + $(this).attr("id") + "']").show();
            blank++;
        }
        else {
            $("label[for='" + $(this).attr("id") + "']").hide();
            if ($(this).attr("id") == "pass") {
                var value = $(this).val();
                if (!valid_pass.test(value)) {
                    $("label[for='" + $(this).attr("id") + "']").text("Contraseña no válida");
                    $("label[for='" + $(this).attr("id") + "']").show();
                    not_valid++;
                }
                else {
                    $("label[for='" + $(this).attr("id") + "']").hide();
                }
            }
            else {
                var value = $(this).val();
                if (!valid_pass.test(value)) {
                    $("label[for='" + $(this).attr("id") + "']").text("Contraseña no válida");
                    $("label[for='" + $(this).attr("id") + "']").show();
                    not_valid++;
                }
                else {
                    if (value != $("#pass").val()) {
                        $("label[for='" + $(this).attr("id") + "']").text("Las contraseñas no coinciden");
                        $("label[for='" + $(this).attr("id") + "']").show();
                        not_valid++;
                    }
                    else
                        $("label[for='" + $(this).attr("id") + "']").hide();
                }
            }
        }
    });

    if (not_valid > 0 || blank > 0)
        return false;
    else
        return true;
}

function getAuthenticatedUser() {
    $.ajax({
        type: "POST",
        url: "UserAccount.aspx/getUserName",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (value) {
            var us = value.d;
            setUserInfo(us);
        },
        error: function () {
            alert("An error ocurred");
        }
    })
}

function setUserInfo(user) {
    $("#userName").val(user.Name);
    $("#userSurnames").val(user.Cognames);
    $("#NIF").val(user.NIF);
    $("#userEmail").val(user.Email);
    $("#userPhone").val(user.Phone);
    $("#user_address").val(user.Address);
    $("#zip").val(user.Zip);
    $('#provincias option:contains(' + user.Province + ')').prop('selected', true);
    $("#country").val(user.Country);

}

function update(data, method) {
    $.ajax({
        type: "POST",
        url: "UserAccount.aspx/" + method,
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (value) {
            if (method == "updateUser") {
                window.location.href = "/Pages/Success.aspx?op=updatedUser";
            }
            else if (method == "updateAddress") {
                window.location.href = "/Pages/Success.aspx?op=updatedAddress";
            }
            else if (method == "updatePass") {
                window.location.href = "/Pages/Success.aspx?op=updatedPassword";
            }
        },
        error: function () {
            alert("An error ocurred");
        }
    })
}