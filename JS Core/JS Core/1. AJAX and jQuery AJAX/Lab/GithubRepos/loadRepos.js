function loadRepos() {
    function onSuccess(data) {
        data.forEach((x) => {
            let listItem = $('<li>');

            let anchor = $('<a href="' + x.html_url + '">');
            anchor.text(x.full_name);
            
            listItem.append(anchor);

            $('#repos').append(listItem);
        })
    }

    function onError() {
        $('#repos')
            .append($('<li>').text('Error'));
    }

    $('#repos').text('');
    let username = $('#username').val();
    let url = `https://api.github.com/users/${username}/repos`;

    $.ajax({
        method: 'GET',
        url: url,
        success: onSuccess,
        error: onError
    })
}