function solve() {
    let inputElement = document.getElementById('str');
    let resultElement = document.getElementById('result');

    let input = inputElement.value.split(' ');

    let words = input.filter(x => x.match(/[^\d]+/g));
    let numbers = input.filter(Number);

    for (let word of words) {
        let paragraph = document.createElement('p');
        let currentParagraph = [];
        for (let index in word) {
            currentParagraph.push(word.charCodeAt(index));
        }
        paragraph.textContent = currentParagraph.join(' ');
        resultElement.appendChild(paragraph);
    }

    let paragraph = document.createElement('p');
    let word = '';
    for (let number of numbers) {
        word += String.fromCharCode(number);
    }
    paragraph.textContent = word;
    resultElement.appendChild(paragraph);
}