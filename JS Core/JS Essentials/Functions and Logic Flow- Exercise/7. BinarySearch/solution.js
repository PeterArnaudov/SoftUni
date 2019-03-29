function binarySearch() {
    let arrayElement = document.getElementById('arr');
    let numberElement = document.getElementById('num');
    let resultElement = document.getElementById('result');

    let array = Array.from(arrayElement.value.split(', '));
    let number = numberElement.value;

    resultElement.textContent = array.includes(number) ? `Found ${number} at index ${array.indexOf(number)}` : `${number} is not in the array`;
}