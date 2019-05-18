function attachEvents() {
    function select() {
        if ($(this).attr('data-selected')) {
            $(this).removeAttr('data-selected');
            $(this).css('background', 'none');
        }
        else {
            $(this).attr('data-selected', true);
            $(this).css('background', '#DDD');
        }
    }

    function showSelected() {
        $('#selectedTowns').text($('[data-selected]').toArray().map(x => x.textContent).join(', '));
    }

    $('li').click(select);
    $('#showTownsButton').click(showSelected);
}