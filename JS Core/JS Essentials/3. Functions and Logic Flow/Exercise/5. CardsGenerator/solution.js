function solve() {
    function generateCards() {
        let from = fromInputElement.value;
        let to = toInputElement.value;
        let cardsType = cardsTypeElement.value;

        for (let i = cardValues.indexOf(from); i <= cardValues.indexOf(to); i++) {
            let cardType = cardsType[cardsType.length - 1];

            let card = document.createElement('div');
            card.classList.add('card');

            let firstParagraph = document.createElement('p');
            let secondParagraph = document.createElement('p');
            let thirdParagraph = document.createElement('p');

            firstParagraph.textContent = cardType;
            secondParagraph.textContent = cardValues[i];
            thirdParagraph.textContent = cardType;

            card.appendChild(firstParagraph);
            card.appendChild(secondParagraph);
            card.appendChild(thirdParagraph);

            resultElement.appendChild(card);
        }
    }

    let cardValues = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];

    let fromInputElement = document.getElementById('from');
    let toInputElement = document.getElementById('to');
    let cardsTypeElement = document.querySelector('select');
    let resultElement = document.getElementById('cards');

    let buttonElement = document.querySelector('button');

    buttonElement.addEventListener('click', generateCards);
}