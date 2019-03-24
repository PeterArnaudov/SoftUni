function solve() {
    function nextClick() {
        if (nextButtonClicks == 0) {
            nextButtonClicks++;

            contentDivElement.style.backgroundImage = 'none';
            firstStepDivElement.style.display = 'inline';
        }
        else if (nextButtonClicks == 1) {
            if (radioButtons[0].checked) {
                nextButtonClicks++;

                firstStepDivElement.style.display = 'none';
                secondStepDivElement.style.display = 'inline';
                nextButtonElement.style.display = 'none';

                setTimeout(() => { nextButtonElement.style.display = 'inline' },3000);
            }
        }
        else if (nextButtonClicks == 2) {
            nextButtonClicks++;

            secondStepDivElement.style.display = 'none';
            thirdStepDivElement.style.display = 'inline';
            nextButtonElement.style.display = 'none';
            cancelButtonElement.textContent = 'Finish';
        }
    }

    function cancelClick() {
        let exerciseBodyElement = document.getElementById('exercise');
        exerciseBodyElement.children[0].style.display = 'none';
    }

    let nextButtonElement = document.getElementsByTagName('button')[0];
    let nextButtonClicks = 0;
    let cancelButtonElement = document.getElementsByTagName('button')[1];
    let contentDivElement = document.getElementById('content');
    let firstStepDivElement = document.getElementById('firstStep');
    let radioButtons = document.getElementsByTagName('input');
    let secondStepDivElement = document.getElementById('secondStep');
    let thirdStepDivElement = document.getElementById('thirdStep');

    nextButtonElement.addEventListener('click', nextClick);
    cancelButtonElement.addEventListener('click', cancelClick);
}