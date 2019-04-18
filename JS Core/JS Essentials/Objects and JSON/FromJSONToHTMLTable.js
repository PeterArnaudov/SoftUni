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

    let headColumns = '';
    for (let key of Object.keys(array[0])) {
        headColumns += `<th>${key}</th>`;
    }

    let htmlTable = `<table>\n   <tr>${headColumns}</tr>\n`;
    for (let object of array) {
        htmlTable += '   <tr>';
        for (let value of Object.values(object)) {
            htmlTable += `<td>${escapeHtml(value.toString())}</td>`;
        }
        htmlTable += '</tr>\n';
    }

    htmlTable += '</table>';

    console.log(htmlTable);
}