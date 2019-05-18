function attachEvents() {
    function select() {
        $('.selected').removeClass('selected');
        $(this).addClass('selected');
    }

    $('a').click(select);
}