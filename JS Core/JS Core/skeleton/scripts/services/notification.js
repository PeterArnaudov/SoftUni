const notifications = (() => {
    $(document).on({
        ajaxStart: () => $('#loadingNotification').fadeIn(),
        ajaxStop: () => $('#loadingNotification').fadeOut()
    });

    function showSuccess(message) {
        let successBox = $('#infoNotification');
        successBox.text(message);
        successBox.fadeIn();
        successBox.fadeOut(3000);
    }

    function showError(message) {
        let errorBox = $('#errorNotification');
        errorBox.text(message);
        errorBox.fadeIn();
        errorBox.fadeOut(3000);
    }

    return {
        showSuccess,
        showError
    }
})();