function timer() {
    let seconds = 0;
    let minutes = 0;
    let hours = 0;

    let counting = false;
    let counter;

    function start() {
        if (counting == false) {
            counting = true;
            counter = setInterval(() => {
                seconds++;

                if (seconds == 60) {
                    seconds = 0;
                    minutes++;
                }
                if (minutes == 60) {
                    minutes = 0;
                    hours++;
                }

                $('#seconds').text(seconds < 10 ? `0${seconds}` : seconds);
                $('#minutes').text(minutes < 10 ? `0${minutes}` : minutes);
                $('#hours').text(hours < 10 ? `0${hours}` : hours);

            }, 1000);
        }
    }

    function stop() {
        if (counting == true) {
            counting = false;
            clearInterval(counter);
        }
    }

    $('#start-timer').click(start);
    $('#stop-timer').click(stop);
}