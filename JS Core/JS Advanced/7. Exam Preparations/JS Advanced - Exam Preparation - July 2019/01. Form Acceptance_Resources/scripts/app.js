function acceptance() {
    document.querySelector('#acceptance').addEventListener('click', add);
    
    function add() {
        let inputFields = document.querySelectorAll('input');
        let companyInput = inputFields[0];
        let productInput = inputFields[1];
        let quantityInput = inputFields[2];
        let scrapeInput = inputFields[3];

        if (companyInput.value
            && productInput.value
            && quantityInput.value.match('^\\d+$')
            && scrapeInput.value.match('^\\d+$')) {
            let availableQuantity = +quantityInput.value - +scrapeInput.value;

            if (availableQuantity > 0) {
                let divElement = document.createElement('div');
                let paragraph = document.createElement('p');
                let button = document.createElement('button');

                paragraph.textContent = `[${companyInput.value}] ${productInput.value} - ${availableQuantity} pieces`;
                button.textContent = 'Out of stock';
                button.addEventListener('click', remove);

                divElement.appendChild(paragraph);
                divElement.appendChild(button);

                document.querySelector('#warehouse').appendChild(divElement);
            }
        }

        Array.from(inputFields).forEach(x => x.value = '');
    }

    function remove(e) {
        document.querySelector('#warehouse').removeChild(e.target.parentNode);
    }
}