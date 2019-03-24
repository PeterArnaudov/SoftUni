function solve() {
    function changePosition() {
        let horizontalRange = Math.floor(Math.random() * 81);
        let verticalRange = Math.floor(Math.random() * 45);

        noSignalDivElement.style.marginTop = `${horizontalRange}%`;
        noSignalDivElement.style.marginLeft = `${verticalRange}vh`;
    }

    let noSignalDivElement = document.getElementById('exercise').children[0];

    setInterval(changePosition, 2000);
}