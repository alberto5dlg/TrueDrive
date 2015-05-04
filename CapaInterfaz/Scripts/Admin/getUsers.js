$(document).ready(function () {

    var contacts = new Array();
    $("#message").hide();
    getUsersM(" ");
    $("#getUser").click(function () {
        $("#userList").empty();
        getUsers($("#search_value").val());       
    });
    
    $("#multiDif").click(function () {
        if ($(this).is(":checked"))
            $(":checkbox").prop('checked', true);
        else
            $(":checkbox").prop('checked', false);
    })

    $("#buttonNext").click(function () {
        contacts = mailTo();
        $("#users").hide();
        $("#message").show();
    })
    $(".cancelMessage").click(function () {
        $("#message").hide();
        $("#users").show();    
    })


    $("#sendButton").click(function () {
        var sub = $(".toUserBox").val();
        var con = $(".body").val()
        sendMessage(sub, con, contacts);
    })
})

function getUsers(val) {
    var data = JSON.stringify({value: val});
    $.ajax({
        type: "POST",
        url: "Admin_Panel.aspx/getUsers",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var users = response.d;
            if(users.NUsers > 0)
                setUserList(users);
            else {
                var li = '<li><p><i class="fa fa-times error no_results"></i> No se han encontrado usuarios coincidetes para: <strong>' + val + '</strong></p></li>';
                $("#userList").append(li);
            }
        },
        error: function () {
            alert("An error ocurred");
        }
    });
}


function setUserList(users) {
    $("#userList").empty();
    var address = "Sin dirección"
    for (var i = 0; i < users.NUsers; i++) {
        if (users.userList[i].Address != "" && users.userList[i].Address != null) {
            address = users.userList[i].Address;
        }
        var li = '<li><div class="userContent"><div class="headerUserContent"><h2>Datos Usuario <img src="../Styles/images/admin-options/id_card.ico" /></h2></div><ul><li><label><strong>Nombre:  </strong></label>' + users.userList[i].Name + '</li><li><label><strong>Apellidos:  </strong></label>' + users.userList[i].Cognames + '</li><li><label><strong>Teléfono:  </strong></label>' + users.userList[i].Phone + '</li><li><label><strong>Correo:  </strong></label>' + users.userList[i].Email + '</li><li><label><strong>Dirección:  </strong></label>'+ address +'</li></ul></div></li>';
        $("#userList").append(li);
    }
    var height = $(".contentOptions").height();
    $(".options").css("min-height", height);
}


function getUsersM(val) {
    var data = JSON.stringify({ value: val });
    $.ajax({
        type: "POST",
        url: "Admin_Panel.aspx/getUsers",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var users = response.d;
            setUserListM(users);
        },
        error: function () {
            alert("An error ocurred");
        }
    });
}

function setUserListM(users) {
    for (var i = 0; i < users.NUsers; i++) {
        var li = '<li><label class="nameM">' + users.userList[i].Name + '  ' + users.userList[i].Cognames + '</label><label class="emailM">' + users.userList[i].Email + '</label><input type="checkbox" /></li>';
        $("#userListM").append(li);
    }
    var height = $(".contentOptions").height();
    $(".options").css("min-height", height);
}


function mailTo() {
    var contacts = new Array();
    $("#userListM").find("li").each(function () {
        if ($(this).find(":checkbox").is(":checked")) {
            if ($(this).find(".emailM").text() != "")
                contacts.push($(this).find(".emailM").text());
        }
    })
    return contacts;
}

function sendMessage(sub, con, contacts) {
    var data = JSON.stringify({subject: sub, consult: con, users: contacts});
    $.ajax({
        type: "POST",
        url: "Admin_Panel.aspx/sendMessage",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function () {
            $("#message").hide();
            $("#users").show();
        },
        error: function () {
            alert("An error ocurred");
        }
    });
}
