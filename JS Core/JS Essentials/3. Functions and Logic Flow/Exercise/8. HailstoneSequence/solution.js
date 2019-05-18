function getNext() {
    let numberElement = document.getElementById('num');
    let resutElement = document.getElementById('result');

    let number = numberElement.value;
    let array = [number];

    while (number != 1) {
        if (number % 2 == 0) {
            number /= 2;
            array.push(number);
        }
        else {
            number = number * 3 + 1;
            array.push(number);
        }
    }

    resutElement.textContent = array.join(' ') + ' ';
}