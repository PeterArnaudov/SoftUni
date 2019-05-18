function increment(selector) {
    function increase() {
        $('textarea').val(Number($('textarea').val()) + 1);
    }

    function add() {
        $('ul').append($('<li>').text($('textarea').val()));
    }

    let selectedElement = $(selector);
    selectedElement.append($('<textarea class="counter" disabled>').val('0'));
    selectedElement.append($('<button class="btn" id="incrementBtn">Increment</button>').click(increase));
    selectedElement.append($('<button class="btn" id="addBtn">Add</button>').click(add));
    selectedElement.append($('<ul class="results">'));
}
