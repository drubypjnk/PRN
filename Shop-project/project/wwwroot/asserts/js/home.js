function ChoosePage(curCategory) {
    var curpage = $('#paging').children('option:selected').val();
    var link = "/Home/List/" + curCategory + "/" + curpage;
    window.location.href = link;
}
function chooseCategory(e) {
    var current = $('.category-item--active')[0]
    current.className = current.className.replace(" category-item--active", "");
    e.className += " category-item--active";
    submitForm(1);
}


function paging(numpage) {
    submitForm(numpage)
}

function submitForm(numpage) {

    var cat = $('.category-item--active')[0];
    var id = cat.getAttribute('value');
    $.ajax({
        type: "POST",
        url: "/Home/Search",
        data: {
            id: id,
            curPage: numpage,
            word: $('.header__search-input').val(),
            sortID: $('#sort').children("option:selected").val()
        },
        dataType: "text",
        success: function (data) {
            $('#content').empty().append(data);
    submitPaging(numpage);
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });

    //paging
}
function submitPaging(numpage) {

    var cat = $('.category-item--active')[0];
    var id = cat.getAttribute('value');
    $.ajax({
        type: "POST",
        url: "/Home/Paging",
        data: {
            id: id,
            curPage: numpage,
            word: $('.header__search-input').val(),
            sortID: $('#sort').children("option:selected").val()
        },
        dataType: "text",
        success: function (data) {
            console.log(data);
            $('#page-nav').empty().append(data);
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });
}
