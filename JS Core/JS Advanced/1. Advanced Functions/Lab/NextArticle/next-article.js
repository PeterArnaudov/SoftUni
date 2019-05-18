function getArticleGenerator(articles) {
    let contentDivElement = document.getElementById('content');

    return function () {
        if (articles.length > 0) {
            let currentArticle = document.createElement('article');
            currentArticle.textContent = articles.shift();

            contentDivElement.appendChild(currentArticle);
        }
    }
}