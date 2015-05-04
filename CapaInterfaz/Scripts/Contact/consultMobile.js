$(document).ready(function () {
    $(".checked").hide();
    $(".sending").hide();
    $("#email-blank").hide();
    $("#name-blank").hide();
    $("#subject-blank").hide();
    $("#buttonSend").click(function () {          
        var email = $("#userEmailM").val();
        var user = $("#userNameM").val();
        var subject = $("#subjectM").val();
        var cons = $("#consultM").val();     
        if (!onClickBlank()) {           
            if (checkEmail(email)) {
                $("#sender").hide();
                $(".sending").show();
                sendConsult(email, user, subject, cons);
            }
            else {
                $("#email-blank").text("El e-mail introducido no es válido");
                $("#email-blank").show();
            }
        }
    })
    $("input").blur(function () {
        var input = $(this).attr("id");
        var value = $(this).val();
        checkField(input, value);
    })
})


function sendConsult(em, us, sub, cons) {
    var data = JSON.stringify({email: em, user: us, subject: sub, consult: cons});
    $.ajax({
        type: "POST",
        url: "Contact.aspx/mobileConsult",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (value) {
            $(".sending").hide();
            $(".mobileContact").hide();
            $(".checked").show();
        }
    });
}

function checkField(input, value) {
    if (input == "userEmailM") {
        if (value == "") {
            $("#email-blank").show();
        }
        else
            $("#email-blank").hide();
    }
    else if (input == "userNameM") {
        if (value == "")
            $("#name-blank").show();
        else 
            $("#name-blank").hide();
    }
    else if (input == "subjectM") {
        if (value == "")
            $("#subject-blank").show();
        else 
            $("#subject-blank").hide();
    }
}

function onClickBlank() {
    var blank = false;    
    $("input").each(function () {
        if (!$(this).val() && this.id == "userEmailM") {
            $("#email-blank").show();
            blank = true;
        }
        else if(!$(this).val() && this.id == "userNameM") {
            $("#name-blank").show();
            blank = true;
        }
        else if(!$(this).val() && this.id == "subjectM"){
                $("#subject-blank").show();
                blank = true;
        }
    })
    return blank;
}

function checkEmail(email) {
    var emailValid = /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$/;
    if (emailValid.test(email)) {
        return true;
    }
    return false;
}