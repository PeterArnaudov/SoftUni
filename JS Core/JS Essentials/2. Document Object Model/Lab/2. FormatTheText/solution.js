function solve(){
  let textElement = document.getElementById('input');
  let text = textElement.textContent;

  let sentences = text.split(/[.?!]\s*/g);
  let outputElement = document.getElementById('output');

    while (sentences.length != 0) {
        let currentParagraphSentences = sentences.splice(0, 3);
        currentParagraphSentences.push('');

        let currentParagraphElement = document.createElement('p');
        currentParagraphElement.textContent = currentParagraphSentences.join(". ");

        outputElement.appendChild(currentParagraphElement);
    }
}