function solve() {
    function onclick() {
        let textElement = this.parentNode.children[1];
        let text = textElement.textContent;
        let number = text.match(/\d+/g);
        text = text.replace(number, (+number + 1));
        textElement.textContent = text;
    }

    let aTagElements = document.getElementsByTagName('a');

    for (let aTagElement of aTagElements) {
        aTagElement.addEventListener('click', onclick);
    }
}
