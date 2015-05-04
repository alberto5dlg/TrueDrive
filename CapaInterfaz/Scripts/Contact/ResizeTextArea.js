var textArea = $('#Consult');
var Area = $("#ConsultArea");
var hiddenBar = $("#hiddenBar");
var scrollHeight = textArea.prop("scrollHeight");
var success = $("#success");
var send = $(".contactWrapper").find('[id$=sendConsult]');
var email = $(".contactWrapper").find('[id$=userEmail]');
var userName = $(".contactWrapper").find('[id$=userName]');
var subject = $(".contactWrapper").find('[id$=subject]');

$(document).ready(function () {
    if (!Page_ClientValidate()) {
        success.hide();
    }
    else {
        $(".contactWrapper").css("min-height", "100px");
        $("#additionalInfo").hide();
        $(".contactWrapper").find("ul").find("li").each(function () {
            if (this.id != "success") {
                $(this).hide();
            }
            else 
                $(this).show;
        })      
    }
    $(".messageFalse").hide();
    email.blur(function () {
        if(email.val() == "")
            $("#EE").show();
        else 
            $("#EE").hide();
    })
    userName.blur(function () {
        if (userName.val() == "")
            $("#NE").show();
        else
            $("#NE").hide();
    })
    subject.blur(function () {
        if (subject.val() == "")
            $("#SE").show();
        else
            $("#SE").hide();
    })
    textArea.click(function () {
        Area.css("height", "auto");
        textArea.css("height", "180px");
        hiddenBar.css("visibility", "visible");
    })

    send.click(function () {
        if(email.val() == "" && userName.val()=="" && subject.val()=="")
            $(".messageFalse").show();
        else if (email.val() == "" && userName.val() == "") {
            $("#EE").show();
            $("#NE").show();
        }
        else if (email.val() == "" && subject.val() == "") {
            $("#EE").show();
            $("#SE").show();
        }
        else if (name.val() == "" && subject.val() == "") {
            $("#NE").show();
            $("#SE").show();
        }
        else if(email.val() == "")
            $("#EE").show();
        else if (userName.val() == "")
            $("#NE").show();
        else if (subject.val() == "")
            $("#SE").show();
    })
})
