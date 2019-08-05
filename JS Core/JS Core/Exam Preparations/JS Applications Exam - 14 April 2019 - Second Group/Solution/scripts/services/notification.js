const notifications = (() => {
    $(document).on({
        ajaxStart: () => $('#loadingBox').fadeIn(),
        ajaxStop: () => $('#loadingBox').fadeOut()
    });

    function showSuccess(message) {
        let successBox = $('#infoBox');
        $('#infoBox span').text(message);
        successBox.fadeIn();
        successBox.fadeOut(5000);
    }

    function showError(message) {
        let errorBox = $('#errorBox');
        $('#errorBox span').text(message);
        errorBox.fadeIn();
    }

    return {
        showSuccess,
        showError
    }
})();