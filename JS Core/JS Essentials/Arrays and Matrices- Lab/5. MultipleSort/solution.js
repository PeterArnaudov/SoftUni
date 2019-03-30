function solve() {
    let inputElement = document.getElementById('arr');
    let resultElement = document.getElementById('result');

    let inputArrayOne = JSON.parse(inputElement.value);
    let inputArrayTwo = JSON.parse(inputElement.value);
    let outputArrayOne = inputArrayOne.sort((a, b) => a-b);
    let outputArrayTwo = inputArrayTwo.sort();

    let paragraphOne = document.createElement('div');
    let paragraphTwo = document.createElement('div');

    paragraphOne.textContent = outputArrayOne.join(', ');
    paragraphTwo.textContent = outputArrayTwo.join(', ');

    resultElement.appendChild(paragraphOne);
    resultElement.appendChild(paragraphTwo);
}