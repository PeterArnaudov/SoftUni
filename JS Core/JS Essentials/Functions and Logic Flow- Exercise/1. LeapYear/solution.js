function leapYear() {
    let btn = document.querySelector('#exercise button')
        .addEventListener('click', checkTheYear);

    function checkTheYear() {
        let year = document.querySelector('#exercise input');
        let isLeap = leapYear(year.value);

        let h2 = document.querySelector('#year h2');

        if (isLeap) {
            h2.textContent = 'Leap Year';
        } else {
            h2.textContent = 'Not Leap Year';
        }

        let divContainer = document.querySelector('#year div');
        divContainer.textContent = year.value;

        year.value = '';
    }

    function leapYear(year) {
        return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
    }
}