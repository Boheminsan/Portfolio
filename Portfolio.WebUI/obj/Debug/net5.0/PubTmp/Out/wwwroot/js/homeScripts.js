$(document).ready(function () {
    $('.site-main .brand-area .first-row .owl-carousel').owlCarousel({
        loop: true,
        center: true,
        autoWidth: true,
        autoplay: true,
        dots: true,
        responsive: {
            0: {
                items: 2
            },
            544: {
                items: 4
            },
            960: {
                items: 5
            },
            1560: {
                items: 6
            }
        }
    });

    $('.site-main .client-area .owl-carousel').owlCarousel({
        loop: true,
        autoplay: true,
        dots: true,
        responsive: {
            0: {
                items: 2
            },
            1560: {
                items: 3
            }
        }
    });
});