$(document).ready(function () {
    $(".hide").hide();
    $(".optionContainer").hide();
    $("#addProduct").show();
    $(".options").find("ul li:first").css("color", "#3392D6");
    $(".options").find("ul li:first").css("font-weight", "700");   
    var height_2 = $(".contentOptions").height();
    $(".options").css("min-height", height_2);
    $(".options").find("a").click(function () {        
        var name = $(this).attr("name");    
        $(".options").find("a").each(function () {
            $(this).css("color", "#3f4244");
            $(this).css("font-weight", "500");
        })
        $(".optionContainer").each(function () {
            $(this).hide();
            if (this.id == name) {
                height_2 = $(this).height();
                $(".options").css("min-height", height_2);
                $(this).show();                
            }           
        })

        $(this).css("color", "#3392D6");
        $(this).css("font-weight", "700");       
        $(".categories").empty();
        $(".categories").append($("<option></option>").attr("value", "0").text("Categoría"));
        $(".tipos").empty();
        $(".tipos").append($("<option></option>").attr("value", "0").text("Tipo"));
        $("#userList").empty();
        $("input[type='text']").val("");
        $("select").val("0");
    })

    $("#addButton").click(function () {
        $(this).hide();
        $(".hide").css("margin-top", "-30px");
        $(".hide").show();
        setTimeout(function () {
            window.location.href="Admin_Panel.aspx?success=added"
        }, 2500);
    })
})