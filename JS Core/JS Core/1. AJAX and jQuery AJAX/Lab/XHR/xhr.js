function loadRepos() {
    function showProgress() {
        if (this.readyState < 4) {
            $('#res').text('Loading...');
        }
        else if (this.readyState == 4) {
            $('#res').text(this.responseText);
        }
    }

    let request = new XMLHttpRequest();
    request.onreadystatechange = showProgress;

    request.open('GET', 'https://api.github.com/users/testnakov/repos');
    request.send();
}