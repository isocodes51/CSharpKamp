// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const btn = document.getElementById("#Button1");
const txt1 = document.getElementById("Text1");
const txt2 = document.getElementById("#Text2");
const goster = document.getElementById("#sonucGoster");
//var topla = () => {
    

//    var sonuc = (txt1 + txt2);
//    goster.innerHTML = sonuc;
   
//}

window.onload = () => {
    btn.addEventListener("click", function () {
        var sonuc = parseInt(txt1.value + txt2.value);
        goster.innerHTML = sonuc;
    });
}