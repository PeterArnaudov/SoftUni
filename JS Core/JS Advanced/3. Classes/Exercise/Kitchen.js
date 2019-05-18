class Kitchen {
    constructor(budget) {
        this.budget = budget;
        this.menu = {};
        this.productsInStock = {};
        this.actionsHistory = [];
    }

    loadProducts(products) {
        for (let product of products) {
            let productInfo = product.split(' ');
            let productName = productInfo[0];
            let productQuantity = +productInfo[1];
            let productPrice = +productInfo[2];

            if (this.budget >= productPrice) {
                if (!this.productsInStock.hasOwnProperty(productName)) {
                    this.productsInStock[productName] = productQuantity;
                }
                else {
                    this.productsInStock[productName] += productQuantity;
                }

                this.budget -= productPrice;
                this.actionsHistory.push(`Successfully loaded ${productQuantity} ${productName}`);
            }
            else {
                this.actionsHistory.push(`There was not enough money to load ${productQuantity} ${productName}`)
            }
        }

        return this.actionsHistory.join('\n');
    }

    addToMenu(meal, neededProducts, price) {
        if (this.menu.hasOwnProperty(meal)) {
            return `The ${meal} is already in our menu, try something different.`;
        }
        else {
            this.menu[meal] = {
                products: neededProducts,
                price: +price
            };

            return `Great idea! Now with the ${meal} we have ${Object.keys(this.menu).length} meals in the menu, other ideas?`;
        }
    }

    showTheMenu() {
        if (Object.keys(this.menu).length === 0) {
            return 'Our menu is not ready yet, please come later...';
        }
        else {
            let info = [];

            for (let meal of Object.keys(this.menu)) {
                info.push(`${meal} - $ ${this.menu[meal].price}`);
            }

            return info.join('\n') + '\n';
        }
    }

    makeTheOrder(meal) {
        if (!Object.keys(this.menu).includes(meal)) {
            return `There is not ${meal} yet in our menu, do you want to order something else?`;
        }
        else {
            let mealObject = this.menu[meal];

            let inStock = false;

            for (let neededProduct of mealObject.products) {
                let productInfo = neededProduct.split(' ');
                let productName = productInfo[0];
                let productQuantity = +productInfo[1];

                if (!this.productsInStock.hasOwnProperty(productName) || productQuantity > this.productsInStock[productName]) {
                    inStock = false;
                    break;
                }
                else {
                    inStock = true;
                }
            }

            if (inStock) {
                for (let neededProduct of mealObject.products) {
                    let productInfo = neededProduct.split(' ');
                    let productName = productInfo[0];
                    let productQuantity = +productInfo[1];

                    this.productsInStock[productName] -= productQuantity;
                }

                this.budget += mealObject.price;

                return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${mealObject.price}.`;
            }
            else {
                return `For the time being, we cannot complete your order (${meal}), we are very sorry...`;
            }
        }
    }
}