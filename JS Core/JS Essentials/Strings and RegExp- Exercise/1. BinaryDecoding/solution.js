function solve() {
    function getWeight(string) {
        let sum = 0;
        let weight = 0;

        for (let char of string) {
            sum += +char;
        }

        if (sum < 9) {
            return sum;
        }

        weight = sum;
        while (weight > 9) {
            weight = sum;
            sum = 0;

            for (let char of weight.toString()) {
                sum += +char;
            }
        }

        return weight;
    }
    function removeFromString(string, weight) {
        string = string.substring(weight, string.length);
        string = string.substring(0, string.length - weight);
        return string;
    }
    function separateString(string) {
        return string.match(/\d{8}/g);
    }
    function convertToDecimals(binaries) {
        let decimals = [];

        for (let binary of binaries) {
            decimals.push(parseInt(binary, 2));
        }

        return decimals;
    }
    function convertToString(decimals) {
        let string = '';

        for (let decimal of decimals) {
            let char = String.fromCharCode(decimal);

            if (char.match(/[a-zA-Z ]/g)) {
                string += String.fromCharCode(decimal);
            }
        }

        return string;
    }

    let inputElement = document.getElementById('str');
    let resultElement = document.getElementById('result');

    let input = inputElement.value;

    let weight = getWeight(input);
    input = removeFromString(input, weight);
    let binaries = separateString(input);
    let decimals = convertToDecimals(binaries);
    let output = convertToString(decimals);

    resultElement.textContent = output;
}