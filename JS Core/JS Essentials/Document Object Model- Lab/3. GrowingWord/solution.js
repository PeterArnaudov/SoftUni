function solve() {
   let clicks = 0;

   document.querySelector('button').addEventListener('click', () => {
       let paragraph = document.getElementById('exercise').getElementsByTagName('p')[0];

       if (clicks % 3 == 0) {
           paragraph.style.color = 'blue';
       }
       else if (clicks % 3 == 1) {
           paragraph.style.color = 'green';
       }
       else if (clicks % 3 == 2) {
           paragraph.style.color = 'red';
       }

       clicks++;
       paragraph.style.fontSize = `${clicks * 2}px`;
    });
}