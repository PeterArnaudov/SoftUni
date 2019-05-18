function solve() {
    function checkNumbers(start, end, stringOne, stringTwo, stringThree) {
        let resultElement = document.getElementById('result');

        for (let i = start; i <= end; i++) {
            let paragraph = document.createElement('p');

            if (i % 3 == 0 && i % 5 == 0) {
                let paragraph = document.createElement('p');
                paragraph.textContent = `${i} ${stringOne}-${stringTwo}-${stringThree}`;
                resultElement.appendChild(paragraph)
            }
            else if (i % 5 == 0) {
                let paragraph = document.createElement('p');
                paragraph.textContent = `${i} ${stringThree}`;
                resultElement.appendChild(paragraph)
            }
            else if (i % 3 == 0) {
                paragraph.textContent = `${i} ${stringTwo}`;
                resultElement.appendChild(paragraph)
            }
            else {
                paragraph.textContent = `${i}`;
                resultElement.appendChild(paragraph);
            }
        }
    }

    let firstNumberElement = document.getElementById('firstNumber');
    let secondNumberElement = document.getElementById('secondNumber');
    let firstStringElement = document.getElementById('firstString');
    let secondStringElement = document.getElementById('secondString');
    let thirdStringElement = document.getElementById('thirdString');

    let firstNumber = +firstNumberElement.value;
    let secondNumber = +secondNumberElement.value;
    let firstString = firstStringElement.value;
    let secondString = secondStringElement.value;
    let thirdString = thirdStringElement.value;

    let buttonElement = document.getElementsByTagName('input')[5];
    buttonElement.addEventListener('click', checkNumbers(firstNumber, secondNumber, firstString, secondString, thirdString));
}