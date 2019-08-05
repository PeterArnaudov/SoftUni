const recipeService = (() => {
    function getAllRecipes() {
        return kinvey.get('appdata', 'recipes', 'kinvey');
    }

    function getRecipe(id) {
        return kinvey.get('appdata', 'recipes/' + id, 'kinvey');
    }

    function createRecipe(data) {
        return kinvey.post('appdata', 'recipes', 'kinvey', data);
    }

    function archiveRecipe(id) {
        return kinvey.remove('appdata', 'recipes/' + id, 'kinvey');
    }

    function editRecipe(data) {
        return kinvey.update('appdata', 'recipes/' + data._id, 'kinvey', data)
    }

    return {
        getAllRecipes,
        getRecipe,
        createRecipe,
        archiveRecipe,
        editRecipe
    }
})();