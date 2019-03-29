function solve() {
    let listInput = JSON.parse(document.getElementById("arr").value);
    let divResult = $('#result')

    function calculate(list) {
        for (let i = 0; i < list.length; i++) {
            let p = $('<p>');
            divResult.append(p.text(`${i} -> ${list[i]*list.length}`))
        }
    }
    calculate(listInput);
}