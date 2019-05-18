function solve() {
  function getUniqueCharacters(text) {
      let resultElement = document.getElementById('result');
      let uniqueCharacters = '';

      for (let character of text) {
          if (character == ' ') {
              uniqueCharacters += character;
          }
          else if (!uniqueCharacters.includes(character)) {
              uniqueCharacters += character;
          }
      }

      resultElement.textContent = uniqueCharacters;
  }

  let stringInputElement = document.getElementById('string');
  let string = stringInputElement.value;

  let buttonElement = document.getElementsByTagName('input')[1];
  buttonElement.addEventListener('click', getUniqueCharacters(string));
}