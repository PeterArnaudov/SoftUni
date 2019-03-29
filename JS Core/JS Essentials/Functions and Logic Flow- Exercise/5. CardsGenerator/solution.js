(function () {
    document.getElementsByTagName('button')[0].addEventListener('click', function () {
        let from = document.getElementById('from').value;
        let to = document.getElementById('to').value;

        let specialSuits = {
            'J': 11,
            'Q': 12,
            'K': 13,
            'A': 14,
        };

        if (isNaN(+from)) {
            from = specialSuits[from];
            specialSuits.isSpecial = true;
        }
        if (isNaN(+to)) {
            to = specialSuits[to];
            specialSuits.isSpecial = true;
        }


        let cards = document.getElementById('cards');

        let selectElement = document.getElementsByTagName('select')[0];
        let suit = selectElement.options[selectElement.selectedIndex].value.split(' ');

        for (let card = +from; card <= +to; card++) {
            cards.append(createCard(suit, card, specialSuits));
        }

        document.getElementById('from').value = "";
        document.getElementById('to').value = "";
    });

    function createCard(suit, value, specialObj) {
        let div = document.createElement('div');
        div.classList.add('card');

        let firstP = document.createElement('p');
        let middleP = document.createElement('p');
        let lastP = document.createElement('p');

        firstP.textContent = suit[1];

        if (value > 1 && value < 11) {
            middleP.textContent = value;
        } else {
            middleP.textContent = Object.keys(specialObj).filter((v) => specialObj[v] === value)[0];
        }

        lastP.textContent = suit[1];

        div.append(firstP);
        div.append(middleP);
        div.append(lastP);

        return div;
    }
})();