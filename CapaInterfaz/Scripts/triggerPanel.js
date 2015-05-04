
$(window).load(triggerMenu);
$(window).resize(triggerMenu);


function triggerMenu() {
    var header = $("#headerMobile").outerHeight();
    var panel = $('.panel').height();
    var panelheight = panel - header;
    $('.panel').css({
        'top': header,
    });
}