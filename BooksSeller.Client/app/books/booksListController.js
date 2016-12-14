(function () {
    "use strict";

    function booksListController(booksService) {
        var vm = this;
        booksService.getAll.query(function(books){
                vm.books = books;
            });
    }

    angular
        .module("booksSeller")
        .controller("booksListController", 
            booksListController);
}());