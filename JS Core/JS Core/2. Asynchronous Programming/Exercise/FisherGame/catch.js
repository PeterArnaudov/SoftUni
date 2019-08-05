function attachEvents() {
    function load() {
        $.get({
            url: url,
            headers: authorizationHeader
        })
            .then(data => {
                $('#catches').empty();

                data.forEach(x => {
                    let catchDiv = $(`<div class="catch" data-id="${x._id}">
                        <label>Angler</label>
                        <input type="text" class="angler" value="${x.angler}"/>
                        <label>Weight</label>
                        <input type="number" class="weight" value="${x.weight}"/>
                        <label>Species</label>
                        <input type="text" class="species" value="${x.species}"/>
                        <label>Location</label>
                        <input type="text" class="location" value="${x.location}"/>
                        <label>Bait</label>
                        <input type="text" class="bait" value="${x.bait}"/>
                        <label>Capture Time</label>
                        <input type="number" class="captureTime" value="${x.captureTime}"/>
                    </div>`);

                    let updateButton = $('<button class="update">Update</button>');
                    let deleteButton = $('<button class="delete">Delete</button>');

                    updateButton.click(edit);
                    deleteButton.click(remove);

                    catchDiv.append(updateButton);
                    catchDiv.append(deleteButton);

                    $('#catches').append(catchDiv);
                })
            })
    }

    function create(e) {
        let angler = $('#aside .angler').val();
        let weight = $('#aside .weight').val();
        let species = $('#aside .species').val();
        let location = $('#aside .location').val();
        let bait = $('#aside .bait').val();
        let captureTime = $('#aside .captureTime').val();

        $.post({
            url: url,
            headers: authorizationHeader,
            data: {
                angler: angler,
                weight: weight,
                species: species,
                location: location,
                bait: bait,
                captureTime: captureTime
            }
        })
            .then(() => load());

        Array.from($(e.target).parent().find('input')).forEach(x => x.value = '');
    }

    function edit(e) {
        let catchId = $(e.target).parent().attr('data-id');

        let angler = $(e.target).parent().children('.angler').val();
        let weight = $(e.target).parent().children('.weight').val();
        let species = $(e.target).parent().children('.species').val();
        let location = $(e.target).parent().children('.location').val();
        let bait = $(e.target).parent().children('.bait').val();
        let captureTime = $(e.target).parent().children('.captureTime').val();

        $.ajax({
            method: 'PUT',
            url: url + `/${catchId}`,
            headers: authorizationHeader,
            data: JSON.stringify({
                angler: angler,
                weight: weight,
                species: species,
                location: location,
                bait: bait,
                captureTime: captureTime
            })
        })
            .then(load);
    }

    function remove(e) {
        let catchId = $(e.target).parent().attr('data-id');

        $.ajax({
            method: 'DELETE',
            url: url + `/${catchId}`,
            headers: authorizationHeader
        })
            .then(() => load());
    }

    let appKey = 'kid_S1MkX6f6V';
    let url = `https://baas.kinvey.com/appdata/${appKey}/biggestCatches`;

    let username = 'guest';
    let password = 'guest';
    let authorizationHeader = { 'Authorization': 'Basic ' + btoa(`${username}:${password}`) };

    $('.load').click(load);
    $('.add').click(create);
}