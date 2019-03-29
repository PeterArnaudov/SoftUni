function solve() {

    function factors(n) {
        let num_factors = [];

        for (let i = 1; i <= Math.floor(Math.sqrt(n)); i++) {
            if (n % i === 0) {
                num_factors.push(i);
                if (n / i !== i) {
                    num_factors.push(n / i);
                }
            }
        }

        num_factors.sort(function (x, y) {
            return x - y;
        });

        return num_factors;
    }

    let num = parseInt(document.getElementById("num").value);
    let result = factors(num);

    document.getElementById("result").innerHTML = result.join(" ");
}