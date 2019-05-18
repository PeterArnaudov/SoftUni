function solve() {
    let stringOneElement = document.getElementById('str1');
    let stringTwoElement = document.getElementById('str2');
    let resultElement = document.getElementById('result');

    let text = stringOneElement.value;
    let typeCase = stringTwoElement.value;

    let output = '';

    if (typeCase == 'Pascal Case') {
        output = text.toLowerCase().split(' ').map(x => x.charAt(0).toUpperCase() + x.slice(1, x.length)).join('');
    }
    else if (typeCase == 'Camel Case') {
        let array = text.toLowerCase().split(' ').map(x => x.charAt(0).toUpperCase() + x.slice(1, x.length));
        array[0] = array[0].charAt(0).toLowerCase() + array[0].slice(1, array[0].length);
        output = array.join('');
    }
    else {
        output = 'Error!';
    }

    resultElement.textContent = output;
}