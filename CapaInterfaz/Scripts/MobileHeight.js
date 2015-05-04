$(document).ready(function () {
        var height = $(window).height() - 45;
        $(".ui-content").css("min-height", height + "px");
})

$(window).on("orientationchange", function () {
    setTimeout(function () {
        var height = $(window).height() - 45;
        $(".ui-content").css("min-height", height + "px");
    }, 200);
})