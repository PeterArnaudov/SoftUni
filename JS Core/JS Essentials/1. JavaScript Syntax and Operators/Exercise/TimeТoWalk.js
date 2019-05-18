function solve(steps, footLength, speed) {
    function minTwoDigits(number) {
        return (number < 10 ? '0' : '') + number;
    }

    let distanceInMeters = steps * footLength;
    let distanceInKilometers = distanceInMeters / 1000;
    let speedPerSecond = speed / 3600;

    let seconds = Math.round(distanceInKilometers / speedPerSecond);
    let minutes = Math.floor(distanceInMeters / 500);
    let hours = 0;

    while (seconds > 59) {
        seconds -= 60;
        minutes++;
    }

    while (minutes > 59) {
        minutes -= 60;
        hours++;
    }

    console.log(`${minTwoDigits(hours)}:${minTwoDigits(minutes)}:${minTwoDigits(seconds)}`);
}