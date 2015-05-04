$(document).ready(function () {
    $("#searchInput").keypress(function (e) {
        if (e.keyCode == 13) {
            var search = $("#searchInput").val();
            window.location.href = "../Pages/Results.aspx?search=" + search;
        }
    })
})