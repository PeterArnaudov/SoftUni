function binarySearch() {
    let listInput = document.getElementById("arr").value;
    let list = listInput.split(', ').map(li => parseInt(li)).filter(a => a !== '');
    let value = parseInt(document.getElementById("num").value);

    function result(list, value) {
        let start = 0;
        let stop = list.length - 1;
        let middle = Math.floor((start + stop) / 2);

        while (list[middle] !== value && start < stop) {
            if (value < list[middle]) {
                stop = middle - 1;
            } else {
                start = middle + 1;
            }

            middle = Math.floor((start + stop) / 2);
        }
        return (list[middle] !== value) ? -1 : middle;
    }

    let index = result(list, value);
    let resultVal = '';

    if (index >= 0) {
        resultVal = (`Found ${list[index]} at index ${index}`);
    } else {
        resultVal = (`${value} is not in the array`);
    }
    
    document.getElementById("result").innerHTML = resultVal;
}