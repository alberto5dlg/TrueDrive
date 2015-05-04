$(document).ready(function () {
    $("#modifyPass").click(function () {
        if (checkPass()) {
            var p = $("#pass").val();
            var p2 = $("#pass2").val();
            var em = $(".user").text();
            var data = JSON.stringify({ pass: p, pass2: p2, email: em });
            update(data);
        }
    })
})

function update(data) {
    $.ajax({
        type: "POST",
        url: "UserAccount.aspx/updatePass",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (value) {
                window.location.href = "/Pages/Success.aspx?op=passwordRecovered";
        },
        error: function () {
            alert("An error ocurred");
        }
    })
}

function checkPass() {
    var blank = 0;
    var not_valid = 0;
    var valid_pass = /(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})$/;
    $(":password").each(function () {
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