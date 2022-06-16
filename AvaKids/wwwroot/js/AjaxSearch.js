$('#keyword').keyup(function () {
    var searchField = $('#keyword').val();
    var expression = RegExp(searchField, "i");

    $.ajax({
        url: '/DoChoi/Search',
        type: 'GET',
        data: {
            searchText: searchField
        },
        dataType: 'json',
        contentType: 'application/json;charset=utf-8',
        success: function (response) {
            var data = JSON.parse(response);
            console.log(data);
            if (searchField != "") {
                var html_Body = `<div class="search-product"><ul></ul></div> `;
            } $('.search-result').append(html_Body);
            $.each(data, function (key, item) {
                for (let abc = 0; abc < item.length; abc++) {
                    if (item[abc].ProductName.search(expression) != -1 && searchField != "") {
                        var html_Search = `<li>
                                <a href="/san-pham/id-${item[abc].ProductID}">
                                    <div class="img">
                                        <img src="/img/${item[abc].Image}" class="ls-is-cached lazyloaded" alt=""2>
                                    </div>
                                    <div class="ct">
                                        <h3>${item[abc].ProductName}</h3>
                                        <div class="Sprice">
                                            <strong class="Sprice-current">${item[abc].Price.toLocaleString('vi-VN', { style: 'currency', currency: 'VND' })}</strong>
                                            <span class="Sprice-old">${item[abc].PriceOld.toLocaleString('vi-VN', { style: 'currency', currency: 'VND' })}</span>
                                            <span class="Sprice-percent">10%</span>
                                        </div>
                                    </div>
                                </a>
                            </li>`;
                        $('.search-result ul').append(html_Search);
                        $(".search-result").css("display", "block");
                        $(".search-show").css("display", "block");
                        $(".header-search").css("border-radius", "20px 20px 0px 0px");
                        $(".clear-search").css("display", "block");
                    }
                }
            })
        },
    })
    $('.search-show ul').remove();
    $(".search-show").css("display", "none");
    $(".header-search").css("border-radius", "20px");
    $(".clear-search").css("display", "none");
})

function ClearSearch() {
    document.getElementById("keyword").value = "";
    $('.search-show ul').remove();
    $(".search-show").css("display", "none");
    $(".header-search").css("border-radius", "20px");
    $(".clear-search").css("display", "none");
}


$(".extend").focus(function () {
    $(".info-form-cmt").css("display","flex");
})






