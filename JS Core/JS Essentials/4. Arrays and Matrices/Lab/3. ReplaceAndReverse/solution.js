function solve() {
    let inputElement = document.getElementById('arr');
    let resultElement = document.getElementById('result');

    let inputArray = JSON.parse(inputElement.value);
    let outputArray = inputArray.map(x => x.split('').reverse().join('')).map(x => x.charAt(0).toUpperCase().concat(x.slice(1)));

    resultElement.textContent = outputArray.join(' ');
}