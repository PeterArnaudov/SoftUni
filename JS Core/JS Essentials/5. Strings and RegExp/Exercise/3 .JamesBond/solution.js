function solve() {
    function decodeWord(word) {
        while (word.indexOf('!') !== -1) {
            word = word.replace('!', '1');
        }
        while (word.indexOf('%') !== -1) {
            word = word.replace('%', 2);
        }
        while (word.indexOf('#') !== -1) {
            word = word.replace('#', '3');
        }
        while (word.indexOf('$') !== -1) {
            word = word.replace('$', '4');
        }

        return word.toLowerCase();
    }

    let inputElement = document.getElementById('arr');
    let resultElement = document.getElementById('result');

    let input = JSON.parse(inputElement.value);
    console.log(input);

    let specialKey = input[0];
    let pattern = new RegExp(`(?:^|\\s)(?:${specialKey})\\s+([A-Z!%$#]{8,})(?:\\.|,|\\s|$)`, 'gi');

    for (let i = 1; i < input.length; i++) {
        let currentString = input[i];
        let match;

        while (match = pattern.exec(currentString)) {
            if (match[1].toUpperCase() === match[1]){
                let decodedWord = decodeWord(match[1]);

                currentString = currentString.replace(match[1], decodedWord);
            }
        }

        let paragraphElement = document.createElement('p');
        paragraphElement.textContent = currentString;

        resultElement.appendChild(paragraphElement);
    }
}