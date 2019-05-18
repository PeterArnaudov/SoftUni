function currencyFormatter(separator, symbol, symbolFirst, value) {
    let result = Math.trunc(value) + separator;
    result += value.toFixed(2).substr(-2,2);
    if (symbolFirst)
        return symbol + ' ' + result;
    else
        return result + ' ' + symbol;
}

function getDollarFormatter(formatter) {
    function dollarFormatter(value) {
        let separator = ',';
        let symbol = '$';
        let symbolFirst = true;

        return formatter(separator, symbol, symbolFirst, value);
    }

    return dollarFormatter;
}

let dollarFormatter = getDollarFormatter(currencyFormatter);
console.log(dollarFormatter(5345));   // $ 5345,00
console.log(dollarFormatter(3.1429)); // $ 3,14
console.log(dollarFormatter(2.709));  // $ 2,71