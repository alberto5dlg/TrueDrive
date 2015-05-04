var dropDown = $("#dropDownOptions");
var options = $("#hiddenOptions");
$(document).ready(function () {

    options.hide();

    dropDown.click(function (e) {
        e.stopPropagation();
        if (options.is(":visible"))
            options.hide();
        else
            options.show();
    })
    options.click(function (e) {
        e.stopPropagation();
    })
});


$('html').click(function () {
    options.hide();
});