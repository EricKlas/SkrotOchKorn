document.addEventListener("DOMContentLoaded", function () {
    function toggleSizeOptions() {
        var userType = document.querySelector('input[name="UserType"]:checked').value;
        var sizeOptions = document.getElementById('sizeOptions');
        if (userType === "Företag") {
            sizeOptions.style.display = 'block';
        } else {
            sizeOptions.style.display = 'none';
        }
    }
    var userTypeRadios = document.querySelectorAll('input[name="UserType"]');
    userTypeRadios.forEach(function (radio) {
        radio.addEventListener('change', toggleSizeOptions);
    });

    toggleSizeOptions();
});