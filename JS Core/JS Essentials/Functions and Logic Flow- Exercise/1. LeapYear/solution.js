function leapYear() {
    function checkYearClick() {
        function isYearLeap(year) {
            return year % 4 == 0;
        }

        let year = inputElement.value;
        showYearElement.textContent = year;

        if (isYearLeap(year)) {
            showYearTypeElement.textContent = 'Leap Year';
        }
        else {
            showYearTypeElement.textContent = 'Not Leap Year';
        }

        inputElement.value = '';
    }

    let inputElement = document.getElementsByTagName('input')[0];
    let showYearTypeElement = document.querySelector('h2');
    let showYearElement = document.querySelector('#year div');
    let buttonElement = document.querySelector('button');

    buttonElement.addEventListener('click', checkYearClick);
}