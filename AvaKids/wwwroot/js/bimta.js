////$('.filter-show .filter-list a').click(function () {
////    var tm = $(this).attr("data-trademark");


////    var model = {
////        TrademarkQR: tm,
////    };

////    $.ajax({
////        type: "POST",
////        data: JSON.stringify(model),
////        url: 'BimTa/FilteredTestQR',
////        contentType: "application/json",
////        success: function (HTMLfiltered) {
////            $('.filtered-qr').html(HTMLfiltered);
////        }
////    })
////});



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




var qr = {
    TrademarkQR: null,
    PriceForm: "-1",
    WeightQR: null
};

//$('.filter-trademark').click(function () {
//    if ($('.filter-show').css("display") == ("none")) {
//        $('.filter-show').css("display", "block")
//    } else {
//        $('.filter-show').css("display", "none")
//    }
//})



$('.filter-show .filter-list a').click(function () {
    var tm = $(this).attr("data-trademark");
    qr.TrademarkQR = tm;
});
$(".clear-filter-trademark").click(function () {
    qr.TrademarkQR = null;
})

$('.filter-show3 .filter-list a').click(function () {
    var pf = $(this).attr("data-priceform");
    qr.PriceForm = pf;
});
$(".clear-filter-price").click(function () {
    qr.PriceForm = null;
})

$('.filter-show5 .filter-list a').click(function () {
    var wd = $(this).attr("data-weight");
    qr.WeightQR = wd;
});
$(".clear-filter-weight").click(function () {
    qr.WeightQR = null;
})

$(".btn-loc button").click(function () {
    console.log(qr);
    $.ajax({
        type: "POST",
        data: JSON.stringify(qr),
        url: 'BimTa/FilteredTestQR',
        contentType: "application/json",
        success: function (HTMLfiltered) {
            $('.filtered-qr').html(HTMLfiltered);
        }
    })
})



