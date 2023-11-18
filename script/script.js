document.addEventListener('DOMContentLoaded', ()=>{
    const menuBtn = document.getElementsByClassName('menu-icon');
    const mobileMenuBtn = document.getElementById('mobile-menu-btn');
    const burgerMenu = document.getElementById('burger-menu');

    const toggleDropdown = function(menu) {
        menu.classList.toggle('show');
        if (cart.style.visibility === 'hidden') {
            cart.style.visibility = 'visible';
        } else {
            cart.style.visibility = 'hidden';
        }
    };
    mobileMenuBtn.addEventListener('click', function(e) {
        e.stopPropagation();
        toggleDropdown();
    });
})
