function solve() {
    let keywordElement = document.getElementById('str');
    let textElement = document.getElementById('text');
    let resultElement = document.getElementById('result');

    let keyword = keywordElement.value;
    let text = textElement.value;

    let messagePattern = new RegExp(`${keyword}(.+)${keyword}`, "gi");
    let message = `Message: ${messagePattern.exec(text)[1]}`;

    let degreesPattern = new RegExp('(north|east)[\\s\\S]*?(\\d{2})[^,]*?,[^,]*?(\\d{6})', 'gi');
    let northDegrees;
    let eastDegrees;

    let currentDegreesMatch = degreesPattern.exec(text);
    while (currentDegreesMatch) {
        if (currentDegreesMatch[1].toLowerCase() == 'north') {
            northDegrees = `${currentDegreesMatch[2]}.${currentDegreesMatch[3]} N`;
        }
        else if (currentDegreesMatch[1].toLowerCase() == 'east') {
            eastDegrees = `${currentDegreesMatch[2]}.${currentDegreesMatch[3]} E`;
        }

        currentDegreesMatch = degreesPattern.exec(text);
    }

    let messageParagraph = document.createElement('p');
    let northParagraph = document.createElement('p');
    let eastParagraph = document.createElement('p');

    messageParagraph.textContent = message;
    northParagraph.textContent = northDegrees;
    eastParagraph.textContent = eastDegrees;

    resultElement.appendChild(northParagraph);
    resultElement.appendChild(eastParagraph);
    resultElement.appendChild(messageParagraph);
}