function solve() {
    let listInput = JSON.parse(document.getElementById("arr").value);
    let result = [];

    function calculate(numArr) {
        numArr.forEach((element, index) => {
            if (index % 2 === 0) {
                result.push(element);
            }
        });
    }
    calculate(listInput);
    console.log(result);
    document.getElementById("result").innerHTML = result.join(' x ');
}