const eventService = (() => {
    function getAllEvents() {
        return kinvey.get('appdata', 'events', 'kinvey');
    }

    function getEvent(id) {
        return kinvey.get('appdata', 'events/' + id, 'kinvey');
    }

    function createEvent(data) {
        return kinvey.post('appdata', 'events', 'kinvey', data);
    }

    function deleteEvent(id) {
        return kinvey.remove('appdata', 'events/' + id, 'kinvey');
    }

    function editEvent(data) {
        return kinvey.update('appdata', 'events/' + data._id, 'kinvey', data)
    }

    return {
        getAllEvents,
        getEvent,
        createEvent,
        deleteEvent,
        editEvent
    }
})();