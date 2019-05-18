(function () {
    function solve() {
        let button = document.getElementsByTagName('button')[0];
        var months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
        let weights = [2, 4, 8, 5, 10, 9, 7, 3, 6];

        button.addEventListener("click", () => {
            function clearInputFields() {
                document.getElementById('date').value = "";
                document.getElementById('month').value = document.getElementsByTagName('option')[0].innerHTML;
                document.getElementById('year').value = "";
                document.getElementById('region').value = "";
                document.getElementById('male').checked = false;
                document.getElementById('female').checked = false;
            };

            function getEGN(date, month, year, region, gender) {
                date = ('0' + (document.getElementById('date').value)).slice(-2);
                month = ('0' + getMonth(document.getElementById('month').value)).slice(-2);
                year = ('0' + (document.getElementById('year').value)).slice(-2);
                region = (document.getElementById('region').value + '0').slice(0, 2);
                gender = (document.querySelector('input[name="gender"]:checked').value === 'Male') ? 2 : 1;

                let egn = String(year + month + date + region + gender);
                let remainder = getRemainder(egn);
                return egn += String(remainder);
            };

            function getMonth(word) {
                if (!months.includes(word)) {
                    return -1
                }
                return months.indexOf(word) + 1;
            }

            function getRemainder(egn) {
                let sum = 0;
                for (let i = 0; i < egn.length; i++) {
                    const digit = Number(egn[i]);
                    const weight = weights[i];
                    sum += (digit * weight);
                }
                let remainder = sum % 11;
                return remainder === 10 ? 0 : remainder;
            }

            let date, month, year, region, gender, egn;

            egn = getEGN(date, month, year, region, gender);
            document.getElementById('egn').innerHTML = `Your EGN is: ${egn}`;

            clearInputFields();
        })
    }
    return function () {
        solve();
    }
})();