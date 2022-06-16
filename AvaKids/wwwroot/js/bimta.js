$('.filter-list a').click(function () {
    var tm = $(this).attr("data-trademark");
    var payload = {trademark : tm}; 
    $.ajax({
        url: 'bimta/filteredTest',
        method: 'POST',
        dataType: 'JSON',
        data: payload,
        success: function (data) {
            $("#myPartialViewDiv").html(data);
            console.log(data);
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

