$(document).ready(function () {

    $(".panel").find("li").find("a").click(function () {
        $(".panel").find("a").css("background-color", "#5F6466");
        $(this).css("background-color", "#EC2929");
    })
})