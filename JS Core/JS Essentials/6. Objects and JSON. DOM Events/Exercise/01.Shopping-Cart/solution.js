function solve() {
    let buttonElements = document.querySelectorAll('button');
    buttonElements[0].addEventListener('click', addToCart);
    buttonElements[1].addEventListener('click', addToCart);
    buttonElements[2].addEventListener('click', addToCart);
    buttonElements[3].addEventListener('click', cartInfo);
    
    let resultElement = document.querySelector('textarea');
    let cart = {
        products: new Set(),
        bill: 0
    };

    function getProductName(button) {
        let divElement = button.parentElement;
        
        return divElement.querySelectorAll('p')[0].textContent;
    }
    function getProductPrice(button) {
        let divElement = button.parentElement;

        return +divElement.querySelectorAll('p')[1].textContent.split(': ')[1];
    }
    
    function addToCart() {
        let name = getProductName(this);
        let price = getProductPrice(this);

        resultElement.textContent += `Added ${name} for ${price.toFixed(2)} to the cart.\n`;

        cart.products.add(name);
        cart.bill += price;
    }
    
    function cartInfo() {
        resultElement.textContent += `You bought ${Array.from(cart.products).join(', ')} for ${cart.bill.toFixed(2)}.\n`;
        cart.products = new Set();
        cart.bill = 0;
    }
}