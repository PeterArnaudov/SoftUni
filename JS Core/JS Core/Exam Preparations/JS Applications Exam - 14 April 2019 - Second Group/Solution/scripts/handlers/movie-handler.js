handlers.getCinema = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    movieService.getAllMovies()
        .then(function (result) {
            context.movies = result;

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs',
                movie: 'templates/movies/movie.hbs'
            })
                .then(function () {
                    this.partial('templates/movies/cinema.hbs');
                });
        });
};

handlers.getMyMovies = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    movieService.getMyMovies()
        .then(function (result) {
            context.movies = result;

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs',
                movie: 'templates/movies/myMovie.hbs'
            })
                .then(function () {
                    this.partial('templates/movies/myMovies.hbs');
                });
        });
};

handlers.getCreate = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    context.loadPartials({
        header: 'templates/common/header.hbs',
        footer: 'templates/common/footer.hbs'
    })
        .then(function () {
            this.partial('templates/movies/createMovie.hbs');
        });
};

handlers.getMovieDetails = function (context) {
    let id = context.params.id.replace(':', '');
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    movieService.getMovie(id)
        .then(function (result) {
            context.title = result.title;
            context.imageURL = result.imageUrl;
            context.description = result.description;
            context.genres = result.genres.split(' ').join(',');
            context.tickets = result.tickets;
            context.id = result._id;

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('templates/movies/detailsMovie.hbs');
                });
        });
};

handlers.buyTicket = function (context) {
    let id = context.params.id.replace(':', '');

    movieService.getMovie(id)
        .then(function (data) {
            let editedData = {
                _id: id,
                title: data.title,
                description: data.description,
                imageUrl: data.imageUrl,
                genres: data.genres,
                tickets: data.tickets - 1
            };

            if (data.tickets > 0) {
                movieService.editMovie(editedData)
                    .then(function () {
                        notifications.showSuccess(`Successfully bought ticket for ${editedData.title}!`);
                        window.history.back();
                    })
            }
            else {
                notifications.showError(`No tickets for ${editedData.title}!`);
                window.history.back();
            }
        });
};

handlers.getEdit = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');
    let id = context.params.id.replace(':', '');

    movieService.getMovie(id)
        .then(function (result) {
            context.id = id;
            context.title = result.title;
            context.description = result.description;
            context.imageUrl = result.imageUrl;
            context.genres = result.genres;
            context.tickets = result.tickets;

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('templates/movies/editMovie.hbs');
                });
        });


};

handlers.editMovie = function (context) {
    let id = context.params.id.replace(':', '');

    movieService.getMovie(id)
        .then(function (data) {
            if (context.params.title.length < 6) {
                notifications.showError('Movie title has to be at least 6 symbols long!');
            }
            else if (!context.params.genres.match('^[a-zA-Z-]+( ?)(?:[a-zA-Z-]+(\\1)?)+$')) {
                notifications.showError('Genres should be separated by a single space!');
            }
            else if (context.params.description.length < 10) {
                notifications.showError('Movie description should be at least 10 symbols long!');
            }
            else if (!context.params.imageUrl.match('https*:\\/\\/')) {
                notifications.showError('Image URL should start with http://... or https://...');
            }
            else if (!context.params.tickets.match('\\d+')) {
                notifications.showError('Tickets must be a number!');
            }
            else {
                let editedData = {
                    _id: id,
                    title: context.params.title,
                    description: context.params.description,
                    imageUrl: context.params.imageUrl,
                    genres: data.genres,
                    tickets: context.params.tickets
                };

                movieService.editMovie(editedData)
                    .then(function () {
                        notifications.showSuccess('Movie edited successfully!');
                        context.redirect('#/home');
                    })
            }
        });
};

handlers.getAddMovie = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    context.loadPartials({
        header: 'templates/common/header.hbs',
        footer: 'templates/common/footer.hbs'
    })
        .then(function () {
            this.partial('templates/movies/createMovie.hbs');
        });
};

handlers.createMovie = function (context) {
    let title = context.params.title;
    let description = context.params.description;
    let imageUrl = context.params.imageUrl;
    let genres = context.params.genres;
    let tickets = context.params.tickets;

    if (title.length < 6) {
        notifications.showError('Movie title has to be at least 6 symbols long!');
    }
    else if (!genres.match('^[a-zA-Z-]+( ?)(?:[a-zA-Z-]+(\\1)?)+$')) {
        notifications.showError('Genres should be separated by a single space!');
    }
    else if (description.length < 10) {
        notifications.showError('Movie description should be at least 10 symbols long!');
    }
    else if (!imageUrl.match('https*:\\/\\/')) {
        notifications.showError('Image URL should start with http://... or https://...');
    }
    else if (!tickets.match('\\d+')) {
        notifications.showError('Tickets must be a number!');
    }
    else {
        let data = {
            title,
            description,
            imageUrl,
            genres,
            tickets
        };

        movieService.createMovie(data)
            .then(function () {
                notifications.showSuccess('Movie added successfully!');
                context.redirect('#/home');
            })
    }
};

handlers.getDelete = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');
    let id = context.params.id.replace(':', '');

    movieService.getMovie(id)
        .then(function (result) {
            context.id = result._id;
            context.title = result.title;
            context.description = result.description;
            context.imageUrl = result.imageUrl;
            context.genres = result.genres.split(' ').join(',');
            context.tickets = result.tickets;

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('templates/movies/deleteMovie.hbs');
                });
        });
};

handlers.deleteMovie = function (context) {
    let id = context.params.id.replace(':', '');

    movieService.deleteMovie(id)
        .then(function () {
            notifications.showSuccess('Movie removed successfully!');
            context.redirect('#/home');
        })
};

handlers.getSearchedMovies = function (context) {
    let genre = context.params.search;

    movieService.getAllMovies()
        .then(function (result) {
            result = result.filter(x => x.genres.includes(genre));

            context.isAuth = userService.isAuth();
            context.username = sessionStorage.getItem('username');
            context.movies = result;

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs',
                movie: 'templates/movies/movie.hbs'
            })
                .then(function () {
                    this.partial('templates/movies/cinema.hbs');
                });
        })
};