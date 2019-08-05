const movieService = (() => {
    function getAllMovies() {
        return kinvey.get('appdata', 'movies', 'kinvey');
    }

    function getMyMovies() {
        return kinvey.get('appdata', `movies/?query={"_acl.creator":"${sessionStorage.getItem('userID')}"}`, 'kinvey');
    }

    function getMovie(id) {
        return kinvey.get('appdata', 'movies/' + id, 'kinvey');
    }

    function createMovie(data) {
        return kinvey.post('appdata', 'movies', 'kinvey', data);
    }

    function deleteMovie(id) {
        return kinvey.remove('appdata', 'movies/' + id, 'kinvey');
    }

    function editMovie(data) {
        return kinvey.update('appdata', 'movies/' + data._id, 'kinvey', data)
    }

    return {
        getAllMovies,
        getMyMovies,
        getMovie,
        createMovie,
        deleteMovie,
        editMovie
    }
})();