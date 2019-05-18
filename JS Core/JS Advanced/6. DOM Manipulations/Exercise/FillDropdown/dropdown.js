function addItem() {
    let text = $('#newItemText').val();
    let value = $('#newItemValue').val();

    let option = $('<option>');
    option.text(text);
    option.val(value);

    $('#menu').append(option);

    $('#newItemText').val('');
    $('#newItemValue').val('');
}