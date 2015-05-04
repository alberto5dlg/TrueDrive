$(document).ready(function () {
    $(".sections").change(function () {
        var val = $("option:selected", this).text();
        $(".categories").empty();
        $(".categories").append($("<option></option>").attr("value", "0").text("Categoría"));
        getCategories(val);
    });

    $(".categories").change(function () {
        var val = $("option:selected", this).text();
        $(".tipos").empty();
        $(".tipos").append($("<option></option>").attr("value", "0").text("Tipo"));
        getTipos(val);
    });
})

function getCategories(val) {
    var data = JSON.stringify({value: val});
    $.ajax({
        type: "POST",
        url: "Admin_Panel.aspx/getCategories",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var categories = response.d;
            setCategories(categories);
        }
    })
}

function getTipos(val) {
    var data = JSON.stringify({ value: val });
    $.ajax({
        type: "POST",
        url: "Admin_Panel.aspx/getTipos",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var tipos = response.d;
            setTipos(tipos);
        }
    })
}

function setCategories(categories) {
    
    for (var i = 0; i < categories.length; i++) {
        $(".categories").append($("<option></option>").attr("value", i+1).text(categories[i]));
    }
}
function setTipos(tipos) {

    for (var i = 0; i < tipos.length; i++) {
        $(".tipos").append($("<option></option>").attr("value", i + 1).text(tipos[i]));
    }
}