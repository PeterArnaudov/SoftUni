function solve() {
    function onClick() {
        let selectMenuToElementValue = document.getElementById('selectMenuTo').value;
        let inputNumberElementValue = document.getElementById('input').value;
        let resultElement = document.getElementById('result');

        if (selectMenuToElementValue == 'binary') {
            resultElement.value = (+inputNumberElementValue).toString(2);
        }
        else if (selectMenuToElementValue == 'hexadecimal') {
            resultElement.value = (+inputNumberElementValue).toString(16).toUpperCase();
        }
    }

    document.getElementsByTagName('button')[0].addEventListener('click', onClick);
}