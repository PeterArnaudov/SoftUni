function solve(input) {
    function escapeHtml(unsafe) {
        return unsafe
            .replace(/&/g, "&amp;")
            .replace(/</g, "&lt;")
            .replace(/>/g, "&gt;")
            .replace(/"/g, "&quot;")
            .replace(/'/g, "&#39;");
    }

    let array = JSON.parse(input);

    let htmlTable = '<table>\n  <tr><th>name</th><th>score</th></tr>\n';
    for (let i = 0; i < array.length; i++) {
        let name = escapeHtml(array[i]['name'].toString());
        let score = escapeHtml(array[i]['score'].toString());
        htmlTable += `  <tr><td>${name}</td><td>${score}</td></tr>\n`;
    }
    htmlTable += '</table>';
    
    console.log(htmlTable);
}