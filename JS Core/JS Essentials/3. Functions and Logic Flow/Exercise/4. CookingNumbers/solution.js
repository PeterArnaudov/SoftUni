function solve() {
    function chop() {
        number = getNumber();
        number /= 2;
        outputElement.textContent = number;
    }

    function dice() {
        number = getNumber();
        number = Math.sqrt(number);
        outputElement.textContent = number;
    }

    function spice() {
        number = getNumber();
        number++;
        outputElement.textContent = number;
    }

    function bake() {
        number = getNumber();
        number *= 3;
        outputElement.textContent = number;
    }

    function fillet() {
        number = getNumber();
        number = number * 0.8;
        outputElement.textContent = number;
    }

    function getNumber() {
        if (outputElement.textContent) {
            return +outputElement.textContent;
        }
        else {
            return +inputElement.value;
        }
    }

    let inputElement = document.querySelector('input');
    let outputElement = document.getElementById('output');

    let chopButton = document.getElementsByTagName('button')[0];
    let diceButton = document.getElementsByTagName('button')[1];
    let spiceButton = document.getElementsByTagName('button')[2];
    let bakeButton = document.getElementsByTagName('button')[3];
    let filletButton = document.getElementsByTagName('button')[4];

    let number = 0;

    chopButton.addEventListener('click', chop);
    diceButton.addEventListener('click', dice);
    spiceButton.addEventListener('click', spice);
    bakeButton.addEventListener('click', bake);
    filletButton.addEventListener('click', fillet);
}
