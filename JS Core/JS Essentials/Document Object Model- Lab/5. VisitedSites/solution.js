function solve() {
    let aTagElements = document.getElementsByTagName('a');
    let spanTagElements = document.getElementsByTagName('span')
    let visits = {'softuni': 1, 'google': 2, 'youtube': 3, 'wiki': 4, 'gmail': 5, 'stack': 6};

    aTagElements[0].addEventListener('click', () => {
        visits['softuni']++;
        spanTagElements[0].textContent = `Visited: ${visits["softuni"]} times`;
    })

    aTagElements[1].addEventListener('click', () => {
        visits['google']++;
        spanTagElements[1].textContent = `Visited: ${visits['google']} times`;
    })

    aTagElements[2].addEventListener('click', () => {
        visits['youtube']++;
        spanTagElements[2].textContent = `Visited: ${visits['youtube']} times`;
    })

    aTagElements[3].addEventListener('click', () => {
        visits['wiki']++;
        spanTagElements[3].textContent = `Visited: ${visits['wiki']} times`;
    })

    aTagElements[4].addEventListener('click', () => {
        visits['gmail']++;
        spanTagElements[4].textContent = `Visited: ${visits['gmail']} times`;
    })

    aTagElements[5].addEventListener('click', () => {
        visits['stack']++;
        spanTagElements[5].textContent = `Visited: ${visits['stack']} times`;
    })
}