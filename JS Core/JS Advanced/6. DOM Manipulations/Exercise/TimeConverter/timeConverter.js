function attachEventsListeners() {
    let daysInputElement = $('#days');
    let hoursInputElement = $('#hours');
    let minutesInputElement = $('#minutes');
    let secondsInputElement = $('#seconds');

    function convertDays() {
        let days = Number(daysInputElement.val());
        hoursInputElement.val(days * 24);
        minutesInputElement.val(days * 1440);
        secondsInputElement.val(days * 86400);
    }

    function convertHours() {
        let hours = Number(hoursInputElement.val());
        daysInputElement.val(hours / 24);
        minutesInputElement.val(hours * 60);
        secondsInputElement.val(hours * 3600);
    }

    function convertMinutes() {
        let minutes = Number(minutesInputElement.val());
        daysInputElement.val(minutes / 1440);
        hoursInputElement.val(minutes / 60);
        secondsInputElement.val(minutes * 60);
    }

    function convertSeconds() {
        let seconds = Number(secondsInputElement.val());
        daysInputElement.val(seconds / 86400);
        hoursInputElement.val(seconds / 3600);
        minutesInputElement.val(seconds / 60);
    }

    $('#daysBtn').click(convertDays);
    $('#hoursBtn').click(convertHours);
    $('#minutesBtn').click(convertMinutes);
    $('#secondsBtn').click(convertSeconds);
}
