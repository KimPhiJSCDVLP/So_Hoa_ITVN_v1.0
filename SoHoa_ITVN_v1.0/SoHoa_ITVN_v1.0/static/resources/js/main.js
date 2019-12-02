
$("#btn-to-top").click(function (e) {
    e.preventDefault();
    $("html,body").animate({ scrollTop: 0 }, 500);
});
/* OPW-155: function script - Modal display select login type  */
$(document).ready(function () {
    $('#modal_id').click(function (event) {
        $('#myModal').modal('show')
    });
});
$(document).ready(function () {
    $('#customerPortalLink').click(function (event) {
        var url = 'https://khachhang.fubonlife.com.vn/accounts/login/?next=/';
        window.open(url, '_blank');
    });
});
$(document).ready(function () {
    $('#agentPortalLink').click(function (event) {
        var url = 'https://portal.fubonlife.com.vn/accounts/login/?next=/';
        window.open(url, '_blank');
    });
});
/* end OPW-155  */
$('#touch-menu').click(function () {
    $(this).stop(0).addClass('opened');
    $('#sticker').addClass('opened');
});
/*
$(document).on('click', '#touch-menu', function () {
    $(this).stop(0).addClass('opened');
    $('#sticker').addClass('opened');
});
*/
$(document).on('click', '#sticker .close-menu,#sticker-overlay', function () {
    $('#touch-menu').stop(0).removeClass('opened');
    $('#sticker').removeClass('opened');
});
$('#sticker .main-menu .fa').prev('a').click(function (e) {
    e.preventDefault();
    $(this).parent('li').children('.sub').stop(0).slideToggle(500);
    $(this).next('.fa').toggleClass('fa-caret-down').toggleClass('fa-caret-up');
});
$('#sticker .main-menu .fa').click(function (e) {
    e.preventDefault();
    $(this).parent('li').children('.sub').stop(0).slideToggle(500);
    $(this).toggleClass('fa-caret-down').toggleClass('fa-caret-up');
});
function initHotlineTop() {
    $('#hotline').css({ top: $('#top-nav').height() + $('header').height() + 7 });
}
function initHotlinePosition() {
    initHotlineTop();
    var hotlineWidth = $('#hotline').width();
    $('#hotline').width(hotlineWidth);
    $('#hotline').css({ right: -(hotlineWidth + 63 - 51) });
}

initHotlinePosition();
$(window).resize(function () {
    initHotlineTop();
});

var fixedRightTimeout = setTimeout(function () {
    $('#fixed-right').addClass('out');
}, 2000);

$(window).scroll(function () {
    clearTimeout(fixedRightTimeout);
    $('#fixed-right').removeClass('out');
    fixedRightTimeout = setTimeout(function () {
        $('#fixed-right').addClass('out');
    }, 2000);
});


$('.accordion dt').click(function () {
    var $this = $(this);
    var $parent = $this.parent();
    if ($this.hasClass('active')) {
        $this.stop(0).removeClass('active');
        $this.next().stop(0).slideUp(300);
    } else {
        $parent.find('dt').stop(0).removeClass('active');
        $parent.find('dd').stop(0).slideUp(300);
        $this.stop(0).addClass('active');
        $this.next().stop(0).slideDown(300);
    }
});