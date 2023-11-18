document.addEventListener('DOMContentLoaded', ()=>{
    const menuBtn = document.getElementsByClassName('menu-icon');
    const mobileMenuBtn = document.getElementById('mobile-menu-btn');
    const burgerMenu = document.getElementById('burger-menu');

    const toggleDropdown = function() {
        burgerMenu.classList.toggle('show');
    };
    mobileMenuBtn.addEventListener('click', function(e) {
        e.stopPropagation();
        toggleDropdown();
    });
})
