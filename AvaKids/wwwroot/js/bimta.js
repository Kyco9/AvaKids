$('.filter-show .filter-list a').click(function () {
    var tm = $(this).attr("data-trademark");


    var model = {
        TrademarkQR: tm,
    };

    $.ajax({
        type: "POST",
        data: JSON.stringify(model),
        url: 'BimTa/FilteredTestQR',
        contentType: "application/json",
        success: function (HTMLfiltered) {
            $('.filtered-qr').html(HTMLfiltered);
        }
    })
});



$('.filter-trademark').click(function () {
    $(".filter-trademark .filter-title").toggleClass("toggle-change1");
    $(".filter-trademark .filter-title span").toggleClass("toggle-change2");
    $(".filter-show").toggle();
})
$('.filter-price').click(function () {
    $(".filter-price .filter-title").toggleClass("toggle-change1");
    $(".filter-price .filter-title span").toggleClass("toggle-change2");
    $(".filter-show3").toggle();
})
$('.filter-type').click(function () {
    $(".filter-type .filter-title").toggleClass("toggle-change1");
    $(".filter-type .filter-title span").toggleClass("toggle-change2");
    $(".filter-show4").toggle();
})
$('.filter-weight').click(function () {
    $(".filter-weight .filter-title").toggleClass("toggle-change1");
    $(".filter-weight .filter-title span").toggleClass("toggle-change2");
    $(".filter-show5").toggle();
})
$('.filter-size').click(function () {
    $(".filter-size .filter-title").toggleClass("toggle-change1");
    $(".filter-size .filter-title span").toggleClass("toggle-change2");
    $(".filter-show6").toggle();
})

