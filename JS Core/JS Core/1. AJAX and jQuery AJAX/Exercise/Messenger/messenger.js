function attachEvents() {
    function submit() {
        let data = {
            author: $('#author').val(),
            content: $('#content').val(),
            timestamp: Date.now()
        };

        $.ajax({
            method: 'POST',
            url: 'https://softunimessenger.firebaseio.com/-LfsWaTmVrX8URqeU07H.json',
            data: JSON.stringify(data),
            success: () => {
                $('#author').val('');
                $('#content').val('');
                refresh();
            }
        });
    }

    function refresh() {
        $.ajax({
            method: 'GET',
            url: 'https://softunimessenger.firebaseio.com/-LfsWaTmVrX8URqeU07H.json',
            success: (data) => {
                data = Object.values(data).sort((a, b) => a.timestamp - b.timestamp);
                let content = '';

                data.forEach((m) => {
                    content += `${m.author}: ${m.content}\n`;
                });

                $('#messages').text(content);
            },
            error: () => $('#messages').text('Something went wrong!')
        })
    }

    $('#submit').click(submit);
    $('#refresh').click(refresh);
}