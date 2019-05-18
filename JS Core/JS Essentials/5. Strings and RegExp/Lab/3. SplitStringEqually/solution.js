function solve() {
    let stringElement = document.getElementById('str');
    let numberElement = document.getElementById('num');
    let resultElement = document.getElementById('result');

    let parts = [];
    let string = stringElement.value.split('');
    let number = numberElement.value;
    for (let i = 0; i < Math.ceil(stringElement.value.length / number); i++) {
        parts[i] = '';
        for (let j = 0; j < number; j++) {
            if (string.length == 0) {
                string = stringElement.value.split('');
            }

            parts[i] += string.shift();
        }
    }

    resultElement.textContent = parts.join(' ');
}