function solve() {
  function checkOccurence(text, symbol) {
      let occurence = 0;

      for (let character of text) {
          if (character == symbol) {
              occurence++
          }
      }

      let resultElement = document.getElementById('result');
      resultElement.textContent = occurence % 2 == 0 ? `Count of ${symbol} is even.` : `Count of ${symbol} is odd.`;
  }

  let stringInputElement = document.getElementById('string');
  let characterInputElement = document.getElementById('character');

  let text = stringInputElement.value;
  let symbol = characterInputElement.value;

  let button = document.getElementsByTagName('input')[2];
  button.addEventListener('click', checkOccurence(text, symbol));
}