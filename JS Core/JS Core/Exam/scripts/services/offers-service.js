const offersService = (() => {
    function getAllOffers() {
        return kinvey.get('appdata', 'offers', 'kinvey');
    }

    function getOffer(id) {
        return kinvey.get('appdata', 'offers/' + id, 'kinvey');
    }

    function createOffer(data) {
        return kinvey.post('appdata', 'offers', 'kinvey', data);
    }

    function deleteOffer(id) {
        return kinvey.remove('appdata', 'offers/' + id, 'kinvey');
    }

    function editEvent(data) {
        return kinvey.update('appdata', 'offers/' + data._id, 'kinvey', data)
    }

    return {
        getAllOffers,
        getOffer,
        createOffer,
        deleteOffer,
        editEvent
    }
})();