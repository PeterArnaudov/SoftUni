function extractText() {
    $('#result').text($('ul#items li')
        .toArray()
        .map(x => x.textContent)
        .join(', '))
}
