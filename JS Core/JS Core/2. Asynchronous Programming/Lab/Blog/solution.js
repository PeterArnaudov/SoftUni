function attachEvents() {
    $('#btnViewPost').click(viewPost);
    $('#btnLoadPosts').click(loadPosts);

    let username = 'peter';
    let password = 'p';

    let appId = 'kid_B1KyOfAZe';
    let url = `https://baas.kinvey.com/appdata/${appId}`;
    let authorizationHeader = { 'Authorization': 'Basic ' + btoa(`${username}:${password}`) };

    function displayError(e) {
        let errorDivElement = $('<div>');
        errorDivElement.text(`Error: ${e.status} ${e.statusText}`);

        errorDivElement.css('background', 'green');
        errorDivElement.css('width', '200px');
        errorDivElement.css('border-radius', '20px');
        errorDivElement.css('text-align', 'center');

        $(document.body).prepend(errorDivElement);

        setTimeout(() => {
            errorDivElement.fadeOut(() => {
                errorDivElement.remove();
            });
        }, 3000);
    }

    function loadPosts() {
        function displayPosts(data) {
            $('#posts').empty();

            data.forEach(x => {
                let option = $('<option>');
                option.text(x.title);
                option.val(x._id);

                option.appendTo($('#posts'));
            })
        }

        $.ajax({
            method: 'GET',
            headers: authorizationHeader,
            url: url + '/posts',
            success: displayPosts,
            error: displayError
        })
    }

    function viewPost() {
        function displayPostInfo([post, comments]) {
            $('#post-title').text(post.title);
            $('#post-body').text(post.body);

            $('#post-comments').empty();
            comments.forEach(x => {
                $('#post-comments')
                    .append($('<li>')
                        .text(x.text));
            })
        }

        let postId = $('#posts').val();

        let getPost = $.ajax({
            method: 'GET',
            headers: authorizationHeader,
            url: url + `/posts/${postId}`
        });

        let getComments = $.ajax({
            method: 'GET',
            headers: authorizationHeader,
            url: url + `/comments/?query={"post_id":"${postId}"}`
        });

        Promise.all([getPost, getComments])
            .then(displayPostInfo)
            .catch(displayError);
    }
}