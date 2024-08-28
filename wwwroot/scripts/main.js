
(function ($) {
    AOS.init()
    "use strict";

    
})(jQuery);



// Carusel OWL
$('.owl-one').owlCarousel({
    center: true,
    loop:true,
    margin:30,
    nav:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:1
        },
        1300: {
            items:3
        }

    }
})



$('.owl-news').owlCarousel({
        center: true,
        loop: true,
        margin: 20,
        nav: true,
        autoplay: false,
        autoplayTimeout: 3000,
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 2
            },
            1000: {
                items: 3
            }
        }
    })




$('.owl-two').owlCarousel({
    center: true,
    loop:true,
    margin:5,
    nav:true,
    autoplay: true,
    autoplayTimeout: 3000,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:2
        },
        1000:{
            items:5
        }
    }
})


$('.owl-three').owlCarousel({
    center: true,
    loop:true,
    margin:30,
    nav:true,
    autoplay: false,
    autoplayTimeout: 3000,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:2
        },
        1000:{
            items:3
        }
    }
})


$('.owl-four').owlCarousel({
    center: true,
    loop:true,
    margin:30,
    nav:true,
    autoplay: false,
    autoplayTimeout: 3000,
    responsive:{
        0:{
            items:1
        },
        768:{
            items:2
        },
        1000:{
            items:3
        }
    }
})


    $('.owl-secto').owlCarousel({
        center: true,
        loop: true,
        margin: 30,
        nav: true,
        autoplay: false,
        autoplayTimeout: 3000,
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 1
            },
            1000: {
                items: 3
            }
        }
    })


document.addEventListener("keyup", e => {

    if (e.target.matches("#buscador")) {

        document.querySelectorAll(".documento").forEach(libro => {

            libro.textContent.toLowerCase().includes(e.target.value.toLowerCase())
                ? libro.classList.remove("filtro")
                : libro.classList.add("filtro")
        })

    }
})












