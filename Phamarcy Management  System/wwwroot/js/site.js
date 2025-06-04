


/////////// DROPDOWN NAVBAR & ACTIVE LINK///////////////////////////

document.addEventListener("DOMContentLoaded", function () {

    const toggles = document.querySelectorAll(".dropdown-toggle");

    toggles.forEach(toggle => {
        toggle.addEventListener("click", function (e) {
            e.preventDefault();

            const targetId = toggle.getAttribute("data-target");
            const dropdown = document.getElementById(targetId);

            // Close all others
            document.querySelectorAll(".dropdown-menu").forEach(menu => {
                if (menu !== dropdown) menu.classList.remove("show");
            });

            // Toggle current
            dropdown.classList.toggle("show");
        });
    });

    // Close dropdowns on outside click
    document.addEventListener("click", function (e) {
        if (!e.target.closest('.dropdown')) {
            document.querySelectorAll(".dropdown-menu").forEach(menu => {
                menu.classList.remove("show");
            });
        }
    });

    // Close on dropdown link click
    document.querySelectorAll(".dropdown-menu a").forEach(link => {
        link.addEventListener("click", function () {
            document.querySelectorAll(".dropdown-menu").forEach(menu => {
                menu.classList.remove("show");
            });
        });
    });

});


document.addEventListener("DOMContentLoaded", function () {
    const currentUrl = window.location.pathname.toLowerCase();
    const navLinks = document.querySelectorAll(".navbar a");

    navLinks.forEach(link => {
        const href = link.getAttribute("href");

        if (href && currentUrl.includes(href.toLowerCase())) {
            link.classList.add("active");
        }
    });

    // Optional: highlight parent dropdown if child is active
    document.querySelectorAll(".dropdown-menu a").forEach(link => {
        if (link.classList.contains("active")) {
            const parentToggle = link.closest(".dropdown").querySelector(".dropdown-toggle");
            if (parentToggle) parentToggle.classList.add("active");
        }
    });
});

///////////////////////////////////Page animation on Scrolll//////////////////////////////////////////////////////////////////////////////
// page animation 



