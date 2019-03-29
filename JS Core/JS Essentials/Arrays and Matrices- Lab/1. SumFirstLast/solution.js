function solve() {
    let inputElement = document.getElementById('arr');
    let resultElement = document.getElementById('result');

    let inputArray = JSON.parse(inputElement.value);
    let outputArray = inputArray.map(x => x * inputArray.length);

    for (let i = 0; i < outputArray.length; i++) {
        let p = document.createElement('p');
        p.textContent = `${i} -> ${outputArray[i]}`;
        resultElement.appendChild(p);
    }
}
