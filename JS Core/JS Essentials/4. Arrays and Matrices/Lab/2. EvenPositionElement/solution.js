function solve() {
    let inputElement = document.getElementById('arr');
    let resultElement = document.getElementById('result');

    let inputArray = JSON.parse(inputElement.value);
    let outputArray = inputArray.filter(x => inputArray.indexOf(x) % 2 == 0);

    resultElement.textContent = outputArray.join(' x ');
}