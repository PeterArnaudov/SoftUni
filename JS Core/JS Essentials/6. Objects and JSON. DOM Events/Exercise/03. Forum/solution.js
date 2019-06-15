function solve() {
    let buttonElements = document.querySelectorAll('button');
    buttonElements.forEach(x => x.addEventListener('click', button => button.preventDefault()));

    let submitButton = buttonElements[0];
    let searchButton = buttonElements[1];

    submitButton.addEventListener('click', registerUser);
    searchButton.addEventListener('click', search);

    function registerUser() {
        let usernameElement = document.querySelector('input[placeholder="username"]');
        let passwordElement = document.querySelector('input[placeholder="password"]');
        let emailElement = document.querySelector('input[placeholder="email"]');
        let checkboxElements = document.querySelectorAll('input[type="checkbox"]');

        let username = usernameElement.value;
        let password = passwordElement.value;
        let email = emailElement.value;
        let topics = [];

        checkboxElements.forEach(x => x.checked ? topics.push(x.value) : {});

        let tableBodyElement = document.querySelector('tbody');
        let row = tableBodyElement.insertRow(-1);
        let usernameCell = row.insertCell(0);
        let emailCell = row.insertCell(1);
        let topicsCell = row.insertCell(2);

        usernameCell.textContent = username;
        emailCell.textContent = email;
        topicsCell.textContent = topics.join(' ');
    }

    function search() {
        let searchInputElement = document.querySelector('input[placeholder="Search..."]');

        let searchBy = searchInputElement.value;

        let tableBodyElement = document.querySelector('tbody');

        for (let row of tableBodyElement.children) {
            row.style.visibility = "hidden";
            for (let cell of row.children) {
                if (cell.textContent.includes(searchBy)) {
                    row.style.visibility = "visible";
                    break;
                }
            }
        }
    }
}