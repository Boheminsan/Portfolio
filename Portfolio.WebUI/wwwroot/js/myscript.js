$(document).ready(function () {

    let $btns = $('.project-area .button-group button');
    $btns.click(function (e) {
        $('.project-area .button-group button').removeClass("active");
        e.target.classList.add('active');
        let selector = $(e.target).attr('data-filter');
        console.log()
        $('.project-area .grid').isotope({
            filter: selector
        });
        return false;
    });

    var nav_offset_top = $('.header-area').height() + 50;

    function navbarFixed() {
        if ($('.header-area').length) {
            $(window).scroll(function () {
                var scroll = $(window).scrollTop();
                if (scroll >= nav_offset_top) {
                    $('.header-area .main-menu').addClass('navbar_fixed');
                } else {
                    $('.header-area .main-menu').removeClass('navbar_fixed');
                }
            })
        }
    }
    navbarFixed();

    $("#gizle").click(function () {
        var gal = $("#gallery");
        if (gal.is(":hidden")) {
            gal.show();
        } else {
            gal.hide();
        }
    });
});