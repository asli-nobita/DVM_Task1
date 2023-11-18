const dropdownBtn = document.querySelector('.menu-icon');

const shopMenu = document.querySelector('.shop-menu');
const exploreMenu = document.querySelector('.explore-menu');
const supportMenu = document.querySelector('.support-menu');
const companyMenu = document.querySelector('.company-menu');

const toggleMenu = function(menu) {
    if (menu.style.display === 'none') {
        menu.style.display = 'block';
    } else {
        menu.style.display = 'none';
    }
}
