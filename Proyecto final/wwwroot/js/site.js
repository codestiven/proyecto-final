// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.





//inicio
var boton_p = document.getElementById("boton_p");
var boton_e = document.getElementById("boton_e");


boton_p.addEventListener("mouseenter", function () {
    document.body.style.backgroundImage = "url('/imagenes/fondo1.jpg')";
});

boton_e.addEventListener("mouseenter", function () {
    document.body.style.backgroundImage = "url('/imagenes/fondo2.jpg')";
});

