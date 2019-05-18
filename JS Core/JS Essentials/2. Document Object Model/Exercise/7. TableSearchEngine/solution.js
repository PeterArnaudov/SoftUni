function solve() {
    function search() {
        let selectedRows = document.getElementsByClassName('select');
        Array.from(selectedRows).forEach(row => row.classList.remove('select'));

        let tableElement = document.getElementsByTagName('table')[0];
        let searchFieldValue = document.getElementById('searchField').value.toLowerCase();
        document.getElementById('searchField').value = '';

        let rows = Array.from(document.querySelector("table tbody").children);

        for (let row of rows) {
            let cells = Array.from(row.children);
            for (let cell of cells) {
                if (cell.textContent.toLowerCase().includes(searchFieldValue)) {
                    row.classList.add('select');
                }
            }
        }
    }

    let searchButtonElement = document.getElementById('searchBtn');
    searchButtonElement.addEventListener('click', search);
}