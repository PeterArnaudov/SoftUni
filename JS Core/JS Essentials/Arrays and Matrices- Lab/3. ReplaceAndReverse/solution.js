function solve() {
    let listInput = JSON.parse(document.getElementById("arr").value);

    function calculate(numArr) {
        numArr.forEach((element, index) => {
            numArr[index] = element.split('').reverse().join('');
        });
        numArr.forEach((element, index) => {
            numArr[index] = element.charAt(0).toUpperCase().concat(element.slice(1));
        });

        return numArr.join(' ');
    }

    let result = calculate(listInput);
    document.getElementById("result").innerHTML = result;
}