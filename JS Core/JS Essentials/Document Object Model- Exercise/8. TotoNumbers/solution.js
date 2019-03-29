function solve() {
    function onClick() {
        function validateNumbers(input) {
            if (input.length != 6) {
                return false;
            }

            for (let i = 0; i < input.length; i++) {
                if (input[i] < 1 || input[i] > 49) {
                    return false;
                }
            }

            return true;
        }
        let inputElement = document.querySelector('input');
        let input = inputElement.value.split(' ');
        let allNumbersDivElement = document.getElementById('allNumbers');

        if (validateNumbers(input)) {
            for (let i = 1; i <= 49; i++) {
                let currentDiv = document.createElement('div');
                currentDiv.classList.add('numbers');
                currentDiv.textContent = i;

                if (input.includes(i.toString())) {
                    currentDiv.style.background = 'orange';
                }

                allNumbersDivElement.appendChild(currentDiv);
            }

            inputElement.disabled = 'true';
            buttonElement.disabled = 'true';
        }
    }

    let buttonElement = document.querySelector('button');
    buttonElement.addEventListener('click', onClick);
}