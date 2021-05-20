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




    $("#gizle").click(function () {
        var gal = $("#gallery");
        if (gal.is(":hidden")) {
            gal.show();
        } else {
            gal.hide();
        }
    });

    $("#secimiTemizle").click(function () {
        $('input[name="imgId"]').prop('checked', false);
    });
});