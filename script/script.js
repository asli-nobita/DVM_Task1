const dropdownBtns = document.querySelectorAll('.menu-icon');

const toggleMenu = function(menu) {
    if(menu.style.display === 'none') {
        menu.style.display = 'block';
    } else {
        menu.style.display = 'none';
    }
}

dropdownBtns.forEach(btn => {
    btn.addEventListener('click', function() {
        const index = Array.from(dropdownBtns).indexOf(btn);

        switch (index) {
            case 0:
                toggleMenu(shopMenu);
                break;
            case 1:
                toggleMenu(exploreMenu);
                break;
            case 2:
                toggleMenu(supportMenu);
                break;
            case 3:
                toggleMenu(companyMenu);
                break;
        }
    });
});
