function solve() {
    let searchedElement = document.getElementById('num');
    let textElement = document.getElementById('arr');

    let searched = searchedElement.value;
    let arrays = JSON.parse(textElement.value);

    let result = [];

    for (let i = 0; i < arrays.length; i++) {
        let currentSearch = arrays[i].includes(searched) ? `true -> ${arrays[i].indexOf(searched)}` : 'false -> -1';
        result.push(currentSearch);
    }

    let resultElement = document.getElementById('result');
    resultElement.textContent = result.join(',');
}
