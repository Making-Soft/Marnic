function mostrar(nombreCapa) {
    document.getElementById(nombreCapa).style.display = "";
}
function ocultar(nombreCapa) {
    document.getElementById(nombreCapa).style.display = "none";
}

function cambiarDisplay(id) {

    if (!document.getElementById)
    { return false; }
    else
    { fila = document.getElementById(id); }


    if (fila.style.display != "none")
    { $('.col-md-4').css('display', 'none'); }
    else
    { $('.col-md-4').css('display', 'block'); }
}


