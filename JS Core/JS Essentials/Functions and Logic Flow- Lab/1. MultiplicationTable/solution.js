function solve() {
    function createMultiplicationTable(numOne, numTwo) {
        let resultElement = document.getElementById('result');
        resultElement.textContent = '';

        if (numOne > numTwo) {
            resultElement.textContent = "Try with other numbers.";
        }
        else {
            for (let i = numOne; i <= numTwo; i++) {
                let paragraph = document.createElement('p');
                paragraph.textContent = `${i} * ${numTwo} = ${i * numTwo}`;
                resultElement.appendChild(paragraph);
            }
        }
    }

    let numberOneElement = document.getElementById('num1');
    let numberTwoElement = document.getElementById('num2');

    let numberOne = +numberOneElement.value;
    let numberTwo = +numberTwoElement.value;

    let buttonElement = document.getElementsByTagName('input')[2];
    buttonElement.addEventListener('click', createMultiplicationTable(numberOne, numberTwo));
}