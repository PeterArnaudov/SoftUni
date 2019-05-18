function solve() {
    let inputElement = document.getElementById('num');
    let input = inputElement.value;

    function getFactors(number) {
        let factors = new Set();
        for (let i = 1; i < number; i++) {
            for (let j = 1; j <= number; j++) {
                if (i * j == number) {
                    factors.add(i);
                    factors.add(j);
                }
            }
        }

        return factors;
    }

    let resultElement = document.getElementById('result');
    resultElement.textContent = Array.from(getFactors(input)).sort((a, b) => a-b).join(' ');
}