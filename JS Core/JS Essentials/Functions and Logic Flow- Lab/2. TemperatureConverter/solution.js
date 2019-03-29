function solve() {
  function convert(degrees, type) {
      let resultElement = document.getElementById('result');

      if (type.toLowerCase() != 'fahrenheit' && type.toLowerCase() != 'celsius') {
          resultElement.textContent = 'Error!';
      }
      else {
          let converted = 0;

          if (type.toLowerCase() == 'celsius') {
              converted = degrees * 1.8 + 32;
          }
          else if (type.toLowerCase() == 'fahrenheit') {
              converted = (degrees - 32) / 1.8;
          }

          resultElement.textContent = `${Math.round(converted)}`;
      }
  }

  let numberInputElement = document.getElementById('num1');
  let typeInputElement = document.getElementById('type');

  let number = numberInputElement.value;
  let type = typeInputElement.value;

  let button = document.getElementsByTagName('input')[2];
  button.addEventListener('click', convert(number, type));
}