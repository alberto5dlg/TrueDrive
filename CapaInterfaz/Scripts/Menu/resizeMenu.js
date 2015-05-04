var widthMenu = $(".wrap").width();

$(window).bind("resize", function () {
    if ($(window).width() == 1180)
        getPadding();
})

$(document).ready(getPadding);

function getPadding() {   
    var menu = $(".menu");
    var width = ((widthMenu - menu.find("nav").width()) / 8) / 2;

    menu.find("li").find("a").css("padding-top", "10px");
    menu.find("li").find("a").css("padding-bottom", "10px");
    menu.find("li").find("a").css("padding-right", width + "px");
    menu.find("li").find("a").css("padding-left", width + "px");
}