function loadCommits() {
    let username = $('#username').val();
    let repository = $('#repo').val();

    $.ajax({
        method: 'GET',
        url: `https://api.github.com/repos/${username}/${repository}/commits`,
        success: (data) => {
            data.forEach(x => {
                $('#commits').append($('<li>').text(`${x.commit.author.name}: (${x.commit.message})`))
            })
        },
        error: (error) => $('#commits').append($('<li>').text(`Error: ${error.status} (${error.statusText})`))
    })
}