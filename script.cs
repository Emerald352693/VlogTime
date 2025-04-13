// script.js
document.addEventListener("DOMContentLoaded", function() {
    const form = document.querySelector("form");
    form.addEventListener("submit", function(event) {
        event.preventDefault();  // Formun normalde gönderilmesini engelliyor
        alert("Mesajınız başarıyla gönderildi!");
    });
});
