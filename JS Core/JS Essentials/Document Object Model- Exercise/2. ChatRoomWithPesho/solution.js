function solve() {
    function onClick(button) {
        let currentMessageDiv = document.createElement('div');
        let currentMessageSpan = document.createElement('span');
        let currentMessageParagraph = document.createElement('p');

        currentMessageDiv.appendChild(currentMessageSpan);
        currentMessageDiv.appendChild(currentMessageParagraph);

        let myChatBoxElement = document.getElementById('myChatBox');
        let peshoChatBoxElement = document.getElementById('peshoChatBox');

        if (this == userSentButtonElement) {
            currentMessageSpan.textContent = 'Me';
            currentMessageParagraph.textContent = myChatBoxElement.value;
            currentMessageDiv.style.textAlign = 'left';
        }
        else if (this == peshoSentButtonElement) {
            currentMessageSpan.textContent = 'Pesho';
            currentMessageParagraph.textContent = peshoChatBoxElement.value;
            currentMessageDiv.style.textAlign = 'right';
        }

        document.getElementById('chatChronology').appendChild(currentMessageDiv);
        myChatBoxElement.value = '';
        peshoChatBoxElement.value = '';
    }

    let userSentButtonElement = document.getElementsByName('myBtn')[0];
    let peshoSentButtonElement = document.getElementsByName('peshoBtn')[0];

    userSentButtonElement.addEventListener('click', onClick);
    peshoSentButtonElement.addEventListener('click', onClick);
}