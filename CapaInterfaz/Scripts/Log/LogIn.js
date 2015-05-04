var rBox = $("#registerBox");
var text = $("#registerText");
var emailBox = $("#logginContent").find('[id$=email]');
var hiddenBox = $("#hiddenRP");
var checkBox = $('input[name$="forgottenPass"]');
var emailEmpty = $("#logginContent").find('[id$=emailNotValid]');
var passEmpty = $("#logginContent").find('[id$=passNotValid]');
var recover = $("#logginContent").find('[id$=recoverPass]');

$(document).ready(function (){
    hiddenBox.hide();
})

checkBox.click(function () {
    if (hiddenBox.is(":visible")) {
        hiddenBox.hide(600);
    }
    else {
        hiddenBox.show(600);
    }
    emailBox.click(function () {

        emailBox.val("");
    });
})