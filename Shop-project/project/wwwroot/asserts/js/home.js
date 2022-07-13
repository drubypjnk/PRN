function ChoosePage(curCategory) {
    var curpage = $('#paging').children('option:selected').val();
    var link = "/Home/List/" + curCategory + "/" + curpage;
    window.location.href = link;
}