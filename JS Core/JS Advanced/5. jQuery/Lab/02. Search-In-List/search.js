function search() {
    let searched = $('#searchText').val();

    $('li').css('font-weight', 'normal');
    $(`li:contains(${searched})`).css('font-weight', 'bold');

    $('#result').text(`${$(`li:contains(${searched})`).length} matches found`);
}