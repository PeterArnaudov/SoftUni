function solve() {
    let arrayElement = document.getElementById('arr');
    let stringElement = document.getElementById('str');
    let resultElement = document.getElementById('result');

    let arrayOfStrings = JSON.parse(arrayElement.value);
    let searched = new RegExp(arrayOfStrings[0].split(' ')[2], "gi");
    let replacement = stringElement.value;

    for (let array of arrayOfStrings) {
        let paragraph = document.createElement('p');
        paragraph.textContent = array.replace(searched, replacement);
        resultElement.appendChild(paragraph);
    }
}