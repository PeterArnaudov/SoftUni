function solve() {
    function showMore() {
        let profileElement = this.parentNode;
        let unlockedRadioElement = profileElement.getElementsByTagName('input')[1];
        let buttonElement = profileElement.getElementsByTagName('button')[0];
        let lockedInformationDiv = profileElement.children[9];

        if (unlockedRadioElement.checked && buttonElement.textContent == 'Show more') {
            lockedInformationDiv.style.display = 'inline';
            lockedInformationDiv.getElementsByTagName('hr')[0].style.display = 'none';
            buttonElement.textContent = 'Hide it';
        }
        else if (unlockedRadioElement.checked && buttonElement.textContent == 'Hide it') {
            lockedInformationDiv.style.display = 'none';
            buttonElement.textContent = 'Show more';
        }
    }

    let profileElements = document.getElementsByClassName('profile');

    for (let i = 0; i < profileElements.length; i++) {
        profileElements[i].getElementsByTagName('button')[0].addEventListener('click', showMore);
    }
}