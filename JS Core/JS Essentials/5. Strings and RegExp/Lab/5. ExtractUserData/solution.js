function solve() {
    let inputElement = document.getElementById('arr');
    let resultElement = document.getElementById('result');

    let inputArray = JSON.parse(inputElement.value);

    for (let input of inputArray) {
        let patternRegex = new RegExp('^([A-Z][a-z]* [A-Z][a-z]*) (\\+359(-| )(?:\\d+(?:\\3*))+) ((?:\\d|[a-z])+@[a-z]+.[a-z]{2,3})$', 'g');

        let match = patternRegex.exec(input);

        let dashesParagraph = document.createElement('p');
        dashesParagraph.textContent = '- - -';

        if (match) {
            let nameParagraph = document.createElement('p');
            let numberParagraph = document.createElement('p');
            let emailParagraph = document.createElement('p');

            nameParagraph.textContent = `Name: ${match[1]}`;
            numberParagraph.textContent = `Phone Number: ${match[2]}`;
            emailParagraph.textContent = `Email: ${match[4]}`;

            resultElement.appendChild(nameParagraph);
            resultElement.appendChild(numberParagraph);
            resultElement.appendChild(emailParagraph);
        }
        else {
            let invalidDataParagraph = document.createElement('p');
            invalidDataParagraph.textContent = 'Invalid data';

            resultElement.appendChild(invalidDataParagraph);
        }

        resultElement.appendChild(dashesParagraph);
    }
}