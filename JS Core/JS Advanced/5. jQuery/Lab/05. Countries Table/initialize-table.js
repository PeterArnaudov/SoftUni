function initializeTable() {
    let tableElement = $('table');

    (() => {
        tableElement.append('<tr><td>Bulgaria</td><td>Sofia</td><td><a class="moveUp">[Up]</a><a class="moveDown">[Down]</a><a class="delete">[Delete]</a></td></tr>');
        tableElement.append('<tr><td>Germany</td><td>Berlin</td><td><a class="moveUp">[Up]</a><a class="moveDown">[Down]</a><a class="delete">[Delete]</a></td></tr>');
        tableElement.append('<tr><td>Russia</td><td>Moscow</td><td><a class="moveUp">[Up]</a><a class="moveDown">[Down]</a><a class="delete">[Delete]</a></td></tr>');

        $('#createLink').click(addRow);
        $('.moveUp').click(moveUp);
        $('.moveDown').click(moveDown);
        $('.delete').click(deleteRow);

        updateActions();
    })();
    
    function addRow() {
        let countryName = $('#newCountryText').val();
        let capitalName = $('#newCapitalText').val();

        tableElement.append($('<tr>')
            .append($(`<td>${countryName}</td>`))
            .append($(`<td>${capitalName}</td>`))
            .append($('<td>')
                .append($('<a class="moveUp">[Up]</a>').click(moveUp))
                .append($('<a class="moveDown">[Down]</a>').click(moveDown))
                .append($('<a class="delete">[Delete]</a>').click(deleteRow))));

        updateActions();
    }
    
    function deleteRow() {
        $(this.parentElement.parentElement).remove();
        updateActions();
    }
    
    function moveUp() {
        $(this).parent().parent().after($(this).parent().parent().prev());

        updateActions();
    }
    
    function moveDown() {
        $(this).parent().parent().before($(this).parent().parent().next());

        updateActions();
    }
    
    function updateActions() {
        $('tr a').css('display', 'inline');
        $('tr:eq(2) td:last .moveUp').css('display', 'none');
        $('tr:last td:last .moveDown').css('display', 'none');
    }
}