const notifications = (() => {
    $(document).on({
        ajaxStart: () => $('#loadingBox').fadeIn(),
        ajaxStop: () => $('#loadingBox').fadeOut()
    });

    function showSuccess(message) {
        let successBox = $('#infoBox');
        $('#infoBox').text(message);
        successBox.fadeIn();
        successBox.fadeOut(5000);
    }

    function showError(message) {
        let errorBox = $('#errorBox');
        $('#errorBox').text(message);
        errorBox.fadeIn();
    }

    return {
        showSuccess,
        showError
    }
})();