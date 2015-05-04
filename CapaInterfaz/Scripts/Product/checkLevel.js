$(document).ready(function () {

    productList = $(".lProducts");
    
    productList.find(".descriptionProduct").each(function () {
        var category = $(this).find("h2").text();
        if ($(this).find("a").attr("name") == 1) {
            var section = window.location.href.split("=");
            $(this).find("a").attr("href", "Products.aspx?section=" + section[1] + "&category=" + category);
        }
    });

    productList.find(".pMobileWrapper").each(function () {
        var category = $(this).find("h2").text();       
        if ($(this).find("a").attr("name") == 1) {
            var section = window.location.href.split("=");
            $(this).find("a").attr("href", "Products.aspx?section=" + section[1] + "&category=" + category);
        }
    });
});