function getNext() {
    function solve(num) {
        if (num === 1) {
            return null;
        } else if (num % 2 === 0) {
            return num / 2;
        } else {
            return num * 3 + 1;
        }

    }

    function generateSeq(num) {
        let seq = [];
        seq.push(num);
        while (num) {
            num = solve(num);
            seq.push(num);
        }
        return seq;
    }

    let num = parseInt(document.getElementById("num").value);
    let result = generateSeq(num);
    document.getElementById("result").innerHTML = result.join(" ");

}