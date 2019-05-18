function solve() {
    function onClick() {
        function atLeastOneRadioSelected(radioElements) {
            for (let element of radioElements)
                if (element.checked)
                    return element;
        }
        let radioElements = sectionElements[sectionNumber].getElementsByTagName('input');
        let selectedRadioElement = atLeastOneRadioSelected(radioElements);

        if (selectedRadioElement.value == correctAnswers[sectionNumber]) {
            points++;
        }

        sectionNumber++;

        if (sectionNumber == sectionElements.length) {
            let resultDivElement = document.getElementById('result');
            resultDivElement.textContent = points == sectionElements.length ? 'You are recognized as top SoftUni fan!' : `You have ${points} right answers`;
        }
        else {
            sectionElements[sectionNumber].style.display = 'block';
        }
    }

    let sectionElements = document.getElementById('exercise').children;
    let sectionNumber = 0;
    let points = 0;
    let correctAnswers = ['2013', 'Pesho', 'Nakov'];

    for (element of document.getElementsByTagName('button')) {
        element.addEventListener('click', onClick);
    }
}