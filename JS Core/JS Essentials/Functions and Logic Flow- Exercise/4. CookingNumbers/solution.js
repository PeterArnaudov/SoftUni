(function () {
    let output = $('#output');

    Array.from($('#operations button')).forEach((btn) => {
        btn.addEventListener('click', function () {
            let number = +output.text() || +$('#exercise input').val();
            console.log(number);
            let cookCmd = $(this).text().toLowerCase();
            let cookedNumber = operations[cookCmd](number);
            output.text(cookedNumber);
        })
    });

    let operations = {
        "chop": x => x / 2,
        "dice": x => Math.sqrt(x),
        "spice": x => x + 1,
        "bake": x => x * 3,
        "fillet": x => x * 0.8,
    };

})();