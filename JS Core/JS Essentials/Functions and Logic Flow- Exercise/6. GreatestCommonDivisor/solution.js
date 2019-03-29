function greatestCD() {
    function greatestCommonDivisor(a, b) {
        if (b == 0) {
            resultElement.textContent = a;
            return;
        }

        return greatestCommonDivisor(b, a % b);
    }

    let numberOneInputElement = document.getElementById('num1');
    let numberTwoInputElement = document.getElementById('num2');
    let buttonElement = document.getElementsByTagName('input')[2];
    let resultElement = document.getElementById('result');

    let numberOne = +numberOneInputElement.value;
    let numberTwo = +numberTwoInputElement.value;

    buttonElement.addEventListener('click', greatestCommonDivisor(numberOne, numberTwo));
}