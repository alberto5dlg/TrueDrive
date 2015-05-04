var changePass = $("#changePass");
var personalInfo = $("#personalInfo");
var myAddress = $("#myAddress");
var myOrders = $("#myOrders");
$(document).ready(function () {
    changePass.hide();
    myAddress.hide();
    myOrders.hide();
    $("#userAccountOptions").find("li").click(function () {
        if (this.id == "PI" || this.id == "CP" || this.id == "AD" | this.id == "OD") {
            $("#userAccountOptions").find("li").each(function () {
                $(this).find("a").css('background-color', 'rgb(255, 247, 255)');
            })
            $("#userAccountOptionsContent").find("div").each(function () {
                $(this).hide();
            })
            switch (this.id) {
                case 'PI':
                    personalInfo.show();
                    break;
                case 'CP':
                    changePass.show();
                    break;
                case 'AD':
                    myAddress.show();
                    break;
                case 'OD':
                    myOrders.show();
                    break;
            }

        }
        $(this).find("a").css('background-color', '#F0F0F0');
        $(".buttonGreat").show();
    })
})