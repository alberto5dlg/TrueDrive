$(window).load(function () {
    if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
        $("head").append("<link href='Styles/Device/Tablet/DisplayTablet.css' type='text/css' rel='stylesheet'  media='screen and (min-width: 481px) and (max-width: 1280px)'/>");
    }
    else {
        $("head").append("<link href='Styles/DisplayMedium.css' type='text/css' rel='stylesheet'  media='screen and (min-width: 680px) and (max-width: 980px)'/>");
        $("head").append("<link href='Styles/DisplayGreat.css' type='text/css' rel='stylesheet' media='screen and (min-width: 981px)' />");


    }
})