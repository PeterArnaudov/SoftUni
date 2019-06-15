function solve() {
    let buttonElements = document.querySelectorAll('button');

    buttonElements[0].addEventListener('click', load);
    buttonElements[1].addEventListener('click', buy);
    buttonElements[2].addEventListener('click', endDay);

    let logElement = document.getElementsByTagName('textarea')[2];

    let storage = new Map();
    let profit = 0;

    function load() {
        let inputElement = document.getElementsByTagName('textarea')[0];
        let input = JSON.parse(inputElement.value);

        for (let product of input) {
            let name = product.name;
            let quantity = +product.quantity;
            let price = product.price;

            if (!storage.has(name)) {
                storage.set(name ,{
                    quantity: 0,
                    price: price
                });
            }

            storage.get(name).quantity += quantity;
            storage.get(name).price = price;

            logElement.textContent += `Successfully added ${quantity} ${name}. Pride: ${price}\n`;
        }
    }

    function buy() {
        let inputElement = document.getElementsByTagName('textarea')[1];
        let input = JSON.parse(inputElement.value);

        let name = input["name"];
        let quantity = input["quantity"];

        if (storage.has(name) && storage.get(name).quantity >= quantity) {
            let price = storage.get(name).price;

            storage.get(name).quantity -= quantity;
            let orderPrice = quantity * price;
            profit += orderPrice;

            logElement.textContent += `${quantity} ${name} sold for ${orderPrice}.\n`;
        }
        else {
            logElement.textContent += 'Cannot complete order.\n';
        }
    }
    
    function endDay() {
        logElement.textContent += `Profit: ${profit.toFixed(2)}.`;

        buttonElements.forEach(x => x.disabled = true);
    }
}