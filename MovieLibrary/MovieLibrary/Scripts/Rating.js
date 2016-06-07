function Fill(a) {

    var x = document.getElementsByClassName("star");

    for (var i = 0; i < a; i++) {
        x[i].style.background = "url('../img/SFill.png')";
        x[i].style.backgroundSize = "20px";
        x[i].style.backgroundRepeat = "no-repeat";
    }
}

function Empty(a) {

    var x = document.getElementsByClassName("star");

    for (var i = 0; i < a; i++) {
        x[i].style.background = "url('../img/SEmpty.png')";
        x[i].style.backgroundSize = "20px";
        x[i].style.backgroundRepeat = "no-repeat";
    }
}


function Send(n) {

    document.getElementById('Rating').value= n;

    var x = document.getElementsByClassName("star");

    for (var i = 0; i < 5; i++) {
        x[i].onmouseover = null;
        x[i].onmouseout = null;
    }

    for (var i = 0; i < n; i++) {
        x[i].style.background = "url('../img/SFill.png')";
        x[i].style.backgroundSize = "20px";
        x[i].style.backgroundRepeat = "no-repeat";
    }

    for (var i = n; i < 5; i++) {
        x[i].style.background = "url('../img/SEmpty.png')";
        x[i].style.backgroundSize = "20px";
        x[i].style.backgroundRepeat = "no-repeat";
    }
}