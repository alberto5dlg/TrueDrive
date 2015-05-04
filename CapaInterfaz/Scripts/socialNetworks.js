$(document).ready(function () {
    $(".social").find("li").hover(function () {
        $(this).find("p").css("font-weight", "700");
        switch (this.id) {
            case "FB":
                $(this).find("img").attr("src", "../Styles/images/social-networks/facebookON.png");
                $(this).find("p").css("color", "rgb(59,88,156)");             
                break;
            case "TW":
                $(this).find("img").attr("src", "../Styles/images/social-networks/twitterON.png");
                $(this).find("p").css("color", "rgb(0,172,237)");
                break;
        }
    })
    $(".social").find("li").mouseleave(function () {
        $(this).find("p").css("color", "#3f4244");
        $(this).find("p").css("font-weight", "100");
        switch (this.id) {
            case "FB":
                $(this).find("img").attr("src", "../Styles/images/social-networks/facebookOFF.png");   
                break;
            case "TW":
                $(this).find("img").attr("src", "../Styles/images/social-networks/twitterOFF.png");
                break;
        }
    })
})