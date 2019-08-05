handlers.getOrganize = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    context.loadPartials({
        header: 'templates/common/header.hbs',
        footer: 'templates/common/footer.hbs'
    })
        .then(function () {
            this.partial('templates/events/createEvent.hbs');
        });
};

handlers.getEventDetails = function (context) {
    let id = context.params.id.replace(':', '');
    let event = eventService.getEvent(id)
        .then(function (result) {
            context.isAuth = userService.isAuth();
            context.username = sessionStorage.getItem('username');
            context.id = result._id;
            context.imageURL = result.imageURL;
            context.title = result.name;
            context.description = result.description;
            context.dateTime = result.dateTime;
            context.peopleInterestedIn = result.peopleInterestedIn;
            context.organizer = result.organizer;
            context.isOrganizer = result.organizer === sessionStorage.getItem('username');

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('templates/events/detailsEvent.hbs');
                });
        });
};

handlers.joinEvent = function (context) {
    let id = context.params.id.replace(':', '');

    eventService.getEvent(id)
        .then(function (data) {
            if (data.organizer !== sessionStorage.getItem('username')) {
                let editedData = {
                    _id: id,
                    name: data.name,
                    dateTime: data.dateTime,
                    description: data.description,
                    imageURL: data.imageURL,
                    organizer: data.organizer,
                    peopleInterestedIn: +data.peopleInterestedIn + 1
                };

                eventService.editEvent(editedData)
                    .then(function () {
                        notifications.showSuccess('You joined the event successfully!');
                        context.redirect('#/home');
                    })
            }
            else {
                notifications.showError('Organizer cannot join their event!');
                context.redirect('#/home');
            }
        });
};

handlers.getEdit = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');
    context.id = context.params.id.replace(':', '');

    context.loadPartials({
        header: 'templates/common/header.hbs',
        footer: 'templates/common/footer.hbs'
    })
        .then(function () {
            this.partial('templates/events/editEvent.hbs');
        });
};

handlers.editEvent = function (context) {
    let id = context.params.id.replace(':', '');

    eventService.getEvent(id)
        .then(function (data) {
            if (context.params.name.length < 6) {
                notifications.showError('Event name has to be at least 6 symbols long!');
            }
            else if (!context.params.dateTime.match('\\d{1,2} \\w+(?: - \\d{2} [A-Z]{2})*')) {
                notifications.showError('Event date and time should be valid!');
            }
            else if (context.params.description.length < 10) {
                notifications.showError('Event description should be at least 10 symbols long!');
            }
            else if (!context.params.imageURL.match('https*:\\/\\/')) {
                notifications.showError('Image URL should start with http://... or https://...');
            }
            else {
                let editedData = {
                    _id: id,
                    name: context.params.name,
                    dateTime: context.params.dateTime,
                    description: context.params.description,
                    imageURL: context.params.imageURL,
                    organizer: data.organizer,
                    peopleInterestedIn: data.peopleInterestedIn
                };

                eventService.editEvent(editedData)
                    .then(function () {
                        notifications.showSuccess('Event edited successfully!');
                        context.redirect('#/home');
                    })
            }
        });
};

handlers.createEvent = function (context) {
    let name = context.params.name;
    let dateTime = context.params.dateTime;
    let description = context.params.description;
    let imageURL = context.params.imageURL;
    let peopleInterestedIn = 0;
    let organizer = sessionStorage.username;

    if (name.length < 6) {
        notifications.showError('Event name has to be at least 6 symbols long!');
    }
    else if (!dateTime.match('\\d{1,2} \\w+(?: - \\d{2} [A-Z]{2})*')) {
        notifications.showError('Event date and time should be valid!');
    }
    else if (description.length < 10) {
        notifications.showError('Event description should be at least 10 symbols long!');
    }
    else if (!imageURL.match('https*:\\/\\/')) {
        notifications.showError('Image URL should start with http://... or https://...');
    }
    else {
        let data = {
            name,
            dateTime,
            description,
            imageURL,
            peopleInterestedIn,
            organizer
        };

        eventService.createEvent(data)
            .then(function () {
                notifications.showSuccess('Event created successfully!');
                context.redirect('#/home');
            })
    }
};

handlers.deleteEvent = function (context) {
    let id = context.params.id.replace(':', '');

    eventService.deleteEvent(id)
        .then(function () {
            notifications.showSuccess('Event closed successfully!');
            context.redirect('#/home');
        })
};