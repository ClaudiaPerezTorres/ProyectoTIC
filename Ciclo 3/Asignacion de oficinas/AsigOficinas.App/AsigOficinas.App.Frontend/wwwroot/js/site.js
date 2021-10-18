// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function toggle(o) {
    var el = document.querySelector(".mostarPersonalAseo");
    if (o.value == "mostrar") el.style.display = "block";
    if (o.value == "ocultar") el.style.display = "none";
}