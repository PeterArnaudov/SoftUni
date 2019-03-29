function solve() {
    function onClick(button) {
        if (this == buttonElements[0]) {
            let message = textAreaElements[0].value;
            let encodedMessage = '';

            for (let i = 0; i < message.length; i++) {
                encodedMessage += String.fromCharCode(`${message[i]}`.charCodeAt() + 1);
            }

            textAreaElements[0].value = '';
            textAreaElements[1].value = encodedMessage;
        }
        else if (this == buttonElements[1]) {
            let encodedMessage = textAreaElements[1].value;
            let decodedMessage = '';

            for (let i = 0; i < encodedMessage.length; i++) {
                decodedMessage += String.fromCharCode(`${encodedMessage[i]}`.charCodeAt() - 1);
            }

            textAreaElements[1].value = decodedMessage;
        }
    }

    let buttonElements = document.getElementsByTagName('button');
    let textAreaElements = document.getElementsByTagName('textarea');

    for (let button of buttonElements) {
        button.addEventListener('click', onClick);
    }
}