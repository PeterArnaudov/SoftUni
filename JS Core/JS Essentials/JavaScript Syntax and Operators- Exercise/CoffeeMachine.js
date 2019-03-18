function solve(array) {
    let income = 0;

    for (let i = 0; i < array.length; i++) {
        let order = array[i].split(", ");

        let money = +order.shift();
        let type = order.shift();
        let price = 0;

        if (type == "coffee") {
            let coffeeType = order.shift();
            if (coffeeType == "caffeine") {
                price = 0.8;
            }
            else if (coffeeType == "decaf") {
                price = 0.9;
            }
        }
        else if (type == "tea") {
            price = 0.8;
        }

        let next = order.shift();
        if (next == "milk") {
            let milkPrice = Math.round(price) * 0.1;
            price += milkPrice;

            let sugar = order.shift();
            if (sugar != 0) {
                price += 0.1;
            }
        }
        else {
            if (next != 0) {
                price += 0.1;
            }
        }

        if (money >= price) {
            income += price;
            console.log(`You ordered ${type}. Price: ${price.toFixed(2)}$ Change: ${(money - price).toFixed(2)}$`)
        }
        else {
            console.log(`Not enough money for ${type}. Need ${(price - money).toFixed(2)}$ more.`)
        }
    }

    console.log(`Income Report: ${income.toFixed(2)}$`)
}