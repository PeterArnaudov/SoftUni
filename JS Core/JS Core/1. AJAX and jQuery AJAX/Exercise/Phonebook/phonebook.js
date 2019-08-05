function attachEvents() {
    function loadContacts() {
        $.ajax({
            method: 'GET',
            url: 'https://phonebook-nakov.firebaseio.com/phonebook.json',
            success: (data) => {
                $('#phonebook').text('');
                data = Object.values(data);

                data.forEach(x => {
                    let listElement = $('<li>').text(`${x.person}:${x.phone}`);
                    let deleteButton = $('<button>DELETE</button>');

                    deleteButton.click(deleteContact);
                    listElement.append(deleteButton);
                    listElement.appendTo($('#phonebook'));
                })
            }
        })
    }

    function createContact() {
        let data = {
            person: $('#person').val(),
            phone: $('#phone').val()
        };

        $.ajax({
            method: 'POST',
            url: 'https://phonebook-nakov.firebaseio.com/phonebook.json',
            data: JSON.stringify(data),
            success: () => {
                $('#person').val('');
                $('#phone').val('');
                loadContacts();
            }
        })
    }

    function deleteContact() {
        let contactInfo = $(this).parent().text().replace('DELETE', '').split(':');
        let searchedName = contactInfo[0];
        let searchedPhone = contactInfo[1];

        $.ajax({
            method: 'GET',
            url: 'https://phonebook-nakov.firebaseio.com/phonebook.json',
            success: (data) => {
                let deleteKey = '';
                data = Object.entries(data);

                for (let x of data) {
                    if (searchedName == x[1].person && searchedPhone == x[1].phone) {
                        deleteKey = x[0];
                        break;
                    }
                }

                $.ajax({
                    method: 'DELETE',
                    url: `https://phonebook-nakov.firebaseio.com/phonebook/${deleteKey}.json`,
                    success: loadContacts
                })
            }
        })
    }

    $('#btnLoad').click(loadContacts);
    $('#btnCreate').click(createContact);
}